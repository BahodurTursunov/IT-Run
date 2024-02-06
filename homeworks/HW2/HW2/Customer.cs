namespace HW2
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }

        public Customer(int customerId, string customerName, string phoneNumber, string adress, string city, string region, string postalCode, string country)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            PhoneNumber = phoneNumber;
            Address = adress;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
        }

    }
}
