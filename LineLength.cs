using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryUseCases
{
    internal class LineLength
    {
        //Co-ordinates for a Line (x1,y1) and (x2,y2)
        private double X1 { get;}
        private double X2 { get; }
        private double Y1 { get; }
        private double Y2 { get; }

        //Constructor for Setting coordinates
        public LineLength(double X1, double Y1, double X2, double Y2)
        {
            this.X1 = X1;
            this.Y1 = Y1;
            this.X2 = X2;
            this.Y2 = Y2;
        }

        public double FindLength()
        {
            return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));//Formula for length calculation
        }
    }
}
