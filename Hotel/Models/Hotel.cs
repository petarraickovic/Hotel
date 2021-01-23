using System;
using System.Collections.Generic;
using System.Text;

namespace HotelProgam.Models
{
    public class Hotel
    {

        public List<Room> rooms { get; set; }


        public Hotel(int n)
        {
            rooms = new List<Room>();
            for(var i = 1; i<=n; i++)
            {
                Room newRoom = new Room
                {
                    roomNumber = i,
                    occupancies = new List<ReservationDates>()
                };
                rooms.Add(newRoom);
            }
        }
    }
}
