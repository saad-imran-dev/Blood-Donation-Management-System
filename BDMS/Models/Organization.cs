using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BDMS.Models
{
    public class Organization
    {
        [Key]
        public int Code { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Desc { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? Address { get; set; }

        [ForeignKey("Area")]
        public int AreaCode { get; set; }
        public Area Area { get; set; }

        public ICollection<BloodCamp> BloodCamps { get; set; }
        public ICollection<Emplopyee> Emplopyees { get; set; }
        public ICollection<Slot> Slots { get; set; }
    }
}
