using Telligent.Evolution.Extensibility.UI.Version1;
using Telligent.Evolution.Extensibility.Version1;

namespace ArdourDigital.TelligentCommunity.MinutesToRead
{
    public class MinutesToReadVelocityExtension : IScriptedContentFragmentExtension, IPlugin
    {
        public string Description
        {
            get
            {
                return "Provides methods for estimating the minutes to read a piece of content.";
            }
        }

        public object Extension
        {
            get
            {
                return new MinutesToReadCalculator();
            }
        }

        public string ExtensionName
        {
            get
            {
                return "ardour_v1_minutesToRead";
            }
        }

        public string Name
        {
            get
            {
                return "Ardour Digital - Minutes to Read - Velocity Extension";
            }
        }

        public void Initialize()
        {
        }
    }
}
