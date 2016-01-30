﻿/*
 * Сделано в SharpDevelop.
 * Пользователь: Artemiy
 * Дата: 24.01.2016
 * Время: 14:55
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace MiniRadio
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.добавитьВЛюбимыеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.Play_btn = new System.Windows.Forms.ToolStripButton();
			this.Pause_btn = new System.Windows.Forms.ToolStripButton();
			this.Youtube_btn = new System.Windows.Forms.ToolStripButton();
			this.Vk_btn = new System.Windows.Forms.ToolStripButton();
			this.LastFM_btn = new System.Windows.Forms.ToolStripButton();
			this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
			this.listView1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1});
			this.listView1.ContextMenuStrip = this.contextMenuStrip1;
			this.listView1.ForeColor = System.Drawing.SystemColors.InfoText;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(12, 71);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(283, 357);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView1MouseDoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Станция";
			this.columnHeader1.Width = 225;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.добавитьВЛюбимыеToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(195, 26);
			// 
			// добавитьВЛюбимыеToolStripMenuItem
			// 
			this.добавитьВЛюбимыеToolStripMenuItem.Name = "добавитьВЛюбимыеToolStripMenuItem";
			this.добавитьВЛюбимыеToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.добавитьВЛюбимыеToolStripMenuItem.Text = "Добавить в любимые";
			this.добавитьВЛюбимыеToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьВЛюбимыеToolStripMenuItemClick);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "button_blue_play.png");
			this.imageList1.Images.SetKeyName(1, "music_3996.png");
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(12, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(204, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Title";
			// 
			// trackBar1
			// 
			this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
			this.trackBar1.Location = new System.Drawing.Point(222, 42);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(73, 45);
			this.trackBar1.TabIndex = 1;
			this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1Scroll);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.Play_btn,
									this.Pause_btn,
									this.Youtube_btn,
									this.Vk_btn,
									this.LastFM_btn,
									this.toolStripSplitButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(307, 39);
			this.toolStrip1.TabIndex = 10;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// Play_btn
			// 
			this.Play_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Play_btn.Image = ((System.Drawing.Image)(resources.GetObject("Play_btn.Image")));
			this.Play_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Play_btn.Name = "Play_btn";
			this.Play_btn.Size = new System.Drawing.Size(36, 36);
			this.Play_btn.Click += new System.EventHandler(this.Play_btnClick);
			// 
			// Pause_btn
			// 
			this.Pause_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Pause_btn.Image = ((System.Drawing.Image)(resources.GetObject("Pause_btn.Image")));
			this.Pause_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Pause_btn.Name = "Pause_btn";
			this.Pause_btn.Size = new System.Drawing.Size(36, 36);
			this.Pause_btn.Click += new System.EventHandler(this.Pause_btnClick);
			// 
			// Youtube_btn
			// 
			this.Youtube_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Youtube_btn.Image = ((System.Drawing.Image)(resources.GetObject("Youtube_btn.Image")));
			this.Youtube_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Youtube_btn.Name = "Youtube_btn";
			this.Youtube_btn.Size = new System.Drawing.Size(36, 36);
			this.Youtube_btn.Click += new System.EventHandler(this.Youtube_btnClick);
			// 
			// Vk_btn
			// 
			this.Vk_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Vk_btn.Image = ((System.Drawing.Image)(resources.GetObject("Vk_btn.Image")));
			this.Vk_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Vk_btn.Name = "Vk_btn";
			this.Vk_btn.Size = new System.Drawing.Size(36, 36);
			this.Vk_btn.Click += new System.EventHandler(this.Vk_btnClick);
			// 
			// LastFM_btn
			// 
			this.LastFM_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.LastFM_btn.Image = ((System.Drawing.Image)(resources.GetObject("LastFM_btn.Image")));
			this.LastFM_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.LastFM_btn.Name = "LastFM_btn";
			this.LastFM_btn.Size = new System.Drawing.Size(36, 36);
			this.LastFM_btn.Click += new System.EventHandler(this.ToolStripButton5Click);
			// 
			// toolStripSplitButton1
			// 
			this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripMenuItem1,
									this.toolStripMenuItem2});
			this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
			this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton1.Name = "toolStripSplitButton1";
			this.toolStripSplitButton1.Size = new System.Drawing.Size(48, 36);
			this.toolStripSplitButton1.Text = "toolStripSplitButton1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
			this.toolStripMenuItem1.Text = "toolStripMenuItem1";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(179, 22);
			this.toolStripMenuItem2.Text = "toolStripMenuItem2";
			// 
			// imageList2
			// 
			this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
			this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList2.Images.SetKeyName(0, "button_blue_pause.png");
			this.imageList2.Images.SetKeyName(1, "button_blue_play.png");
			this.imageList2.Images.SetKeyName(2, "vkontakte.png");
			this.imageList2.Images.SetKeyName(3, "youtube.png");
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(307, 435);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.trackBar1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.HelpButton = true;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "MiniRadio";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.LocationChanged += new System.EventHandler(this.MainFormLocationChanged);
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
		private System.Windows.Forms.ToolStripButton LastFM_btn;
		private System.Windows.Forms.ImageList imageList2;
		private System.Windows.Forms.ToolStripButton Vk_btn;
		private System.Windows.Forms.ToolStripButton Youtube_btn;
		private System.Windows.Forms.ToolStripButton Pause_btn;
		private System.Windows.Forms.ToolStripButton Play_btn;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.ToolStripMenuItem добавитьВЛюбимыеToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listView1;
		

	}
}