using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryUseCases
{
    internal class LineEqualityCheck
    {
        public double Len { get; }

        public LineEqualityCheck(double x1,double y1, double x2, double y2)
        {
            Len = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        public override bool Equals(object o)
        {
            if(o is LineEqualityCheck l)//Check if the class is instance of Object class
            {
                return Len == l.Len;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Len.GetHashCode();//HashCode from double class based will get generated
        }
    }
}
