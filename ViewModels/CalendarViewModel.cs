using System.Text.Json.Serialization;

namespace ViewModels
{
    public class CalendarViewModel
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                               FIELDS                              *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        private readonly decimal guildId;
        private string id;
        private decimal? channelId;
        private decimal? messageId;

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                             PROPERTIES                            *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        [JsonIgnore]
        public decimal GuildId { get => guildId; }

        public string Id { get => id; set => id = value; }

        public decimal? ChannelId { get => channelId; set => channelId = value; }

        public decimal? MessageId { get => messageId; set => messageId = value; }

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                            CONSTRUCTORS                           *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public CalendarViewModel(decimal guildId, string id)
        {
            // Inputs
            {
                this.guildId = guildId;
                this.id = id;
            }
        }
    }
}
