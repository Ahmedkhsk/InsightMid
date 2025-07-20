namespace InsightMid.Models
{
    [Table("Doctor")]
    public class Doctor : ApplicationUser
    {
        public string specialty { get; set; } = default!;
    }
}
