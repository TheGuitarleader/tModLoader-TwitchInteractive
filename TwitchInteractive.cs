using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace TwitchInteractive
{
	// Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
	public class TwitchInteractive : Mod
	{
		// Event to connect to Twitch
		public override void Load()
		{
			base.Load();
		}
		
		// Event to shut down the Twitch connection.
		public override void Unload()
		{
			base.Unload();
		}
	}
}
