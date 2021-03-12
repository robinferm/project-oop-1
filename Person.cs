using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_projekt1
{
    class Person
    {
        private string username;
        public string Username
        {
            get { return username; } 
            set { username = value; }
        }
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string passWord;
        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    public Person()
        {

        }
    }
}
