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
        private double accountBalance = 1000000000;

       
        public Checking()
        {
            //Default Constrctor
        }
        public Checking(int accountNumber, double accountBalance)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
        }
    }
}
