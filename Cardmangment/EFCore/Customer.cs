using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cardmangment.EFCore
{
    [Table("customer")]
    public class Customer
    {
        [Key,Required]
        public int id { get; set; }

        public string firtsname { get; set; } = string.Empty;

        public string surname { get; set; } = string.Empty;

        public int TC { get; set; }

    }
}
