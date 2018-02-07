using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Checking : Account
    {
        //fields
        private int accountNumber = 987654321;
        private double checkingBalance = 1000000000;

        //Properties
        public double CheckingBalance
        {
            get { return this.checkingBalance; }
        }
       
        public Checking()
        {
            //Default Constrctor
        }
        public Checking(int accountNumber, double checkingBalance)
        {
            this.accountNumber = accountNumber;
            this.checkingBalance = checkingBalance;
        }
    }
}
