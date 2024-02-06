namespace MyProject.Models
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }


     
        //public DateTime CreatedAt { get; set; } // TODO: узнать как сделать реализацию этого момента с созданием и обновлением

        //public DateTime UpdatedAt { get; set; }

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
