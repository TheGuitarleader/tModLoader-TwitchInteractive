using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace TwitchInteractive.Common.Configs
{
    public class TwitchApiConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        public override void OnChanged()
        {
            Mod.Logger.Info("Reloading api changes...");
            //TwitchInteractive.ChatService = new TwitchService();
            //TwitchInteractive.ChatService.Start();
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
        
        [Label("Client ID")]
        [Tooltip("Passed to authorization endpoints to identify your application. You cannot change your application's client id.")]
        public string ClientId { get; set; }
        
        [Label("Client Secret")]
        [Tooltip("Passed to the token exchange endpoints to obtain a token. You must keep this confidential.")]
        public string ClientSecret { get; set; }
    }
}