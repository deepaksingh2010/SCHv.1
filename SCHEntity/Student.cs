using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHEntity
{
    [Table("Student")]
    public class Student : AbsEnitiy
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentID { get; set; }

        [Required]
        [MaxLength(20)]
        public string RollNumber { get; set; }
        [Required]
        [MaxLength(50)]
        [Index("IX_StudentName")]
        public string StudentName { get; set; }
        [Required]
        [MaxLength(50)]
        [Index("IX_FatherName")]
        public string FatherName { get; set; }
        [Required]
        [MaxLength(50)]
        [Index("IX_MotherName")]
        public string MotherName { get; set; }

        [ForeignKey("VehicleID")]
        public Vehicle Vehicle { set; get; }

        [Required]
        [Index("IX_VehicleID")]
        public int? VehicleID { get; set; }

        [ForeignKey("SchoolID")]
        public School School { set; get; }

        [Required]
        [Index("IX_SchoolID")]
        public int? SchoolID { get; set; }

        [Required]
        [MaxLength(200)]
        public string StudentAdress { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Required]
        [MaxLength(8)]
        [Index("IX_PinCode")]
        public string PinCode { get; set; }

        [Required]
        [MaxLength(12)]
        public string PhoneNumber { get; set; }

        [Required]
        public Decimal Latitude { get; set; }

        [Required]
        public Decimal Longitude { get; set; }
    }
}
