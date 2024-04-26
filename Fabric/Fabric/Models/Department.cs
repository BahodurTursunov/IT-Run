namespace Fabric.Models
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int WorkersInDepartment { get; set; }
        //public List<Worker> Workers { get; set; }
    }
}
