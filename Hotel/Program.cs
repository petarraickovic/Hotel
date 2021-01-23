using System;
using System.Linq;
using HotelProgam.Models;
using HotelProgram;

namespace HotelProgam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Create a hotel by entering the number of rooms, if you don't enter it a hotel with 3 rooms will be created: ");
            string nmbrRooms = Console.ReadLine();
            Hotel hotel = Setup.CreatingHotel(nmbrRooms);
            if(hotel == null)
            {
                return;
            }
            Console.WriteLine("Hotel with " + hotel.rooms.Count + " rooms is created");
            while (true)
            {
                Console.WriteLine("Please enter the starting day of the reservation (press 'Enter' if you want to finish the program): ");
                string startDate = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(startDate))
                {
                    return;
                }
                Console.WriteLine("Please enter the final day of the reservation: ");
                string endDate = Console.ReadLine();
                bool res = Reservations.CreatingReservations(hotel, startDate, endDate);
                if (res)
                {
                    Console.WriteLine("Accepted reservation");
                }
                else
                {
                    Console.WriteLine("Declined reservation");
                }
            }
        }






    }
}
