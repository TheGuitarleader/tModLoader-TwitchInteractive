using System.ComponentModel;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace TwitchInteractive.Common.Configs
{
    public class TwitchServerConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        public override void OnChanged()
        {
            Mod.Logger.Info("Reloading server changes...");
            base.OnChanged();
        }

        public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref NetworkText message)
        {
            if (!TwitchInteractive.IsLocalPlayerServerOwner(Main.player[whoAmI]))
            {
                message = this.GetLocalization("YouAreNotServerOwnerCantChangeConfig").ToNetworkText();
                return false;
            }
            
            return base.AcceptClientChanges(pendingConfig, whoAmI, ref message);
        }

        [Label("Connect to Twitch")]
        [Tooltip("Enables and disables the connection to Twitch.")]
        [BackgroundColor(100, 65, 165)]
        [DefaultValue(false)]
        public static bool ConnectToTwitch;
    }
}