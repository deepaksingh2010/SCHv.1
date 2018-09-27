
namespace SCHEntity
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public abstract class AbsEnitiy
    {
        [Required]
        public DateTime TimeCreated { get; set; }

        [Required]
        public DateTime TimeUpdated { get; set; }
    }
}
