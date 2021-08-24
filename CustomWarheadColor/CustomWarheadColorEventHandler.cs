using Exiled.API.Features;
using Exiled.Events.EventArgs;
using UnityEngine;

namespace CustomWarheadColor
{
    public sealed class CustomWarheadColorEventHandler
    {
        public CustomWarheadColor plugin;
        public CustomWarheadColorEventHandler(CustomWarheadColor plugin) => this.plugin = plugin;
    
        public void RunWhenWarheadIsStarting(StartingEventArgs ev)
        {
            foreach (FlickerableLightController controller in FlickerableLightController.Instances)
            {
                controller.WarheadLightOverride = false;
                Color WarheadColor = new Color(plugin.Config.WarheadColorR / 255f, plugin.Config.WarheadColorG / 255f, plugin.Config.WarheadColorB / 255f);
                controller.WarheadLightColor = WarheadColor;

            }
        }

        public void RunWhenWarheadHasDetonated()
        {
            if(plugin.Config.EnableNoLightAfterDetonate)
            {
                Map.TurnOffAllLights(plugin.Config.NoLightAfterDetonateDuration);   
            }

            if (plugin.Config.EnableCustomLightColorAfterDetonate)
            {
                foreach (FlickerableLightController controller in FlickerableLightController.Instances)
                {
                    controller.WarheadLightOverride = false;
                    Color WarheadColor = new Color(plugin.Config.WarheadColorAfterDetonationR / 255f, plugin.Config.WarheadColorAfterDetonationG / 255f, plugin.Config.WarheadColorAfterDetonationB / 255f);
                    controller.WarheadLightColor = WarheadColor;
                }
            }
        }
    }
}
