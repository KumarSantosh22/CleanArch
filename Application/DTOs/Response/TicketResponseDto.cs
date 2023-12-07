namespace DTOs.Response
{
    public class TicketResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public DateTime? UpdateOn { get; set; }
        public string? UpdateBy { get; set; }
    }
}
