using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP3
{
    internal class Owner
    {
        public string Name { get; set; }
        public List<Car> Cars;
        public double Balance { get; set; }
        public bool IsDealer { get; set; }


        public Owner(string name, int balance, bool isDealer)
        {
            Name = name;
            Cars = new List<Car>();
            Balance = balance;
            IsDealer = isDealer;
        }

        public void BuyCar(string userInput, Owner buyer, Owner seller)
        {
            if (seller.Cars.Count == 0)
            {
                Console.WriteLine("Sorry, only Shady Auto Actions can scam.");
                return;
            }  
            Car selectedCar = seller.Cars.First(car => car.RegNr == userInput);
            double price = selectedCar.Price;
            if (seller.IsDealer == true)
            {
                price = price * 1.2;
            }

            if (selectedCar == null)
            {
                Console.WriteLine("Wrong car stoopid");
            }
            else if(selectedCar != null)
            {
                if (buyer.Balance >= price)
                {
                    seller.Cars.Remove(selectedCar);
                    seller.Balance += price;

                    buyer.Cars.Add(selectedCar);
                    buyer.Balance -= selectedCar.Price;
                    selectedCar.CurrentOwner = buyer;

                    Console.WriteLine($"{buyer.Name} bought {selectedCar.Brand} {selectedCar.Model} for {price} (After taxes))");
                    Console.WriteLine($"{buyer.Name} now has : {buyer.Balance}NOK");
                }
                else
                {
                    Console.WriteLine("You poor.");
                }
            }
        }

        public void ListCars()
        {
            if (Cars.Count == 0)
            {
                Console.WriteLine($"{Name} has no cars in the garage.");
                return;
            }
            //ChatGPT Formaterte listen for oss :D
            Console.WriteLine($"{Name}'s Cars:");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("{0,-15} {1,-15} {2,-10} {3,-10} {4,-10}", "Brand", "Model", "RegNr", "ProdDate", "Price");
            Console.WriteLine("-------------------------------------------------");

            foreach (Car car in Cars)
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-10} {3,-10} {4,-10:C}",
                    car.Brand,
                    car.Model,
                    car.RegNr,
                    car.ProdDate,
                    car.Price);
            }

            Console.WriteLine("-------------------------------------------------");
        }


        public void FilterCars(double priceRangeInput)
        {
            if (Cars.Count == 0)
            {
                Console.WriteLine($"{Name} has no cars in the garage.");
                return;
            }
            //ChatGPT Formaterte listen for oss :D 
            Console.WriteLine($"{Name}'s Cars:");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("{0,-15} {1,-15} {2,-10} {3,-10} {4,-10}", "Brand", "Model", "RegNr", "ProdDate", "Price");
            Console.WriteLine("-------------------------------------------------");

            foreach (Car filteredCar in Cars.Where(Car => Car.Price <= priceRangeInput))
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-10} {3,-10} {4,-10:C}",
                    filteredCar.Brand,
                    filteredCar.Model,
                    filteredCar.RegNr,
                    filteredCar.ProdDate,
                    filteredCar.Price);
            }

            Console.WriteLine("-------------------------------------------------");
        }




    }
}
