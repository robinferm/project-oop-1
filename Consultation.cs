using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_projekt1
{
    class Consultation : Booking
    {
        private PersonalTrainer _PT;
        Consultation(PersonalTrainer PT, int bookingID, DateTime time, Member member) : base(bookingID, time, member)
        {
            _PT = PT;
        }
    }
}
