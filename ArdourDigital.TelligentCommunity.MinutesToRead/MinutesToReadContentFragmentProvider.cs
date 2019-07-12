using ArdourDigital.TelligentCommunity.Core.UI;
using System;
using Telligent.Evolution.Extensibility.UI.Version1;
using Telligent.Evolution.Extensibility.Version1;

namespace ArdourDigital.TelligentCommunity.MinutesToRead
{
    public class MinutesToReadContentFragmentProvider : BaseContentFragmentProvider, IPlugin, IScriptedContentFragmentFactoryDefaultProvider, IInstallablePlugin
    {
        public override string Description
        {
            get
            {
                return "Widgets for showing an estimate of the time to read content";
            }
        }

        public override string Name
        {
            get
            {
                return "Ardour Digital - Time to Read - Content Fragments";
            }
        }

        public override Guid ScriptedContentFragmentFactoryDefaultIdentifier
        {
            get
            {
                return new Guid("ace8c006-b7b0-4728-a9a9-e5c36461973f");
            }
        }
    }
}
