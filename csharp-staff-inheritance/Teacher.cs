using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_staff_inheritance
{
    class Teacher : Staff
    {
        public double HourlyWage { get; set; }

        public double CalculateSalary(int hours)
        {
            return base.CalculateSalary() + (HourlyWage * hours);
        }
    }
}
