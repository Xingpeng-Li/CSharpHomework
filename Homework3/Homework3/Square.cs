using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Square : Rectangle
    {
        public double side;
        public double Side
        {
            get => side;
        }
        public Square(double side) : base(side, side)
        {
            this.side = side;
        }
    }
}
