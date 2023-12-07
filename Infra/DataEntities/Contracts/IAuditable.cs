namespace Data.Entities.Contracts
{
    public interface IAuditable<T>
    {
        public DateTime CreatedOn { get; set; }
        public T CreatedBy { get; set; }

        public DateTime? UpdateOn { get; set; }
        public T? UpdateBy { get; set; }
    }
}
