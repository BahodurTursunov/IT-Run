namespace MyProject.Models
{
    public interface ICreatedUpdatedAt
    {
        public DateTime CreatedAt { get; set; } // TODO: узнать как сделать реализацию этого момента с созданием и обновлением

        public DateTime UpdatedAt { get; set; }
    }
}
