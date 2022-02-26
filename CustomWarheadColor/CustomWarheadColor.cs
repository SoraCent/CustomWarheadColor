using Exiled.API.Features;
using System;

namespace CustomWarheadColor
{
    public sealed class CustomWarheadColor : Plugin<Config>
    {
        public override string Author => "SoraCént";
        public override Version Version => new Version(0, 3, 0);
        public override Version RequiredExiledVersion => new Version(5, 0, 0);

        public CustomWarheadColorEventHandler Handler;

        public override void OnEnabled()
        {
            base.OnEnabled();

            Handler = new CustomWarheadColorEventHandler(this);

            Exiled.Events.Handlers.Warhead.Starting += Handler.RunWhenWarheadIsStarting;
            Exiled.Events.Handlers.Warhead.Detonated += Handler.RunWhenWarheadHasDetonated;
        }

        public override void OnDisabled()
        {
            base.OnDisabled();

            Exiled.Events.Handlers.Warhead.Starting -= Handler.RunWhenWarheadIsStarting;
            Exiled.Events.Handlers.Warhead.Detonated -= Handler.RunWhenWarheadHasDetonated;
            Handler = null;
        }
    }
}
