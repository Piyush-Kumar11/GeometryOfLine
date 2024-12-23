using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryUseCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LineLength l = new LineLength(2, 0, 5, 1);
            //Console.WriteLine("Length of Line: "+l.FindLength());

            //LineEqualityCheck line1 = new LineEqualityCheck(2, 3, 5, 1);
            //LineEqualityCheck line2 = new LineEqualityCheck(2, 3, 5, 1);
            //Console.WriteLine(line1.Equals(line2));

            LineCheck l1 = new LineCheck(2, 3, 5, 1);
            LineCheck l2 = new LineCheck(2, 3, 5, 1);
            int CheckLine = l1.CompareTo(l2);
            if (CheckLine > 0)
            {
                Console.WriteLine("Line 1st is Greater then Line 2");
            }
            else if (CheckLine < 0)
            {
                Console.WriteLine("Line 1st is Smaller then Line 2");
            }
            else
            {
                Console.WriteLine("Line 1st is Equal to Line 2");

            }


        }
    }
}
