using Terraria.ModLoader.Config;

namespace TwitchInteractive.Common.Configs
{
    public class TwitchConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        
        [Label("Connect to Twitch")]
        [Tooltip("Turns on and off the connection to Twitch.")]
        [BackgroundColor(100, 65, 165)]
        [DefaultDictionaryKeyValue(false)]
        public bool connectToTwitch;
    }
}