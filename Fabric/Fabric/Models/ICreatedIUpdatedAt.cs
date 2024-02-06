namespace Fabric.Models
{
    public interface ICreatedIUpdatedAt
    {
        public DateTime CreatedAt { get; set; } // TODO: узнать как сделать реализацию этого момента с созданием и обновлением

        public DateTime UpdatedAt { get; set; }
    }
}
