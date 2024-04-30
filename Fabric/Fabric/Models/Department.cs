namespace Fabric.Models
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Worker Worker { get; set; }
        public int WorkerId { get; set; }
        //public List<Worker> Workers { get; set; }
    }
}
