namespace InsightMid.Models
{
    [Table("DoctorNote")]
    public class DoctorNote
    {
        public int Id { get; set; }
        public string NoteContent { get; set; } = default!;

    }
}
