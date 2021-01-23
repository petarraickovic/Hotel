using System;
using System.Collections.Generic;
using System.Text;

namespace HotelProgam.Models
{
    public class Room
    {
        public int roomNumber { get; set; }
        public List<ReservationDates> occupancies { get; set; }
    }
}
