using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_abstraction_home.Modes
{
    public class FullTimeEmployee : Employee
    {
        public override int EmployeeId { get ; set ; }
        public override string Name { get ; set ; }
        public override double BasicSalary { get ; set ; }

         
        public FullTimeEmployee(int id,string name)
        {
            EmployeeId = id;
            Name = name;
        }

        public override void CalculateSalary(double hours,double hourlyPrice    )
        {
            BasicSalary = hours * hourlyPrice;
            Console.WriteLine($"Basic salary is : {BasicSalary}");
        }
    }
}
