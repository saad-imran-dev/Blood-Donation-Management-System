using System.ComponentModel.DataAnnotations;

namespace BDMS.Models
{
    public class Disease
    {

<<<<<<< HEAD
        public int Id { get; set; }
=======
        [Key]
        public int DiseaseId { get; set; }
>>>>>>> 4efe9cc7413690b909237a22cacc57c20d2ff2a2
        [Required]
        public string Name { get; set; }
        [Required]
        public string RejectBag { get; set; }
        [Required]
        public string RejectDonor { get; set; }

        public ICollection<TestedBags> TestedBags { get; set; }

    }
}
