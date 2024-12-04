using PP3;

Owner shadyAutoAuction = new Owner("Shady Auto Auction", 69699, true);
Owner innocentRandy = new Owner("Innocent Randy",500000, false);

shadyAutoAuction.Cars.Add(new Car("Volvo", "XE90", "NF47777", 2021, 60000, shadyAutoAuction, 903500));
shadyAutoAuction.Cars.Add(new Car("BMW", "IX1", "NF47776", 2022, 3500, shadyAutoAuction, 499990));
shadyAutoAuction.Cars.Add(new Car("Fiat", "Multipla", "LJ67746", 2012, 350004, shadyAutoAuction, 99990));
shadyAutoAuction.Cars.Add(new Car("Toyota", "Camry", "NF47775", 2020, 25000, shadyAutoAuction, 250000));
shadyAutoAuction.Cars.Add(new Car("Honda", "Civic", "NF47774", 2019, 15000, shadyAutoAuction, 220000));
shadyAutoAuction.Cars.Add(new Car("Audi", "A4", "NF47773", 2021, 30000, shadyAutoAuction, 450000));
shadyAutoAuction.Cars.Add(new Car("Ford", "Mustang", "NF47772", 2018, 12000, shadyAutoAuction, 550000));
shadyAutoAuction.Cars.Add(new Car("Chevrolet", "Malibu", "NF47771", 2022, 5000, shadyAutoAuction, 270000));
shadyAutoAuction.Cars.Add(new Car("Tesla", "Model 3", "NF47770", 2021, 20000, shadyAutoAuction, 650000));
shadyAutoAuction.Cars.Add(new Car("Nissan", "Altima", "NF47769", 2020, 18000, shadyAutoAuction, 240000));
shadyAutoAuction.Cars.Add(new Car("Mercedes-Benz", "C-Class", "NF47768", 2019, 22000, shadyAutoAuction, 520000));
shadyAutoAuction.Cars.Add(new Car("Subaru", "Outback", "NF47767", 2021, 30000, shadyAutoAuction, 350000));
shadyAutoAuction.Cars.Add(new Car("Kia", "Telluride", "NF47766", 2022, 10000, shadyAutoAuction, 400000));
shadyAutoAuction.Cars.Add(new Car("Hyundai", "Elantra", "NF47765", 2020, 20000, shadyAutoAuction, 210000));
shadyAutoAuction.Cars.Add(new Car("Volkswagen", "Jetta", "NF47764", 2019, 15000, shadyAutoAuction, 190000));
shadyAutoAuction.Cars.Add(new Car("Mazda", "CX-5", "NF47763", 2020, 25000, shadyAutoAuction, 300000));
shadyAutoAuction.Cars.Add(new Car("Porsche", "Cayenne", "NF47762", 2021, 5000, shadyAutoAuction, 850000));
shadyAutoAuction.Cars.Add(new Car("Jaguar", "F-Pace", "NF47761", 2022, 12000, shadyAutoAuction, 650000));
shadyAutoAuction.Cars.Add(new Car("Chrysler", "Pacifica", "NF47760", 2021, 15000, shadyAutoAuction, 320000));



while (true)
{
    var userInput = Console.ReadLine().ToUpper();
    switch (userInput)
    {
        case "HELP":
            HelpMenu();
            break;

        case "BALANCE":
            Console.WriteLine($"You have {innocentRandy.Balance}NOK");
            break;
        case "LIST":
            shadyAutoAuction.ListCars();
            break;

        case "FILTER":
            
            Console.Write("Select highest price : ");
            double priceRangeInput = Convert.ToDouble(Console.ReadLine());
            
            shadyAutoAuction.FilterCars(priceRangeInput);
            break;

        case "GARAGE":
            innocentRandy.ListCars();
            break;

        case "SELL":
            Console.Write("Selcect RegNr of car : ");
            var commandInput = Console.ReadLine().ToUpper();
            shadyAutoAuction.BuyCar(commandInput, shadyAutoAuction, innocentRandy);
            break;

        case "BUY":
            Console.Write("Selcect RegNr of car : "); 
            commandInput = Console.ReadLine().ToUpper();
            innocentRandy.BuyCar(commandInput, innocentRandy, shadyAutoAuction);
            break;

        case "DOSUMSHADY":
            innocentRandy.Balance += 100000;
            break;

        case "EXIT":
            Environment.Exit(0);
            break;

        case "CLEAR":
            Console.Clear();
            break;
    }
}

void HelpMenu()
{
    Console.WriteLine("Welcome to Shady Auto Auction");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("1. 'LIST' - View cars");
    Console.WriteLine("2. 'BALANCE' - Current Balance");
    Console.WriteLine("3. 'GARAGE' - See own garage");
    Console.WriteLine("4. 'BUY' - Select car to buy");
    Console.WriteLine("5. 'SELL' - Select car to sell");
    Console.WriteLine("6. 'FILTER' - Filter cars by price");
    Console.WriteLine("7. 'DOSUMSHADY' - Add 100,000 to balance");
    Console.WriteLine("8. 'EXIT' - Exit the application");
    Console.WriteLine("9. 'CLEAR' - Clear the console");
}