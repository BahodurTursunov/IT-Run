namespace BankManagmentSys.Models
{
    public class Client : Worker
    {
        public ClientStatus State {  get; set; }
    }

    public enum ClientStatus
    {
        VIP,
        Standard,
        Blocked
    }
}
