using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BDMS.Models
{
    public class Organization
    {
<<<<<<< HEAD
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
=======
<<<<<<< HEAD
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
=======
<<<<<<< HEAD
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
=======
>>>>>>> 9c63931c7a6d2538d2659df7840d608711421381
        [Key]
        public int Code { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
<<<<<<< HEAD
=======
>>>>>>> 4efe9cc7413690b909237a22cacc57c20d2ff2a2
>>>>>>> 9c63931c7a6d2538d2659df7840d608711421381
>>>>>>> e40a0e5acc80ad04a996495bf8b0b0446e916376
        public string? Desc { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? Address { get; set; }

<<<<<<< HEAD
        public ICollection<Employee> Employees { get; set; }

=======
<<<<<<< HEAD
        public ICollection<BloodCamp> BloodCamps { get; set; }
        public ICollection<Employee> Employees { get; set; }

=======
<<<<<<< HEAD
        //[ForeignKey("Area")]
        //public int AreaCode { get; set; }
        //public Area Area { get; set; }

        public ICollection<BloodCamp> BloodCamps { get; set; }
        public ICollection<Employee> Employees { get; set; }
=======
>>>>>>> 9c63931c7a6d2538d2659df7840d608711421381
>>>>>>> e40a0e5acc80ad04a996495bf8b0b0446e916376
        [ForeignKey("Area")]
        public int AreaCode { get; set; }
        public Area Area { get; set; }

        public ICollection<BloodCamp> BloodCamps { get; set; }
<<<<<<< HEAD
=======
        public ICollection<Emplopyee> Emplopyees { get; set; }
<<<<<<< HEAD
=======
>>>>>>> 4efe9cc7413690b909237a22cacc57c20d2ff2a2
>>>>>>> 9c63931c7a6d2538d2659df7840d608711421381
>>>>>>> e40a0e5acc80ad04a996495bf8b0b0446e916376
        public ICollection<Slot> Slots { get; set; }
    }
}
