using System;
using Un4seen.Bass;

namespace MiniRadio
{

	public class _Bass
	{
		public _Bass()
		{
		}
		
		public static void Pause(int stream)
		{
			Bass.BASS_ChannelPause(stream);
		}
	}
}
