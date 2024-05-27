using Model.Enum;

namespace Model.DataTransferObject
{
    public class UserBaseDTO
    {
        public required string UserName { get; set; }
        public required string Email { get; set; }
        public required string Phonenumber { get; set; }
        public required string DisplayName { get; set; }
        public GenderEnum Gender { get; set; }
        public string? Address { get; set; }
        public DateTime? Birthday { get; set; }
    }

    public class UserRegistationDTO : UserBaseDTO
    {
        public required string Password { get; set; }
    }
}