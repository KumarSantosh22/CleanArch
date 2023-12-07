using Data.Entities.Contracts;

namespace Data.Entities
{
    public class Appuser : IAuditable<string>
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Name { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Roles { get; set; }
        public string? Claims { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public DateTime? UpdateOn { get; set; }
        public string? UpdateBy { get; set; }
        public bool IsActive { get; set; }
    }
}
