using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHEntity
{
    [Table("Vehicle")]
    public class Vehicle : AbsEnitiy
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VehicleID { get; set; }

        [Required]
        [MaxLength(20)]
        [Index("IX_VehicleNumber")]
        public string VehicleNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string DriverName { get; set; }

        [Required]
        [MaxLength(12)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(12)]
        public string VehicleType { get; set; }

        [Required]
        [MaxLength(256)]
        public string Picture { get; set; }


        [ForeignKey("SchoolID")]
        [Index("IX_SchoolID")]
        public School School { set; get; }

        public int? SchoolID { get; set; }
    }
}
