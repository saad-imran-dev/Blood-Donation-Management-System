using BDMS.Models;
using Microsoft.EntityFrameworkCore;

namespace BDMS.Data
{
    public class ApplicationDbContext : DbContext 
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Area> Areas { get; set; }
        public DbSet<BloodBag> BloodBags { get; set; }
        public DbSet<BloodCamp> BloodCamps { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Donor> Donors { get; set; }
<<<<<<< HEAD
        public DbSet<Employee> Employees { get; set; }
=======
<<<<<<< HEAD
        public DbSet<Employee> Employees { get; set; }
=======
<<<<<<< HEAD
        public DbSet<Employee> Employees { get; set; }
=======
        public DbSet<Emplopyee> Emplopyees { get; set; }
>>>>>>> 4efe9cc7413690b909237a22cacc57c20d2ff2a2
>>>>>>> 9c63931c7a6d2538d2659df7840d608711421381
>>>>>>> e40a0e5acc80ad04a996495bf8b0b0446e916376
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<TestedBags> TestedBags { get; set; }

    }
}
