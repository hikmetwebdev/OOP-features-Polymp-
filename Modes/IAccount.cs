using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_abstraction_home.Modes
{
    public interface IAccount
    {
        void Deposit(double amount);
        void Withdraw(double cash);
        void CalculateInteres(double cost);
    }
}
