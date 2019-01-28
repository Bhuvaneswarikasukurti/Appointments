namespace CrossvertiseAppNew.Tests
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppDesc")]
    public partial class AppDesc
    {
        public int Id { get; set; }

        public int AppId { get; set; }

        [Required]
        [StringLength(50)]
        public string Organizer { get; set; }

        [Required]
        public string Attendes { get; set; }

        public virtual Appointment Appointment { get; set; }
    }
}
