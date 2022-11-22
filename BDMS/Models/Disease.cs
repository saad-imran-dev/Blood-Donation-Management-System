using System.ComponentModel.DataAnnotations;

namespace BDMS.Models
{
    public class Disease
    {

        [Key]
        public int DiseaseId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string RejectBag { get; set; }
        [Required]
        public string RejectDonor { get; set; }

        public ICollection<TestedBags> TestedBags { get; set; }

    }
}
