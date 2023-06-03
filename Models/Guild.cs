using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Guild : EntityBase.EntityBase
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                             PROPERTIES                            *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        [Key]
        [Precision(30, 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public decimal Id { get; set; }

        public uint Language { get; set; }

        public uint PremiumLevel { get; set; }

        public uint MinThLevel { get; set; }

        /* * * * * * * * * * * * * * * * * *\
        |*            SHORTCUTS            *|
        \* * * * * * * * * * * * * * * * * */

        public Calendar? Calendar { get; set; }

        public ICollection<Clan> Clans { get; } = new List<Clan>();

        public ICollection<Competition> Competitions { get; } = new List<Competition>();

        public ICollection<PlayerStatistic> PlayerStatistics { get; } = new List<PlayerStatistic>();

        public ICollection<Player> Players { get; } = new List<Player>();

        public ICollection<Role> Roles { get; } = new List<Role>();

        public ICollection<Time> Times { get; } = new List<Time>();

        public ICollection<WarStatistic> WarStatistics { get; } = new List<WarStatistic>();
    }
}
