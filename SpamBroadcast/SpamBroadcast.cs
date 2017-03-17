using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.Core.Plugins;
using Rocket.API.Collections;
using Rocket.Core.Logging;

namespace SpamBroadcast
{
    public class SpamBroadcast : RocketPlugin
    {
        #region Properties
        public static SpamBroadcast Instance { get; private set; }
        #endregion

        protected override void Load()
        {
            Instance = this;

            Logger.Log("Spam Broadcast loaded successfully!");
        }

        protected override void Unload()
        {
            Logger.Log("Spam Broadcast unloaded successfully!");
        }

        #region Functions
        public override TranslationList DefaultTranslations
        {
            get
            {
                return new TranslationList()
                {
                    // Nothing to see here
                };
            }
        }
        #endregion
    }
}
