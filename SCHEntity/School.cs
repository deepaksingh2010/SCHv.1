using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHEntity
{
    [Table("School")]
    public class School : AbsEnitiy
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SchoolID { get; set; }

        [Required]
        [MaxLength(100)]
        [Index("IX_SchoolName")]
        public string SchoolName { get; set; }


        [Required]
        [MaxLength(200)]
        public string SchoolAdress { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Required]
        [MaxLength(8)]
        [Index("IX_PinCode")]
        public string PinCode { get; set; }

        [Required]
        public byte NumberOfBuses { get; set; }

        [Required]
        [MaxLength(12)]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(50)]
        public string EmailID { get; set; }

        public IList<AdminUser> AdminUsers { private set; get; }
    }
}
