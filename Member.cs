using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OOP_projekt1
{
    class Member : Person
    {
        public Member(int u, string fn, string ln, string pw, string pn)
        {
            UserID = u;
            FirstName = fn;
            LastName = ln;
            PassWord = pw;
            PhoneNumber = pn;
        }
        public bool EditBooking()//int bookingID, List<Booking> schedule
        {                        // fix input for methods

            return true;
        }
        public bool CancelBooking()//int bookingID, List<Booking> schedule
        {
            return true;
        }
        public bool ReserveBooking()//int bookingID, List<Booking> schedule
        {
            return true;
        }
    }
}
