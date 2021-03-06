﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_projekt1
{
    class GroupBooking : Booking
    {
        private PersonalTrainer _PT;
        private string _room;

        public GroupBooking(PersonalTrainer PT, string room, int bookingID, DateTime time, string username) : base(bookingID, time, username)
        {
            _PT = PT;
            _room = room;
        }
    }
}
