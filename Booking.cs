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
        private string _username;
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public Booking(int bookingID, DateTime time, string username)
        {
            _bookingID = bookingID;
            _time = time;
            _username = username;

        }
    }
}
