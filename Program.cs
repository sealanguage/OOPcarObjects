//  car object homework

using System;

namespace oopReviewHomework
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var Car1 = new Car("silver", "Buick");
            var Car2 = new Car("Teal", "Tata");
            var SaloonCar1 = new SaloonCar("Orange", "VW", 4);
            Console.WriteLine("Car1 is " + Car1.color + " Made by " + Car1.manufacturer);
            Console.WriteLine("Car2 is " + Car2.color + " Made by " + Car2.manufacturer);
            Console.WriteLine("SaloonCar1 hass " + SaloonCar1.NumberOfSeat + SaloonCar1.color);
        }
    }

    public class Car
    {
        public Car (string color, string manufacturer)
        {
            this.color = color;
            this.manufacturer = manufacturer;
        }

        public string color { get; set; }
        public string manufacturer { get; set; }
    }

    public class SaloonCar : Car
    {
        public SaloonCar (string NumberOfSeats)
        {
            this.NumberOfSeats = NumberOfSeats;
        }
        public string NumberOfSeats { get; set; };
    }
}



//  create a car class
//  instantiate a Car1 object

//  make 3 constructors
//  1 assign number of seats
//  2 assign number of seats and manufacturer
//  3 assign nuber of seats, manufacturer and color


    //  create SaloonCar object with 2 seats
    //  create SaloonCar object with 3 seats manufacturer Nissan
    //  create SaloonCar object with 4 seats manufacturer Ford purple