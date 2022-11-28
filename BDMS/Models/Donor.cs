using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BDMS.Models
{
    public class Donor
    {
<<<<<<< HEAD
=======
<<<<<<< HEAD
        public int Id { get; set; }
        [Required]
        public string Cnic { get; set; }
=======
<<<<<<< HEAD
>>>>>>> e40a0e5acc80ad04a996495bf8b0b0446e916376
        public int Id { get; set; }
        public int Cnic { get; set; }
<<<<<<< HEAD
=======
>>>>>>> 4efe9cc7413690b909237a22cacc57c20d2ff2a2
>>>>>>> 9c63931c7a6d2538d2659df7840d608711421381
>>>>>>> e40a0e5acc80ad04a996495bf8b0b0446e916376
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        [ForeignKey("Area")]
        public int AreaCode { get; set; }
        public Area Area { get; set; }

        public ICollection<Slot> Slots { get; set; }

    }
}
