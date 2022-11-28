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
        [Key]
        public int Code { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
>>>>>>> 4efe9cc7413690b909237a22cacc57c20d2ff2a2
        public string? Desc { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? Address { get; set; }

<<<<<<< HEAD
        //[ForeignKey("Area")]
        //public int AreaCode { get; set; }
        //public Area Area { get; set; }

        public ICollection<BloodCamp> BloodCamps { get; set; }
        public ICollection<Employee> Employees { get; set; }
=======
        [ForeignKey("Area")]
        public int AreaCode { get; set; }
        public Area Area { get; set; }

        public ICollection<BloodCamp> BloodCamps { get; set; }
        public ICollection<Emplopyee> Emplopyees { get; set; }
>>>>>>> 4efe9cc7413690b909237a22cacc57c20d2ff2a2
        public ICollection<Slot> Slots { get; set; }
    }
}
