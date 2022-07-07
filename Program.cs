using CarsAndUsedCars;
int choice = -1; // will be used later 
bool selling = false; 


// List 
List<Car> CarList = new List<Car>()
{
new UsedCar("Ford", "Explorer", 2020, 80000m, 36000),
new UsedCar("Chevy", "Sonic", 2015, 15000m, 68900),
new UsedCar("Dodge", "Durango", 2018, 17800m, 150000),
new Car("Tesla", "Model X", 2022, 250000m),
new Car("Jeep", "Wrangler", 2023, 79000m),
new Car("Ford", "Bronco Sport", 2023, 68000m),
};


Console.WriteLine("Welcome to Detroit Rides!");
selling = UsedCar.CustomerSelling();

if (selling) 
{
    UsedCar.BuyBack(CarList);
    Console.WriteLine("Thank you for selling! \n");
}


// list out full list of cars 
Console.WriteLine("Here is what we currently have available for purchase: \n");
Car.ListCars(CarList);
Console.WriteLine(" ");



while (true)
{
    Console.Write($"Which number car (1-{CarList.Count}) would you like? \n");
    try
    {
        choice = int.Parse(Console.ReadLine());
        if (choice < 1 || choice > CarList.Count)
        {
            throw new Exception("Please pick a valid number. \n");
        }
        else
        {
            break; // so we can exit this loop and move on 
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine("Error, that is not a number. \n");

    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}


Console.WriteLine($"You've chosen: {CarList[choice - 1].ToString()}");


Console.WriteLine("Thank you! Our finance department will call you this afternoon.\n");

Car.Remove((choice - 1), CarList);

Console.WriteLine("Here is the remaining list of cars available: \n");

// displaying the updated list of cars 
Car.ListCars(CarList);

Console.WriteLine("Have a great day!");
