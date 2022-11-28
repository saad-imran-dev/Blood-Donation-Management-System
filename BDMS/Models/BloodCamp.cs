using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BDMS.Models
{
<<<<<<< HEAD
    public class BloodCamp
    {
        public int Id { get; set; }

=======
    [PrimaryKey(nameof(OrgCode), nameof(AreaCode))]
    public class BloodCamp
    {
>>>>>>> 4efe9cc7413690b909237a22cacc57c20d2ff2a2
        [ForeignKey("Organization")]
        public int OrgCode { get; set; }
        public Organization Organization { get; set; }

        [ForeignKey("Area")]
        public int AreaCode { get; set; }
        public Area Area { get; set; }

        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        public int beds { get; set; }

    }
}
