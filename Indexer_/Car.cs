using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_
{
    class Car
    {
        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public string Brand { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return $"Brand: {Brand}, Model: {Model}";
        }
    }
}
