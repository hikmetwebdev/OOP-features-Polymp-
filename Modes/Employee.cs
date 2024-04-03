using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_abstraction_home.Modes
{
    public abstract class Employee
    {
        public abstract int EmployeeId { get; set; }
        public abstract string Name { get; set; }
        public abstract double BasicSalary { get; set; }


        public abstract void CalculateSalary(double hours,double hourlyPrice);
    }
}
