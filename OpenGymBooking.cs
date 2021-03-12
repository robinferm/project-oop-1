using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_projekt1
{
    class OpenGymBooking : Booking
    {
        OpenGymBooking(int bookingID, DateTime time, string username) : base(bookingID, time, username)
        {

        }
    }
}
