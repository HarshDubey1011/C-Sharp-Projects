using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Box
    {
        public double length { get; set; }
        public double width { get; set; }
        public double breadth { get; set; }


        public Box()
        :this(1,1,1){}
        public Box(double length, double width, double breadth)
        {
            this.length = length;
            this.width = width;
            this.breadth = breadth;
        }

        public static Box operator +(Box box1, Box box2)
        {
            Box box = new Box()
            {
                length = box1.length + box2.length,
                width = box1.width + box2.width,
                breadth = box1.breadth + box2.breadth
            };
            return box;
        }

        public static Box operator -(Box box1, Box box2) {
            Box box = new Box()
            {
                length = box1.length - box2.length,
                width = box1.width - box2.width,
                breadth = box1.breadth - box2.breadth
            };
            return box;
        }

        public static bool operator ==(Box box1, Box box2) { 
            if((box1.length == box2.length) &&(box1.width == box2.width) &&(box1.breadth == box2.breadth))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Box box1, Box box2)
        {
            if ((box1.length != box2.length) || (box1.width != box2.width) || (box1.breadth != box2.breadth))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return String.Format("Box with height : {0} Width: {1} AND Breadth : {2}", length,width,breadth);
        }

        public static explicit operator int(Box b)
        {
            return (int)(b.length + b.width + b.breadth) / 3;
        }

        public static implicit operator Box(int i)
        {
            return new Box(i, i, i);
        }


    }
}
