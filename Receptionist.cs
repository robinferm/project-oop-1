using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_projekt1
{
    class Receptionist : Person
    {
        public Receptionist(int u, string fn, string ln, string pw, string pn)
        {
            UserID = u;
            FirstName = fn;
            LastName = ln;
            PassWord = pw;
            PhoneNumber = pn;
        }
        public bool EditBookingForMember()//int userID, int bookingID, List<Booking> schedule
        {                                  // fix input for methods
            
            return true;
        }
        public bool CancelBookingForMember()//int userID, int bookingID, List<Booking> schedule
        {
            return true;
        }
        public bool ReserveBookingForMember()//int userID, int bookingID, List<Booking> schedule
        {
            return true;
        }
        public Member RegisterMember(string firstName, string lastName, string passWord, string phoneNumber)
        {
            Member newMember = new Member(01, firstName, lastName, passWord, phoneNumber);
            return newMember;
        }
    }
}
