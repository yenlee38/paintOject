using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public static class mathsOfShape
    {
        public static float radiusOfCircle(Point p1, Point p2) // xac dinh do dai can them vao toa do trong lớp circle
        {
            float d;
            int s = Math.Abs(p2.X - p1.X) + Math.Abs(p2.Y - p1.Y);
            d = (float)s / 2;


            float r = (float)Math.Sqrt(2) * d / 2;
            return r;
        }

        public static float highOfSquare(Point p1, Point p2)
        {
            float h;
            h = (float)(Math.Abs(p2.X  - p1.X )+ Math.Abs(p2.Y - p1.Y)) / 2;
            //h = (float)Math.Abs((p2.X - p1.X) + (p2.Y - p1.Y)) / 2;
            return Math.Abs(h);
            
         // xác định vị trí đang chọn là shape
        }

        public static bool isThis(Shape shape, Point e)
        {
            
            if(shape is Polygon || shape is Curve)
            {
                //FindRegion.setPolygonPointFirstEnd(shape as Polygon);
                for (int i = 0; i < shape.lPoint.Count; i++)
                    if (e == shape.lPoint[i])
                        return true;
               
            }

            if (shape is Curve)
            {
                //FindRegion.setCurvePointFirstEnd(shape as Curve);
                for (int i = 0; i < shape.lPoint.Count; i++)
                    if (e == shape.lPoint[i])
                        return true;


            }


            if (e.X >= shape.p1.X && e.X <= shape.p2.X && e.Y >= shape.p1.Y && e.Y <= shape.p2.Y)
                return true;

            
                return false;
        }

        public static void swap(float x, float y )
        {
            float t = x;
            x = y;
            y = t;

        }

        public static void swap(Point x, Point y)
        {
            Point t = x;
            x = y;
            y = t;
        }
        public static void changePoint(Shape shape)
        {
          
            if (shape.p2.X < shape.p1.X || shape.p2.Y < shape.p1.Y)
            {
                int x, y;
                swap(shape.p1, shape.p2);
            }

        }

        public static double distancePoint(Point p1, Point p2)
        {
            double d;
            d = Math.Sqrt(Math.Pow((p1.X  - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
            return d;
        }

       
        //public static List<Point> 

    }
}
