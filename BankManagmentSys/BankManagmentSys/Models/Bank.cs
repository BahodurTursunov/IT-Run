﻿namespace BankManagmentSys.Models
{
    public class Bank : BaseEntity
    {
        public Bank()
        {
            Branchs = new();
            Departments = new();
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public List<Branch> Branchs { get; set; }

        public List<Department> Departments{ get; set; }
    }
}
