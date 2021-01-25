using HotelProgam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelProgram
{
    public class Reservations
    {
        public static bool CreatingReservations(Hotel hotel, string startDate, string endDate)
        {
            int startDay = CheckDate(startDate);
            if (startDay == -1)
            {
                return false;
            }

            int finalDay = CheckDate(endDate);
            if (finalDay == -1)
            {
                return false;
            }
            if (finalDay < startDay)
            {

                return false;
            }
            if (hotel.rooms.Exists(x => !x.occupancies.Where(y => y.to >= startDay && y.to <= finalDay).Any() && !x.occupancies.Where(y => y.from >= startDay && y.from <= finalDay).Any()
             && !x.occupancies.Where(y => y.from < startDay && y.to > finalDay).Any()))
            {
                var room = hotel.rooms.Where(x => !x.occupancies.Where(y => y.to >= startDay && y.to <= finalDay).Any()
                && !x.occupancies.Where(y => y.from >= startDay && y.from <= finalDay).Any() && !x.occupancies.Where(y => y.from < startDay && y.to > finalDay).Any()).FirstOrDefault();
                BookRoom(room, startDay, finalDay);
                return true;
            }
            else
            {
                return false;
            }

        }


        private static int CheckDate(string dayNumber)
        {
            if (!Int32.TryParse(dayNumber, out int Day))
            {
                Console.WriteLine("You have entered invalid number of days");
                return -1;
            }
            if (Day < 0 || Day > 365)
            {
                Console.WriteLine("You have entered invalid number of days");
                return -1;
            };
            return Day;
        }


        private static void BookRoom(Room room, int startDay, int finalDay)
        {
            room.occupancies.Add(new ReservationDates()
            {
                from = startDay,
                to = finalDay
            });
        }





    }
}
