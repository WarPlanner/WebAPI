using System.Text.Json.Serialization;
using ViewModels.Enumerations;
using TimeZone = ViewModels.Enumerations.TimeZone;

namespace ViewModels
{
    public class GuildViewModel
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                               FIELDS                              *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        private readonly decimal _id;
        private Language _language;
        private TimeZone _timeZone;
        private PremiumLevel _premiumLevel;
        private uint _minimalTownHallLevel;

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                             PROPERTIES                            *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public decimal Id { get => _id; }

        [JsonIgnore]
        public Language LanguageEnum { get => _language; set => _language = value; }

        [JsonIgnore]
        public TimeZone TimeZoneEnum { get => _timeZone; set => _timeZone = value; }

        public PremiumLevel PremiumLevel { get => _premiumLevel; set => _premiumLevel = value; }

        public uint MinimalTownHallLevel { get => _minimalTownHallLevel; set => _minimalTownHallLevel = value; }


        /* * * * * * * * * * * * * * * * * *\
        |*            SHORTCUTS            *|
        \* * * * * * * * * * * * * * * * * */

        public LanguageViewModel Language => new(_language);

        public TimeZoneViewModel TimeZone => new(_timeZone);

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                            CONSTRUCTORS                           *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public GuildViewModel(decimal id, TimeZone timeZone, Language language)
        {
            // Inputs
            {
                _id = id;
                _timeZone = timeZone;
                _language = language;
            }

            // Defaults
            {
                _premiumLevel = PremiumLevel.NONE;
                _minimalTownHallLevel = 0;
            }
        }
    }
}
