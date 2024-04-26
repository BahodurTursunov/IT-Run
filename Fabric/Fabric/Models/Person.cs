using System.Text.Json.Serialization;

namespace Fabric.Models
{
    public abstract class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Username { get; set; }
        public string Password { get; set; }
        public string RefreshToken { get; set; }
        public string Role { get; set; } // должность человека который работает в компании 
        public DateOnly Birthday { get; set; }
        [JsonIgnore]
        public bool IsBlocked { get;}
    }   
}
