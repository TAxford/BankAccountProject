using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Client
    {
        //fields
        private string firstName;
        private string lastName;
        private string favoriteColor;

        //Properties
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string FavoriteColor
        {
            get { return this.favoriteColor; }
            set { this.favoriteColor = value; }
        }

        //Constructors
        public Client()
        {
            //default constructor
        }

        public Client(string firstName, string lastName, string favoriteColor )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColor = favoriteColor;
            
        }

        

    }
}