using Exiled.API.Interfaces;
using System.ComponentModel;

namespace CustomWarheadColor
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("Light Color R = Red, G = Green, B = Blue from 0-255 | Default 0,128,255 = Dodger Blue")]
        public int WarheadColorR { get; set; } = 0;
        public int WarheadColorG { get; set; } = 128;
        public int WarheadColorB { get; set; } = 255;

        [Description("Activate this if you want that the Light is getting of after Warhead detonation | Default = true")]
        public bool EnableNoLightAfterDetonate { get; set; } = true;
        [Description("Sets how long the Lights are off in Seconds")]
        public float NoLightAfterDetonateDuration { get; set; } = 60f;
        
        [Description("Activate this if you want Custom Lightcolor after the Warhead detonated | Default = false")]
        public bool EnableCustomLightColorAfterDetonate { get; set; } = false;
        
        [Description("Light Color R = Red, G = Green, B = Blue from 0-255 | Default 0,0,0 = Black - looks like the light is off")]
        public int WarheadColorAfterDetonationR { get; set; } = 0;
        public int WarheadColorAfterDetonationG { get; set; } = 0;
        public int WarheadColorAfterDetonationB { get; set; } = 0;
    }
}
