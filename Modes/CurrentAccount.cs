using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_abstraction_home.Modes
{
    public class CurrentAccount : Account, IAccount
    {
        private double _balance;
        public override string? AccountNumber { get; }
        public double cashBackBalance { get; set; }

        public CurrentAccount()
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
            double cashRate = 0.05;
            if (cost > 0)
            {
                _balance -= cost;

                cashBackBalance += _balance * cashRate;

                Console.WriteLine($"{cost} azn was charged to the account");

                if (cashBackBalance >= 1)
                {
                    _balance += cashBackBalance;

                    Console.WriteLine($"{cashBackBalance} azn cashback was added to your balance");
                    Console.Write($"Balance :{_balance} azn");
                }
            }
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
                accountInfo.Append($"Account num: {accountNumber} Balance : {_balance} azn ");
            }

            return accountInfo;
        }

        public void Withdraw(double cash)
        {
            if (cash > 0 && cash <= _balance)
            {
                _balance -= cash;

                Console.WriteLine($"Current balance is : {_balance}  azn");
            }
        }
    }
}
