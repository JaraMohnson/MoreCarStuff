using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndUsedCars
{
    internal class UsedCar : Car
    {
        //property 
        public double Mileage { get; set; }

        // Constructor 
        public UsedCar(string _make, string _model, int _year, decimal _price, double _mileage) :
            base(_make, _model, _year, _price)
        {
            Mileage = _mileage;
        }

        public UsedCar()
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0;
            Mileage = 0;
        }

        // tentative method.... 
        public override string ToString()
        {
            return base.ToString() + String.Format("{0,-7} {1,-8} {2,-14}", "(Used)", Mileage, "Miles");
        }

        public static void BuyBack(List<Car> list)
        {
            Console.WriteLine("Please provide the details about the car: ");
            UsedCar x = new UsedCar();

            Console.Write("Make: ");
            x.Make = Console.ReadLine();

            Console.Write("Model: ");
            x.Model = Console.ReadLine();

            Console.Write("Year: ");
            x.Year = int.Parse(Console.ReadLine());

            Console.Write("Price: ");
            x.Price = decimal.Parse(Console.ReadLine());

            Console.Write("Miles: ");
            x.Mileage = double.Parse(Console.ReadLine());


           list.Add(x);
        }
    }
}


//Console.WriteLine("Please enter the Make, Model, Year, Price, and Mileage, in order");
//UsedCar z = new UsedCar();

//z.Make = Console.ReadLine();
//z.Model = Console.ReadLine();
//z.Year = int.Parse(Console.ReadLine());
//z.Price = decimal.Parse(Console.ReadLine());
//z.Mileage = double.Parse(Console.ReadLine());


//CarList.Add(z);