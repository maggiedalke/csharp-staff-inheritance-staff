using System;

namespace csharp_staff_inheritance
{
    class Program
    {
        /*
         * Create a new class "Teacher" and "Admin", Both are from "Staff" class
         * In the Staff class, we have a function "GetInfo" that displays the Name, 
         * and joining date of a staff member.
         *  - All staff members have a "BaseSalary" property
         *  - "CalculateSalary" is a function to get the salary of a member,
         *      Admins only get the base salary,  + 10% of their base salary
         *      while Teachers get the base salary + the salary for teaching each hour in their courses. 
         */

        static void Main(string[] args)
        {
            Staff Mike = new Staff();
            Console.WriteLine(Mike.GetInfo()); 

        }
    }
}
