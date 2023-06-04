using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [PrimaryKey(nameof(GuildId), nameof(CategoryId))]
    public class Competition : EntityBase.EntityBase
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                             PROPERTIES                            *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        [Precision(30, 0)]
        public decimal GuildId { get; set; }

        [Precision(30, 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public decimal CategoryId { get; set; }

        [Precision(30, 0)]
        public decimal ResultId { get; set; }

        public string Name { get; set; } = null!;

        [MaxLength(50)]
        public string MainClan { get; set; } = null!;

        [MaxLength(50)]
        public string? SecondClan { get; set; }

        /* * * * * * * * * * * * * * * * * *\
        |*            SHORTCUTS            *|
        \* * * * * * * * * * * * * * * * * */

        public Guild Guild { get; set; } = null!;
    }
}
