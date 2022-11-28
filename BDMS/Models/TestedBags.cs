using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BDMS.Models
{
    [PrimaryKey(nameof(BagId), nameof(DiseaseId))]
    public class TestedBags
    {
<<<<<<< HEAD
        public int Id { get; set; }
=======
>>>>>>> 4efe9cc7413690b909237a22cacc57c20d2ff2a2

        [ForeignKey("BloodBag")]
        public int BagId { get; set; }
        public BloodBag BloodBag { get; set; }

        [ForeignKey("Disease")]
        public int DiseaseId { get; set; }
        public Disease Disease { get; set; }

    }
}
