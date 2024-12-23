using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryUseCases
{
    internal class LineCheck
    {
        private double Len { get; }

        public LineCheck(double x1, double y1, double x2, double y2)
        {
            Len = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public int CompareTo(LineCheck l)
        {
            return Len.CompareTo(l.Len);//CompareTo method from double class will be called which is from Comparable Interface
        }
    }
}
