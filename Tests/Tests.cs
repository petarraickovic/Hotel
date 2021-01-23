using HotelProgam.Models;
using HotelProgram;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Tests
{
    
    public class Tests1
    {
        private Hotel hotel =  new Hotel(1);
        

        [TestCase( "-4", "2")]
        [TestCase("200", "400")]
        public void Test1( string startDay, string endDay)
        {
            bool res = Reservations.CreatingReservations(hotel, startDay, endDay);
            Assert.IsFalse(res);
        }
    }




    
    public class Tests2
    {
        private Hotel hotel = new Hotel(3);
        
        [TestCase( "0", "5")]
        [TestCase("7", "13")]
        [TestCase("3", "9")]
        [TestCase("5", "7")]
        [TestCase("6", "6")]
        [TestCase("0", "4")]
        public void Test2(string startDay, string endDay)
        {
            bool res = Reservations.CreatingReservations(hotel, startDay, endDay);
            Assert.IsTrue(res);
        }
    }

    public class Tests3
    {
        private Hotel hotel = new Hotel(3);
        [TestCase("1", "3", true)]
        [TestCase("2", "5", true)]
        [TestCase("1", "9", true)]
        [TestCase("0", "15", false)]
         public void Test3(string startDay, string endDay, bool expectedRes)
        {

            bool res = Reservations.CreatingReservations(hotel, startDay, endDay);
            Assert.AreEqual(expectedRes,res);
        }
    
    }

    public class Tests4
    {
        private Hotel hotel = new Hotel(3);
       
        [TestCase("1", "3", true)]
        [TestCase("0", "15", true)]
        [TestCase("1", "9", true)]
        [TestCase("2", "5", false)]
        [TestCase("4", "9", true)]
        public void Test4(string startDay, string endDay, bool expectedRes)
        {
            bool res = Reservations.CreatingReservations(hotel, startDay, endDay);
            Assert.AreEqual(expectedRes,res);
        }
    }


    public class Tests5
    {
        private Hotel hotel = new Hotel(2);
      

        [TestCase("1", "3", true)]
        [TestCase("0", "4", true)]
        [TestCase("2", "3", false)]
        [TestCase("5", "5", true)]
        [TestCase("4", "10", false)]
        [TestCase("10", "10", true)]
        [TestCase("6", "7", true)]
        [TestCase("8", "10", true)]
        [TestCase("8", "9", true)]
        public void Test5(string startDay, string endDay, bool expectedRes)
        {
            bool res = Reservations.CreatingReservations(hotel, startDay, endDay);
            Assert.AreEqual(expectedRes,res);
        }
    }
}