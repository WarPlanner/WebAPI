using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [PrimaryKey(nameof(GuildId), nameof(Action), nameof(Additional))]
    public class Time : EntityBase.EntityBase
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                             PROPERTIES                            *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        [Precision(30, 0)]
        public decimal GuildId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public uint Action { get; set; }

        public DateTimeOffset Date { get; set; }

        public uint Interval { get; set; }

        public string Additional { get; set; } = null!;

        public string? Optional { get; set; }

        /* * * * * * * * * * * * * * * * * *\
        |*            SHORTCUTS            *|
        \* * * * * * * * * * * * * * * * * */

        public Guild Guild { get; set; } = null!;
    }
}
