using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OOP_projekt1
{
    class Member : Person
    {
        private List<Booking> _bookings;
        public Member(string u, string fn, string ln, string pw, string pn)
        {
            Username = u;
            FirstName = fn;
            LastName = ln;
            PassWord = pw;
            PhoneNumber = pn;
            _bookings = new List<Booking>();
        }
        public bool EditBooking()//int bookingID, List<Booking> schedule
        {                        // fix input for methods

            return true;
        }
        public bool CancelBooking()//int bookingID, List<Booking> schedule
        {
            return true;
        }
        public bool ReserveBooking(Booking booking, List<Booking> schedule)
        {
            // Add booking to member bookings
            _bookings.Add(booking);

            // Find booking object in schedule and add this member to the selected booking
            schedule.Find(x => x.BookingID == booking.BookingID).Username = this.Username;

            // Todo: only reserve if no other member has reseved the booking, or if the group/opengymbooking isn't full
            return true;
        }
    }
}
