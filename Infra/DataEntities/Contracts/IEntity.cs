namespace Data.Entities.Contracts
{
    internal interface IEntity<T>
    {
        public T Id { get; set; }
    }
}
