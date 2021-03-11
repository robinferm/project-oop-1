using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_projekt1
{
    class Admin : Person
    {
        public Admin(int u, string fn, string ln, string pw, string pn)
        {
            UserID = u;
            FirstName = fn;
            LastName = ln;
            PassWord = pw;
            PhoneNumber = pn;
        }
        //public Schedule CreateSchedule() ---Fixa return value
        //{
           
        //}
        public void EditSchedule()
        {

        }
        public void CreateReport()
        {

        }
    }
}
