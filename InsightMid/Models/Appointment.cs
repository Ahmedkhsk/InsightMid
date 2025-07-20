namespace InsightMid.Models
{
    [Table("Appointment")]
    public class Appointment
    {
        public int Id { get; set; }
        public DateOnly date { get; set; }
        public TimeOnly time { get; set; }


    }
}
