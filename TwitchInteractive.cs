using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace TwitchInteractive
{
	// Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
	public class TwitchInteractive : Mod
	{
		public static TwitchInteractive Instance => ModContent.GetInstance<TwitchInteractive>();
		public static TwitchService ChatService;
		
		// Event to connect to Twitch
		public override void Load()
		{
			//ChatService.Start();
			base.Load();
		}
		
		// Event to shut down the Twitch connection.
		public override void Unload()
		{
			//ChatService.Stop();
			base.Unload();
		}

		public static bool IsLocalPlayerServerOwner(Player player)
		{
			if (Main.netMode == 1)
			{
				return Netplay.Connection.Socket.GetRemoteAddress().IsLocalHost();
			}

			for (int plr = 0; plr < Main.maxPlayers; plr++)
			{
				if (Netplay.Clients[plr].State == 10 && Main.player[plr] == player && Netplay.Clients[plr].Socket.GetRemoteAddress().IsLocalHost())
				{
					return true;
				}
			}

			return false;
		}
	}
}
