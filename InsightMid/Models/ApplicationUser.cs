namespace InsightMid.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? verificationCode { get; set; } = default!;
        public bool IsApprove { get; set; } = false;
        public string ImageUrl { get; set; } = string.Empty;
    }
}
