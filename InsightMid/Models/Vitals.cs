namespace InsightMid.Models
{
    [Table("Vitals")]
    public class Vitals
    {
        public int Id { get; set; }
        public decimal temperature { get; set; }
        public int systolicBp { get; set; }
        public int diastolicBp { get; set; }
        public int heartRate { get; set; }

    }
}
