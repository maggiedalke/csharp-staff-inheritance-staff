using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_staff_inheritance
{
    class Staff
    {
        public string Name { get; set; }
        public DateTime DateOfEmployment; 
        public int StaffID { get; set; }
        public double BaseSalary { get; set; }

        public Staff()
        {
        }
        public Staff(string name, DateTime date)
        {
            this.Name = name;
            this.DateOfEmployment = date;
        }
        public string GetInfo()
        {
           return $"{Name} joined the MITT staff in {DateOfEmployment}";
        }
        public double CalculateSalary()
        {
            return BaseSalary;
        }
    }
}
