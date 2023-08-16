using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    //Specify Specialized Points (Points Where Modification Needed)
    class Point<T,T2>
    {
        private T xAxis;
       private T2 yAxis;
        public Point(T xAxis,T2 yAxis)
        {
            this.xAxis = xAxis;
            this.yAxis = yAxis;
        }
        public T X { get { return xAxis; } set { xAxis = value; } }
        public T2 Y { get { return yAxis; } set { yAxis = value; } }
        public override string ToString()
        {
            return string.Format("[{0} , {1}]",xAxis,yAxis);
        }
    }
}
