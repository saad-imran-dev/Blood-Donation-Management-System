using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BDMS.Models
{
    public class Slot
    {
<<<<<<< HEAD
        public int Id { get; set; }
=======
<<<<<<< HEAD
        public int Id { get; set; }
        public int SlotNo { get; set; }
=======
<<<<<<< HEAD
        public int Id { get; set; }
=======
        [Key]
        public int SlotNo { get; set; }
>>>>>>> 4efe9cc7413690b909237a22cacc57c20d2ff2a2
>>>>>>> 9c63931c7a6d2538d2659df7840d608711421381
>>>>>>> e40a0e5acc80ad04a996495bf8b0b0446e916376
        [Required]
        public DateTime Time { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public int bedno { get; set; }
        [Required]
        public String CanDonate { get; set; }

        [ForeignKey("Organization")]
        public int OrgCode { get; set; }
        public Organization Organization { get; set; }

        [ForeignKey("Area")]
        public int AreaCode { get; set; }
        public Area Area { get; set; }

        [ForeignKey("Donor")]
        public int DonorCnic { get; set; }
        public Donor Donor { get; set; }

        public ICollection<BloodBag> BloodBags { get; set; }
    }
}
