using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumeratorAndIEnumerable
{
    class Ball
    {
        private Color color;
        private double radio;

        public Ball(Color color, double radio)
        {
            this.color = color;
            this.radio = radio;
        }

        public double CalculateVolume()
        {
            return (double)Decimal.Divide(4, 3) * Math.PI * Math.Pow(radio, 3);
        }

        public void Show()
        {
            Console.WriteLine($"{color} ball with a volume of {CalculateVolume()} m^3");
        }
    }
}
