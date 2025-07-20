using System.ComponentModel.DataAnnotations.Schema;

namespace InsightMid.Models
{
    [Table("PatientVisit")]
    public class PatientVisit
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Doctor))]
        public string DoctorId { get; set; } = string.Empty;
        public Doctor Doctor { get; set; } = default!;

        [ForeignKey(nameof(Patient))]
        public string PatientId { get; set; } = string.Empty;
        public Patient Patient { get; set; } = default!;

        [ForeignKey(nameof(MedicalRayImage))]
        public int MedicalRayImageId { get; set; }
        public MedicalRayImage MedicalRayImage { get; set; } = default!;

        [ForeignKey(nameof(DoctorNote))]
        public int DoctorNoteId { get; set; }
        public DoctorNote DoctorNote { get; set; } = default!;

        [ForeignKey(nameof(Appointment))]
        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; } = default!;
    }
}
