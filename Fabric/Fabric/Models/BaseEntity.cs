namespace Fabric.Models
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public BaseEntity() // здесь мы генерируем новый айдишник каждому клиенту
        {
            Id = Guid.NewGuid();
        }
        public override string ToString()
        {
            return $"Id: {Id} ({GetType().Name})";
        }
    }
}
