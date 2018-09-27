using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHEntity
{
    [Table("VehicleLocation")]
    public class VehicleLocation : AbsEnitiy
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VehicleLocationID { get; set; }

        [ForeignKey("VehicleID")]
        public Vehicle Vehicle { set; get; }

        [Required]
        [Index("IX_VehicleID")]
        public int? VehicleID { get; set; }

        [Required]
        public Decimal Latitude { get; set; }

        [Required]
        public Decimal Longitude { get; set; }

        [Required]
        public float Speed { get; set; }
    }
}
