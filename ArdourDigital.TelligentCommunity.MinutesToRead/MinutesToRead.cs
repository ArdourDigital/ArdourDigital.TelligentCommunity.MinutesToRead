using ArdourDigital.TelligentCommunity.Core.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArdourDigital.TelligentCommunity.MinutesToRead
{
    public class MinutesToRead : IContentFragment
    {
        public string DefinitionFile
        {
            get
            {
                return "ArdourDigital.TelligentCommunity.MinutesToRead.Resources.MinutesToRead.MinutesToRead.xml";
            }
        }

        public Guid FragmentId
        {
            get
            {
                return new Guid("84862e73-8367-43f3-a5ba-103a4b4dc9a0");
            }
        }

        public IEnumerable<SupplementaryFile> SupplementaryFiles
        {
            get
            {
                return Enumerable.Empty<SupplementaryFile>();
            }
        }
    }
}
