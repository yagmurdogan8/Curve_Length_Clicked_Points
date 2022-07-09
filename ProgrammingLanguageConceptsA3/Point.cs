//author YD

using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingLanguageConceptsA3
{
    class Point
    {
        int x, y;
        double addedLength;


        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;

        }

        public int PointX
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int PointY
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public double Length
        {
            get
            {
                return addedLength;
            }

            set
            {
                addedLength = value;
            }
        }
        public static double operator -(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.PointX - p2.PointX, 2) +
                    Math.Pow(p1.PointY - p2.PointY, 2)); ;
        }
    }
}
