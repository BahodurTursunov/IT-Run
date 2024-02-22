using System;

namespace FabricSystem.Models
{
    public class Customer : Person
    {
        public CustomerStatus Status { get; set; }

        //public Customer(string firstName, string lastName, DateTimeOffset birthday) : base(firstName, lastName, birthday)
        //{
        //    firstName = FirstName;
        //    lastName = LastName;
        //    birthday = Birthday;
        //    Console.WriteLine($"FirstName: {firstName}, LastName: {lastName}, Birthday: {birthday}");
        //}
    }

    public enum CustomerStatus
    {
        Organization = 0,
        IndividualPerson = 1
    }
}
