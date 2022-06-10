using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Refrigerator
    {
        public delegate void DefrostEvent(int grades);
        public delegate void LowReservesEvent(int kilos);

        private int kilos;
        private int grades;
        private DefrostEvent? defrostEvent;
        private LowReservesEvent? lowReservesEvent;

        public Refrigerator(int kilos, int grades)
        {
            this.kilos = kilos;
            this.grades = grades;
        }

        public int Kilos { get => kilos; }
        public int Grades { get => grades; } 

        public void SetDefrostEvent(DefrostEvent defrostEvent)
        {
            this.defrostEvent = defrostEvent;
        }

        public void SetLowReservesEvent(LowReservesEvent lowReservesEvent)
        {
            this.lowReservesEvent = lowReservesEvent;
        }

        public void Work(int kilos)
        {
            this.kilos -= kilos;
            grades++;

            Console.WriteLine("Kilos remaining: " + this.kilos);
            Console.WriteLine("Temperature: " + grades);

            if (this.kilos < 5)
            {
                lowReservesEvent(kilos);
            }

            if (grades > 0)
            {
                defrostEvent(grades);
            }
        }
    }
}
