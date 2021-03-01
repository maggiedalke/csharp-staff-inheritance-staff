using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_staff_inheritance
{
    class Admin : Staff
    {
        public double CalculateSalary()
        {
            return CalculateSalary() + base.CalculateSalary() * 0.1; 
        }        
    }
}
