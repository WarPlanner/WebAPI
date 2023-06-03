using Microsoft.EntityFrameworkCore;

namespace Models
{
    [PrimaryKey(nameof(DateStart), nameof(ClanTag))]
    public class WarStatistic
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                             PROPERTIES                            *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        [Precision(30, 0)]
        public decimal GuildId { get; set; }

        public DateTimeOffset DateStart { get; set; }

        public uint WarType { get; set; }

        public string ClanTag { get; set; } = null!;

        [Precision(30, 0)]
        public decimal? CompetitionCategoryId { get; set; }

        public string OpponentName { get; set; } = null!;

        public uint Result { get; set; }

        public uint AttackStars { get; set; }

        [Precision(5, 2)]
        public decimal AttackPercent { get; set; }

        [Precision(5, 2)]
        public decimal AttackAvgDuration { get; set; }

        public uint DefenseStars { get; set; }

        [Precision(5, 2)]
        public decimal DefensePercent { get; set; }

        [Precision(5, 2)]
        public decimal DefenseAvgDuration { get; set; }

        /* * * * * * * * * * * * * * * * * *\
        |*            SHORTCUTS            *|
        \* * * * * * * * * * * * * * * * * */

        public Guild Guild { get; set; } = null!;
    }
}
