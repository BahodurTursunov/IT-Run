namespace BankManagmentSys.Models
{
    public class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public override string ToString() // этот метод идет с object
        {
            return $"Id: {Id} ({GetType().Name})";
        }
    }
}
