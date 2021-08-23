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
    }
}
