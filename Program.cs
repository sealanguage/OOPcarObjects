//  car object homework

using System;

namespace oopReviewHomework
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var Car1 = new Car"red", "Honda")
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
        public SaloonCar ()
        {

        }
        public string NumberOfSeats { get; set; }
    }
}




//  make 3 constructors
//  1 assign number of seats
//  2 assign number of seats and manufacturer
//  3 assign nuber of seats, manufacturer and color


    //  create SaloonCar with 2 seats
    //  create SaloonCar object with 3 seats manufacturer Nissan
    //  create SaloonCar object with 4 seats manufacturer Ford purple