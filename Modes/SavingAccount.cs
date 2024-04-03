using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_abstraction_home.Modes
{
    public class SavingAccount : Account, IAccount
    {

        private double _balance;
        public override string? AccountNumber { get; }


        public SavingAccount()
        {
            AccountNumber = Guid.NewGuid().ToString();
        }
        public override double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value > 0)
                {
                    _balance = value;

                }
            }
        }

        public void CalculateInteres(double cost)
        {
            double mothRate = 0.05;

            _balance += Balance * mothRate;

            Console.WriteLine($"Savving account is :{_balance} azn");
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"Balance is: {_balance} azn");
            }
        }

        public override StringBuilder ShowAccountDetails(string accountNumber)
        {
            StringBuilder accountInfo = new StringBuilder();
            if (accountNumber == this.AccountNumber)
            {
                accountInfo.Append($"Account num: {accountNumber} Balance : {_balance} azn");
            }

            return accountInfo;
        }

        public void Withdraw(double cash)
        {
            double cashRate = cash *4/100;

            if (cash > 0 && cash <= _balance)
            {
                _balance -= cash+cashRate;
                
                Console.WriteLine($" {cashRate} interest was charged according to the payment Current balance is : {_balance} azn");
            }
        }
    }
}
