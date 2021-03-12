using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_projekt1
{
    class OpenGymBooking : Booking
    {
        OpenGymBooking(int bookingID, DateTime time, int userID) : base(bookingID, time, userID)
        {

        }
    }
}
