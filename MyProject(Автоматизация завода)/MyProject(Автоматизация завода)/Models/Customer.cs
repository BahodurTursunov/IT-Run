﻿namespace MyProject.Models
{
    public class Customer : Person
    {
        public CustomerStatus Status { get; set; }
    }

    public enum CustomerStatus
    {
        Organization,
        Persion
    }
}
