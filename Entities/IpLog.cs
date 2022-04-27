using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ANDREYRK.Entities
{
    [Table("IpLog")]
    public class IpLog
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Address { get; set; }

        public string Path { get; set; }
    }
}
