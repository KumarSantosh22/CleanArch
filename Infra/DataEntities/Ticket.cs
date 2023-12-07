using Data.Entities.Contracts;

namespace Data.Entities
{
    public class Ticket : IEntity<Guid>, IAuditable<string>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public DateTime? UpdateOn { get; set; }
        public string? UpdateBy { get; set; }
    }
}
