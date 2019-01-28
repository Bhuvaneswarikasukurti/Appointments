namespace CrossvertiseAppNew.Tests
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Appointment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Appointment()
        {
            AppDescs = new HashSet<AppDesc>();
        }

        [Key]
        public int AppId { get; set; }

        public int MonthId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public TimeSpan? Time { get; set; }

        [Column("Appointment")]
        [Required]
        [StringLength(50)]
        public string Appointment1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppDesc> AppDescs { get; set; }

        public virtual Month Month { get; set; }
    }
}
