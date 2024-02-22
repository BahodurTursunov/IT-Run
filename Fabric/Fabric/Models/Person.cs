namespace FabricSystem.Models
{
    public abstract class Person : BaseEntity
    {
        //protected Person(string firstName, string lastName, DateTimeOffset birthday)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Birthday = birthday;
        //}

        public string FirstName { get; set; }

        public string LastName { get; set; }

        //public string FullName
        //{
        //    get
        //    {
        //        return $"{FirstName}" + $" {LastName}";
        //    }
        //    set
        //    {

        //    }
        //}

        public DateTimeOffset Birthday { get; set; }
    }   
}
