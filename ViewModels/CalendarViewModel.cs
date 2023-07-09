﻿using System.Text.Json.Serialization;

namespace ViewModels
{
    public class CalendarViewModel
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                               FIELDS                              *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        private readonly decimal _guildId;
        private string _id;
        private decimal? _channelId;
        private decimal? _messageId;

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                             PROPERTIES                            *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        [JsonIgnore]
        public decimal GuildId { get => _guildId; }

        public string Id { get => _id; set => _id = value; }

        public decimal? ChannelId { get => _channelId; set => _channelId = value; }

        public decimal? MessageId { get => _messageId; set => _messageId = value; }

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                            CONSTRUCTORS                           *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public CalendarViewModel(decimal guildId, string id)
        {
            // Inputs
            {
                _guildId = guildId;
                _id = id;
            }
        }
    }
}
