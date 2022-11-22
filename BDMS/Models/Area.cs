using System.ComponentModel.DataAnnotations;

namespace BDMS.Models
{
    public class Area
    {
        [Key]
        public int Code { get; set; }
        [Required] 
        public string? Name { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public string? Province { get; set; }

        public ICollection<Organization> Organizations { get; set; }
        public ICollection<BloodCamp> BloodCamps { get; set; }
        public ICollection<Emplopyee> Emplopyees { get; set; }
        public ICollection<Donor> Donors { get; set; }
        public ICollection<Slot> Slots { get; set; }

    }
}
