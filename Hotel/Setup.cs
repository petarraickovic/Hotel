using HotelProgam.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelProgram
{
    public class Setup
    {

        public static Hotel CreatingHotel(string numberOfRooms)
        {
            Hotel hotel;
            if (string.IsNullOrWhiteSpace(numberOfRooms))
            {
                hotel = new Hotel(3);
            }
            else
            {
                if (!Int32.TryParse(numberOfRooms, out int roomNumber))
                {
                    Console.WriteLine("You have entered invalid room number");
                    return null;
                }
                if (roomNumber < 1 || roomNumber > 1000)
                {
                    Console.WriteLine("You can't create a hotel with less than one room or with more than 1000 rooms");
                    return null;
                }
                hotel = new Hotel(roomNumber);
            }
            return hotel;
        }
    }
}
