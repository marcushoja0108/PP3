using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP3
{
    internal class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public string RegNr { get; }
        public int ProdDate { get; }
        public int Distance { get; }
        public Owner CurrentOwner { get; set; }
        public double Price { get; set; }

        public Car(string brand, string model, string regNr, int prodDate, int distance, Owner owner, double price)
        {
            Brand = brand;
            Model = model;
            RegNr = regNr;
            ProdDate = prodDate;
            Distance = distance;
            CurrentOwner = owner;
            Price = price;
        }
    }
}
