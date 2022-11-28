using System.ComponentModel.DataAnnotations;

namespace BDMS.Models
{
    public class Disease
    {
<<<<<<< HEAD
        public int Id { get; set; }
=======
<<<<<<< HEAD
        public int Id { get; set; }
=======

<<<<<<< HEAD
        public int Id { get; set; }
=======
        [Key]
        public int DiseaseId { get; set; }
>>>>>>> 4efe9cc7413690b909237a22cacc57c20d2ff2a2
>>>>>>> 9c63931c7a6d2538d2659df7840d608711421381
>>>>>>> e40a0e5acc80ad04a996495bf8b0b0446e916376
        [Required]
        public string Name { get; set; }
        [Required]
        public string RejectBag { get; set; }
        [Required]
        public string RejectDonor { get; set; }

        public ICollection<TestedBags> TestedBags { get; set; }

    }
}
