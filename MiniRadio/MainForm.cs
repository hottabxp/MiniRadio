#define DEBUG
/*
 * Сделано в SharpDevelop.
 * Пользователь: Sergey Karbivnichiy
 * Дата: 24.01.2016
 * Время: 14:55
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Tags;
using System.IO;
using System.Reflection;
using System.Diagnostics;


namespace MiniRadio
{
	public partial class MainForm : Form
	{
		const string version = "1.5"; //Версия программы
		
		TabPage[] tabpage;
		TabControl tabctrl;
		int channel;			//Поток
		//int ItemIndex;			//
		float volume;			//Громкость
		//int trackballvolume;	//Позиция трекбалла
		string music_caption;	//
		string url;				//Url потока станции
		TAG_INFO tagInfo;		//Структура тегов
		ListViewItem lvi;
		public ListViewItem.ListViewSubItem tmp;
		
		
		System.Drawing.Color blue = System.Drawing.Color.PowderBlue;
		
		string playlist_dir = Environment.GetFolderPath(Environment.SpecialFolder.Personal)+"\\"+"MiniRadio"+"\\"+"playlist"+"\\";		
		
			
	public MainForm()
		{
			InitializeComponent();
			this.DesktopLocation = Properties.Settings1.Default.form_location;
			toolStripSplitButton1.Visible = false;
			String strVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
			//this.Text = "MiniRadio v"+version;
			this.Text = "MiniRadio v"+strVersion;
			this.Width = Properties.Settings1.Default.width;
			this.Height = Properties.Settings1.Default.height;
			CreateControls(blue);
			panel2.BackColor = blue;

			tabctrl.SelectTab(1);
			BassNet.Registration("buddyknox@usa.org","2X11841782815");
			Bass.BASS_Init (-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
			SetBackColor(blue);
			trackBar1.Value = Properties.Settings1.Default.volume;
			Bass.BASS_ChannelSlideAttribute(channel, BASSAttribute.BASS_ATTRIB_VOL,trackBar1.Value/100f,0);
			volume = trackBar1.Value/100f;
			tabctrl.SelectedIndex = Properties.Settings1.Default.activeTab;
			tmp = null;
		}
	
	
	
#region Create controls	
	void CreateControls(System.Drawing.Color color)
	{
			tabctrl = new TabControl();
			tabctrl.Dock = DockStyle.Fill;
			tabctrl.Parent = panel2;
			tabctrl.Show();

		using (StreamReader sReader = new StreamReader(playlist_dir+"list.txt"))
        {
			int length = File.ReadAllLines(playlist_dir+"list.txt").Length;
				
			tabpage = new TabPage[length];
			ListView[] listview = new ListView[length];
			ListViewItem[] listviewitem = new ListViewItem[length];
			
          string line;
          int i = 0;
          
          while ((line = sReader.ReadLine()) != null)
                {
          	string[] values = line.Split('|');
          	
          	tabpage[i] = new TabPage(values[0]);
          	tabpage[i].Name = i.ToString();
          	tabpage[i].Parent = tabctrl;
          	tabpage[i].BackColor = color;

          	listview[i] = new ListView();
          	listview[i].Name = "listview"+i.ToString();
          	listview[i].DoubleClick += (lv_DoubleClick);
          	listview[i].Dock = DockStyle.Fill;
          	listview[i].GridLines = true;
          	listview[i].View = View.Details;
          	listview[i].Parent = tabpage[i];
          	listview[i].BackColor = color;
          	listview[i].Columns.Add("Станция",175);
          	LoadLlaylist(values[1],listview[i]);
          	 i = i+1;
             	}
         
           }		
	}
#endregion	
	
	
		void lv_DoubleClick(object sender, EventArgs e)
		{
			
			ListView lv = sender as ListView;
			
			//lv.Refresh();
			//tmp.BackColor = Color.Blue;
			Play(lv.FocusedItem.SubItems[1].Text,volume);
			//lv.Items[0].BackColor = Color.Red;
			
			if (tmp != null) {
				
				tmp.BackColor = Color.PowderBlue;
			}
			
			tabctrl.SelectedTab.BackColor = Color.Red;
			
			tmp = lv.FocusedItem.SubItems[0];
			
			lv.FocusedItem.SubItems[0].BackColor = Color.Red;
		}



		
	void Play(string url,float volume)
	{
			Bass.BASS_ChannelStop(channel);      
			channel = Bass.BASS_StreamCreateURL(url, 0, BASSFlag.BASS_DEFAULT, null, IntPtr.Zero);
			Bass.BASS_ChannelSetAttribute(channel,BASSAttribute.BASS_ATTRIB_VOL,volume);
			Bass.BASS_ChannelPlay(channel,true);
			timer1.Start();
	}
	
	void Pause(int potok)
	{
		Bass.BASS_ChannelPause(channel);
	}
		
		void SetBackColor(Color color)
		{
			this.BackColor = color;
			label1.BackColor = color;
			trackBar1.BackColor = color;
		}
		
		void LoadLlaylist(string filename,ListView listview)
		{			
			listview.Items.Clear();
		    using (StreamReader sReader = new StreamReader(playlist_dir+filename))
            {
                string line;

                while ((line = sReader.ReadLine()) != null)
                {
                	if (line.IndexOf("#") != 0)
                	{
			       		string[] values = line.Split('|');
                   		lvi = new ListViewItem(values);
                   		listview.Items.Add(lvi);
                	}
            	}	
			}			
		}
#region Events


	
		void TrackBar1Scroll(object sender, EventArgs e)
		{
			volume = trackBar1.Value/100f;
			Bass.BASS_ChannelSetAttribute(channel,BASSAttribute.BASS_ATTRIB_VOL,volume);
			Properties.Settings1.Default.volume = trackBar1.Value;
		}
		

		
		void PauseClick(object sender, EventArgs e)
		{
			Bass.BASS_ChannelPause(channel);
		}
		
		void Play_btnClick(object sender, EventArgs e)
		{
			Bass.BASS_ChannelPlay(channel,false);
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings1.Default.activeTab = tabctrl.SelectedIndex;
			Properties.Settings1.Default.Save();
		}
		
		void MainFormLocationChanged(object sender, EventArgs e)
		{
			Properties.Settings1.Default.form_location = this.Location;
		}

		
		void Timer1Tick(object sender, EventArgs e)
		{
			tagInfo = new TAG_INFO(url);
			BassTags.BASS_TAG_GetFromURL(channel,tagInfo);
			music_caption = tagInfo.artist+" - "+tagInfo.title;
			
			if (music_caption.IndexOf("[")  > 0)
			{
				music_caption = music_caption.Remove(music_caption.IndexOf("["),music_caption.IndexOf("]")-music_caption.IndexOf("[")+1);
			}
			
			label1.Text = music_caption;
			//notifyIcon1.Text = music_caption;
		}
		
		void ToolStripButton5Click(object sender, EventArgs e)
		{
			Process.Start("http://www.last.fm/search?q="+tagInfo.artist);
		}
		
		void Pause_btnClick(object sender, EventArgs e)
		{
			Bass.BASS_ChannelPause(channel);
		}
		
		void Youtube_btnClick(object sender, EventArgs e)
		{
			Process.Start("http://www.youtube.com/results?search_query="+music_caption);
		}
		
		void Vk_btnClick(object sender, EventArgs e)
		{
			Process.Start("http://vk.com/audio?q="+music_caption);
		}
		
		void MainFormResize(object sender, EventArgs e)
		{
			Properties.Settings1.Default.height = this.Height;
			Properties.Settings1.Default.width = this.Width;
			
		if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
		}
	
		void NotifyIcon1DoubleClick(object sender, EventArgs e)
		{
		    this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;				
		}
		
#endregion		
	}
}
