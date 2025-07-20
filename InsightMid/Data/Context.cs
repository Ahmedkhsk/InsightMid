namespace InsightMid.Data
{
    public class Context : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<MedicalRayImage> MedicalRayImages { get; set; }
        public DbSet<DoctorNote> DoctorNotes { get; set; }
        public DbSet<PatientVisit> PatientVisits { get; set; }
        public Context(DbContextOptions<Context> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PatientVisit>()
                .HasOne(pv => pv.Doctor)
                .WithMany()
                .HasForeignKey(pv => pv.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PatientVisit>()
                .HasOne(pv => pv.Patient)
                .WithMany()
                .HasForeignKey(pv => pv.PatientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PatientVisit>()
                .HasOne(pv => pv.Appointment)
                .WithMany()
                .HasForeignKey(pv => pv.AppointmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PatientVisit>()
                .HasOne(pv => pv.MedicalRayImage)
                .WithMany()
                .HasForeignKey(pv => pv.MedicalRayImageId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PatientVisit>()
                .HasOne(pv => pv.DoctorNote)
                .WithMany()
                .HasForeignKey(pv => pv.DoctorNoteId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
