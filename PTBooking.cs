using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_projekt1
{
    class PTBooking : Booking
    {
        private PersonalTrainer _PT;
        public PTBooking(PersonalTrainer PT, int bookingID, DateTime time, Member member) : base(bookingID, time, member)
        {
            _PT = PT;
        }
    }
}
