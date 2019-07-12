using System;
using System.Collections.Generic;
using Telligent.Evolution.Extensibility.Version1;

namespace ArdourDigital.TelligentCommunity.MinutesToRead
{
    public class MinutesToReadPlugin : IPlugin, IPluginGroup
    {
        public string Description
        {
            get
            {
                return "Widgets and Extensions to allow the estimated number of minutes of content to be displayed.";
            }
        }

        public string Name
        {
            get
            {
                return "Ardour Digital - Minutes to Read";
            }
        }

        public IEnumerable<Type> Plugins
        {
            get
            {
                yield return typeof(MinutesToReadContentFragmentProvider);
                yield return typeof(MinutesToReadVelocityExtension);
            }
        }

        public void Initialize()
        {
        }
    }
}
