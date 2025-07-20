namespace InsightMid.Models
{
    [Table("Patient")]
    public class Patient : ApplicationUser
    {
        public string medicalConditions { get; set; } = default!;
    }
}
