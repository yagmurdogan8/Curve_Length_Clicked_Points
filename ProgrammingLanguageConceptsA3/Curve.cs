//author YD

using System;
using System.Collections.Generic;
using System.Text;


namespace ProgrammingLanguageConceptsA3
{
    class Curve : ICloneable
    {
        public List<Point> pointList = new List<Point>();

        public object Clone() //Deep Copy
        {
            Curve copied = new Curve();

            foreach (Point p in pointList)
            {
                Point newPoint = new Point(p.PointX, p.PointY);

                copied.AddPoint(newPoint);
            }

            return copied;
        }

        public Curve ShallowCopy()
        {
            return (Curve)MemberwiseClone();
        }
        public void PrintPoints()
        {
            for (int i = 0; i < pointList.Count; i++)
            {
                Console.WriteLine("Points have printed for point " + (i + 1) + " (x, y) : "
                    + pointList[i].PointX + " " + pointList[i].PointY);
            }
        }

        public void AddPoint(Point pointAdd)
        {
            //checking whether the list is empty or not
            if (pointList.Count == 0)
            {
                pointAdd.Length = 0;
            }

            else
            {
                Point lastPoint = pointList[pointList.Count -1];
                pointAdd.Length = Math.Sqrt(Math.Pow(lastPoint.PointX - pointAdd.PointX, 2) +
                    Math.Pow(lastPoint.PointY - pointAdd.PointY, 2));
            }

            pointList.Add(pointAdd);

        }

        public void AddPoint(int x, int y)
        {
            Point pointX = new Point(x, y);
            AddPoint(pointX);

        }

        public void RemovePoint(Point pointRemove)
        {

            if (pointList[0].PointX == pointRemove.PointX && pointList[0].PointY == pointRemove.PointY)
            {
                pointList[0].Length = 0;
            }

            else
            {
                if (pointList[pointList.Count -1] != pointRemove)
                    pointList[pointList.IndexOf(pointRemove) + 1].Length += pointRemove.Length;
            }

            for(int p = 0; p < pointList.Count; p++)
            {
                if(pointList[p].PointX == pointRemove.PointX && pointList[p].PointY == pointRemove.PointY) {
                    pointList.Remove(pointList[p]);
                }
            }
        }

        public void RemovePoint(int x1, int y1) 
        {
            Point pointX2 = new Point(x1, y1);
            RemovePoint(pointX2);
        }

        public double CurveLength()
        {
            double sum = 0;

            foreach (Point p in pointList)
            {
                sum += p.Length;
            }

            return sum;
        }
        public static Boolean operator <(Curve c1, Curve c2)
        {
            return c1.CurveLength() < c2.CurveLength();
        }
        public static Boolean operator >(Curve c1, Curve c2)
        {
            return c1.CurveLength() > c2.CurveLength();
        }
    }
}
