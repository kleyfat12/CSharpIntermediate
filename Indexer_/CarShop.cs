using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_
{
    class CarShop
    {
        private Car[] cars;

        public CarShop()
        {
            cars = new Car[4];

            cars[0] = new Car("Lambo", "Veneno");
            cars[1] = new Car("Bugatti", "Chiron");
            cars[2] = new Car("Bugatti", "Veyron");
            cars[3] = new Car("Koenigsegg", "Jesko");
        }

        public int Length { get => cars.Length; }

        // Indexer
        public Car this[int index]
        {
            get { return cars[index]; }
            set { cars[index] = value; }
        }
    }
}
