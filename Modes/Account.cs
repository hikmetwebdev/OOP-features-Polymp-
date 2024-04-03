using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_abstraction_home.Modes
{
    public abstract class Account
    {
        public abstract string ? AccountNumber { get; }
        public abstract double Balance { get; set; }

        public abstract StringBuilder ShowAccountDetails(string accountNumber);

    }
}
