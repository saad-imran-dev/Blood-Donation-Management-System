using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BDMS.Models
{
    public class BloodBag
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
        public int BagId { get; set; }
>>>>>>> 4efe9cc7413690b909237a22cacc57c20d2ff2a2
>>>>>>> 9c63931c7a6d2538d2659df7840d608711421381
>>>>>>> e40a0e5acc80ad04a996495bf8b0b0446e916376
        [Required]
        public string BloodGrp { get; set; }

        [ForeignKey("Slot")]
        public int History { get; set; }
        public Slot Slot { get; set; }

        public ICollection<TestedBags> TestedBags { get; set; }

    }
}
