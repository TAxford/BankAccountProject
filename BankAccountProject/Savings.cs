using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Savings : Account
    {
        private int accountNumber = 123456789;
        private double savingsBalance = 999999999999;

        //Properties
        public double SavingsBalance
        {
            get { return this.savingsBalance; } 
        }

        //Constructors
        public Savings()
        {
            //Default Constrctor
        }
        public Savings(int accountNumber, double savingsBalance)
        {
            this.accountNumber = accountNumber;
            this.savingsBalance = savingsBalance;
        }
        
    }
}
