namespace InsightMid.DTO.AuthDTO
{
    public class registerModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = default!;
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = default!;

        [Required]
        [DataType(DataType.Password)]
        public string confirmPassword { get; set; } = default!;
    }
}
