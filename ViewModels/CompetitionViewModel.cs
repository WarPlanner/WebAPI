using System.Text.Json.Serialization;

namespace ViewModels
{
    public class CompetitionViewModel
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                               FIELDS                              *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        private readonly decimal _guildId;
        private readonly decimal _id;
        private decimal _resultChannelId;
        private string _name;
        private string _principalClanTag;
        private string? _secondaryClanTag;

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                             PROPERTIES                            *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        [JsonIgnore]
        public decimal GuildId { get => _guildId; }

        public decimal Id { get => _id; }

        public decimal ResultChannelId { get => _resultChannelId; set => _resultChannelId = value; }

        public string Name { get => _name; set => _name = value; }

        public string PrincipalClanTag { get => _principalClanTag; set => _principalClanTag = value; }

        public string? SecondaryClanTag { get => _secondaryClanTag; set => _secondaryClanTag = value; }

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                            CONSTRUCTORS                           *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public CompetitionViewModel(decimal guildId, decimal id, decimal resultChannelId, string name, string principalClanTag)
        {
            // Inputs
            {
                _guildId = guildId;
                _id = id;
                _resultChannelId = resultChannelId;
                _name = name;
                _principalClanTag = principalClanTag;
            }
        }
    }
}
