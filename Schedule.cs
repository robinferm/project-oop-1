using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_projekt1
{
    class Schedule
    {
        private string date;
        private DateTime time;
        private List<Booking> bookings = new List<Booking>();
        public List<Booking> Bookings
        {
            get;set;
        }
        public Schedule()
        {
            
        }
        //public Booking CreateBooking(DateTime time, int userID)
        //{            ---Fixa return value

        //}
        public void DisplayBooking()
        {

        }
    }
    
}
