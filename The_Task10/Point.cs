using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Task10
{
    class Point
    {
        public int data;
        public Point left, right;
        public Point()
        {
            data = 0;
            left = null;
            right = null;
        }
        public Point(int d)
        {
            data = d;
            left = null;
            right = null;
        }
        public override string ToString()
        {
            return data + " ";
        }

    }

}
