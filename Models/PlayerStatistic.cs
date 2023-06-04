using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [PrimaryKey(nameof(DiscordId), nameof(ClanTag), nameof(WarDateStart), nameof(AttackOrder))]
    public class PlayerStatistic : EntityBase.EntityBase
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                             PROPERTIES                            *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        [Precision(30, 0)]
        public decimal GuildId { get; set; }

        [Precision(30, 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public decimal DiscordId { get; set; }

        [MaxLength(50)]
        public string PlayerTag { get; set; } = null!;

        [MaxLength(50)]
        public string ClanTag { get; set; } = null!;

        public DateTimeOffset WarDateStart { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public uint AttackOrder { get; set; }

        public uint WarType { get; set; }

        public uint StatisticType { get; set; }

        public uint StatisticAction { get; set; }

        public uint Stars { get; set; }

        public uint Percentage { get; set; }

        public uint Duration { get; set; }

        /* * * * * * * * * * * * * * * * * *\
        |*            SHORTCUTS            *|
        \* * * * * * * * * * * * * * * * * */

        public Guild Guild { get; set; } = null!;
    }
}
