using System.ComponentModel.DataAnnotations;

namespace BDMS.Models
{
    public class Area
    {
<<<<<<< HEAD
        public int Id { get; set; }
=======
<<<<<<< HEAD
        public int Id { get; set; }
=======
        [Key]
        public int Code { get; set; }
>>>>>>> 4efe9cc7413690b909237a22cacc57c20d2ff2a2
>>>>>>> 9c63931c7a6d2538d2659df7840d608711421381
        [Required] 
        public string? Name { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public string? Province { get; set; }

<<<<<<< HEAD

        public ICollection<BloodCamp> BloodCamps { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Organization> Organizations { get; set; }
        public ICollection<BloodCamp> BloodCamps { get; set; }
=======
<<<<<<< HEAD
        //public ICollection<Organization> Organizations { get; set; }
        public ICollection<BloodCamp> BloodCamps { get; set; }
        public ICollection<Employee> Employees { get; set; }
=======
        public ICollection<Organization> Organizations { get; set; }
        public ICollection<BloodCamp> BloodCamps { get; set; }
        public ICollection<Emplopyee> Emplopyees { get; set; }
>>>>>>> 4efe9cc7413690b909237a22cacc57c20d2ff2a2
>>>>>>> 9c63931c7a6d2538d2659df7840d608711421381
        public ICollection<Donor> Donors { get; set; }
        public ICollection<Slot> Slots { get; set; }

    }
}
