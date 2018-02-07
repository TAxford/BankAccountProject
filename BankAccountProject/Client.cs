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
        private int age;

        //Properties
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LAstName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        //Constructors
        public Client()
        {
            //default constructor
        }

        public Client(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        //Methods
        public abstract void Information()
        {
            Console.WriteLine("Please Eneter your first name.");
            Console.ReadLine();
            Console.WriteLine("Please Eneter your last name.");
            Console.ReadLine();
            Console.WriteLine("Please eneter your age.");
            Console.ReadLine();
        }


    }
}