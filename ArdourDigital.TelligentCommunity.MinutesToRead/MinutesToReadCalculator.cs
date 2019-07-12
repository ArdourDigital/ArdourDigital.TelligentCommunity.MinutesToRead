using System;
using Telligent.Evolution.Extensibility;
using Telligent.Evolution.Extensibility.Api.Version1;

namespace ArdourDigital.TelligentCommunity.MinutesToRead
{
    public class MinutesToReadCalculator
    {
        private readonly int _wordsPerMinute = 200;
        private readonly IContents _content;

        public MinutesToReadCalculator()
        {
            _content = Apis.Get<IContents>();
        }

        public int? GetNumberOfMinutesToRead(Guid contentId, Guid contentTypeId)
        {
            var content = _content.Get(contentId, contentTypeId);

            if (content == null)
            {
                return null;
            }

            var body = content.HtmlDescription("Raw");

            if (string.IsNullOrWhiteSpace(body))
            {
                return null;
            }

            var words = body.Split(new[] { ' ' });

            return (int)Math.Ceiling(words.Length / (decimal)_wordsPerMinute);
        }
    }
}
