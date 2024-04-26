namespace Fabric.Models
{
    public class Customer : Person
    {
        public CustomerStatus Status { get; set; }
        //public List<Order> Orders { get; set; }
    }
    public enum CustomerStatus
    {
        Organization = 0,
        IndividualPerson = 1
    }
}
