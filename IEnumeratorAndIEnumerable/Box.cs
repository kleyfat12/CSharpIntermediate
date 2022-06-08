using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumeratorAndIEnumerable
{
    class Box
    {
        private Ball[] balls;
        private string name;

        public Box(string name)
        {
            this.name = name;
            balls = new Ball[4];

            balls[0] = new Ball(Color.WHITE, 1);
            balls[1] = new Ball(Color.BLUE, 2);
            balls[2] = new Ball(Color.BLACK, 3);
            balls[3] = new Ball(Color.RED, 4);
        }

        public IEnumerator GetEnumerator()
        {
            return balls.GetEnumerator();
        }
    }
}
