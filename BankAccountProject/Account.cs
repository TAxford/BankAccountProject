using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Account
    {
        //fields
        private bool accountNumber;
        private double accountBalance;

        //Properties
        public bool AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        public double AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }

        //Constructors
        public Account()
        {
            //Default Constrctor
        }
        public Account(bool accountNumber, double accountBalance)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
        }




    }
}
