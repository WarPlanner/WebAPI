using System.Text.Json.Serialization;

namespace ViewModels
{
    public class CompetitionViewModel
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                               FIELDS                              *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        private readonly decimal guildId;
        private readonly decimal id;
        private decimal resultChannelId;
        private string name;
        private string principalClanTag;
        private string? secondaryClanTag;

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                             PROPERTIES                            *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        [JsonIgnore]
        public decimal GuildId { get => guildId; }

        public decimal Id { get => id; }

        public decimal ResultChannelId { get => resultChannelId; set => resultChannelId = value; }

        public string Name { get => name; set => name = value; }

        public string PrincipalClanTag { get => principalClanTag; set => principalClanTag = value; }

        public string? SecondaryClanTag { get => secondaryClanTag; set => secondaryClanTag = value; }

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                            CONSTRUCTORS                           *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public CompetitionViewModel(decimal guildId, decimal id, decimal resultChannelId, string name, string principalClanTag)
        {
            // Inputs
            {
                this.guildId = guildId;
                this.id = id;
                this.resultChannelId = resultChannelId;
                this.name = name;
                this.principalClanTag = principalClanTag;
            }
        }
    }
}
