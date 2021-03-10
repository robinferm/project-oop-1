using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_projekt1
{
    class Booking
    {
        private int bookingID;
        public int BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }
        private DateTime time;
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
        private Member member;
        public Member Member
        {
            get { return member; }
            set { member = value; }
        }
        public Booking()
        {

        }
    }
}
