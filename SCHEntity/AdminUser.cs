using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHEntity
{
    [Table("AdminUser")]
    public class AdminUser : AbsEnitiy
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdminUserID { get; set; }

        [Required]
        [MaxLength(50)]
        [Index("IX_AdminName")]
        public string AdminName { get; set; }

        [Required]
        [MaxLength(40)]
        public string Role { get; set; }
        [Required]
        [MaxLength(15)]
        [Index("IX_UserName")]
        public string UserName { get; set; }
        [Required]
        [MaxLength(12)]
        public string Passeord { get; set; }

        [Required]
        [MaxLength(12)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(40)]
        public string MailID { get; set; }

        [ForeignKey("SchoolID")]
        [Index("IX_SchoolID")]
        public School School { set; get; }

        [Required]
        [Index("IX_SchoolID")]
        public int? SchoolID { get; set; }

    }
}
