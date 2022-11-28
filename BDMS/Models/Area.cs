using System.ComponentModel.DataAnnotations;

namespace BDMS.Models
{
    public class Area
    {
<<<<<<< HEAD
        public int Id { get; set; }
=======
        [Key]
        public int Code { get; set; }
>>>>>>> 4efe9cc7413690b909237a22cacc57c20d2ff2a2
        [Required] 
        public string? Name { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public string? Province { get; set; }

<<<<<<< HEAD
        //public ICollection<Organization> Organizations { get; set; }
        public ICollection<BloodCamp> BloodCamps { get; set; }
        public ICollection<Employee> Employees { get; set; }
=======
        public ICollection<Organization> Organizations { get; set; }
        public ICollection<BloodCamp> BloodCamps { get; set; }
        public ICollection<Emplopyee> Emplopyees { get; set; }
>>>>>>> 4efe9cc7413690b909237a22cacc57c20d2ff2a2
        public ICollection<Donor> Donors { get; set; }
        public ICollection<Slot> Slots { get; set; }

    }
}
