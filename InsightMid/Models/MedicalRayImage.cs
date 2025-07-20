namespace InsightMid.Models
{
    [Table("MedicalRayImage")]
    public class MedicalRayImage
    {
        public int Id { get; set; }
        public string imageName { get; set; } = default!;
        public string aiSummary { get; set; } = default!;
        public decimal confidenceLevel { get; set; }

    }
}
