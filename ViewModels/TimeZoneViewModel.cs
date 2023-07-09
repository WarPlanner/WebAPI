using ViewModels.Enumerations;
using TimeZone = ViewModels.Enumerations.TimeZone;

namespace ViewModels
{
    public class TimeZoneViewModel
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                               FIELDS                              *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        private readonly int _id;
        private readonly string _nameValue;
        private readonly string _zoneValue;

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                             PROPERTIES                            *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public int Id { get => _id; }

        public string NameValue { get => _nameValue; }

        public string ZoneValue { get => _zoneValue; }

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                            CONSTRUCTORS                           *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public TimeZoneViewModel(TimeZone timeZone)
        {
            // Inputs
            {
                _id = (int)timeZone;
                _nameValue = timeZone.AsAttribute().DisplayName;
                _zoneValue = timeZone.AsAttribute().Zone;
            }
        }
    }
}
