using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Calendar : EntityBase.EntityBase
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                             PROPERTIES                            *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        [Key]
        [Precision(30, 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public decimal GuildId { get; set; }

        public string Id { get; set; } = null!;

        [Precision(30, 0)]
        public decimal? ChannelId { get; set; }

        [Precision(30, 0)]
        public decimal? MessageId { get; set; }

        /* * * * * * * * * * * * * * * * * *\
        |*            SHORTCUTS            *|
        \* * * * * * * * * * * * * * * * * */

        public Guild Guild { get; set; } = null!;
    }
}
