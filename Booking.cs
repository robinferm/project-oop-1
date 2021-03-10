using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_projekt1
{
    abstract class Booking
    {
        private int _bookingID;
        public int BookingID
        {
            get { return _bookingID; }
            set { _bookingID = value; }
        }
        private DateTime _time;
        public DateTime Time
        {
            get { return _time; }
            set { _time = value; }
        }
        private Member _member;
        public Member Member
        {
            get { return _member; }
            set { _member = value; }
        }
        public Booking(int bookingID, DateTime time, Member member)
        {
            _bookingID = bookingID;
            _time = time;
            _member = member;

        }
    }
}
