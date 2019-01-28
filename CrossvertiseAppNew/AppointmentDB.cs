namespace CrossvertiseAppNew
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AppointmentDB : DbContext
    {
        public AppointmentDB()
            : base("name=AppointmentDB")
        {
        }

        public virtual DbSet<AppDesc> AppDescs { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Month> Months { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                .HasMany(e => e.AppDescs)
                .WithRequired(e => e.Appointment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Month>()
                .Property(e => e.Month1)
                .IsFixedLength();

            modelBuilder.Entity<Month>()
                .HasMany(e => e.Appointments)
                .WithRequired(e => e.Month)
                .WillCascadeOnDelete(false);
        }
    }
}
