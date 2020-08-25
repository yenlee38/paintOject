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
    public static class FindRegion
    {


        /// <summary>
        ///  thiết lập điểm đầu và điểm cuối của đường cong curve
        /// </summary>
        /// <param name="curve"></param>

        
        public static void setCurvePointFirstEnd(Curve curve)
        {
            int minX = int.MaxValue; int minY = int.MaxValue;
            int maxX = int.MinValue; int maxY = int.MinValue;
            curve.lPoint.ForEach(p =>
            {
                if (minX > p.X)
                    minX = p.X;

                if (minY > p.Y)
                    minY = p.Y;

                if (maxX < p.X)
                    maxX = p.X;

                if (maxY < p.Y)
                    maxY = p.Y;
            });
            curve.p1 = new Point(minX, minY);
            curve.p2 = new Point(maxX, maxY);
        }


        /// <summary>
        /// thiết lập điểm đầu điểm cuối của Polygon
        /// </summary>
        /// <param name="polygon"></param>
        public static void setPolygonPointFirstEnd(Polygon polygon)
        {
            int minX = int.MaxValue; int minY = int.MaxValue;
            int maxX = int.MinValue; int maxY = int.MinValue;
            polygon.lPoint.ForEach(p =>
            {
                if (minX > p.X)
                    minX = p.X;

                if (minY > p.Y)
                    minY = p.Y;

                if (maxX < p.X)
                    maxX = p.X;

                if (maxY < p.Y)
                    maxY = p.Y;
            });
            polygon.p1 = new Point(minX, minY);
            polygon.p2 = new Point(maxX, maxY);
        }

        public static void regionOfGroup(Shape shape)
        {

            int minX = int.MaxValue; int minY = int.MaxValue;
            int maxX = int.MinValue; int maxY = int.MinValue;

            shape.lGroup.ForEach(sh =>
            {

                if (sh is Polygon)
                    setPolygonPointFirstEnd(sh as Polygon);
                else if (sh is Curve)
                    setCurvePointFirstEnd(sh as Curve);


                if (sh is Circle || sh is Square)
                {
                    List<Point> points;
                    if (sh is Circle)
                        points = listPointControlOfCircle(sh);
                    else
                        points = listPointControlOfSquare(sh);
                    points.ForEach(p =>
                    {
                        if (minX > p.X)
                            minX = p.X;

                        if (minY > p.Y)
                            minY = p.Y;

                        if (maxX < p.X)
                            maxX = p.X;

                        if (maxY < p.Y)
                            maxY = p.Y;
                    });
                }

                else
                {           

                    if (minX > sh.p1.X)
                        minX = sh.p1.X;

                    if (minY > sh.p1.Y)
                        minY = sh.p1.Y;

                    if (maxX < sh.p1.X)
                        maxX = sh.p1.X;

                    if (maxY < sh.p1.Y)
                        maxY = sh.p1.Y;

                    if (minX > sh.p2.X)
                        minX = sh.p2.X;

                    if (minY > sh.p2.Y)
                        minY = sh.p2.Y;

                    if (maxX < sh.p2.X)
                        maxX = sh.p2.X;

                    if (maxY < sh.p2.Y)
                        maxY = sh.p2.Y;
                }

            });

            shape.p1 = new Point(minX, minY);
            shape.p2 = new Point(maxX, maxY);
        }

     
        public static GraphicsPath framOfCircle(Circle shape)
        {
            GraphicsPath path = new GraphicsPath();
            float centerX = (float)(shape.p1.X +shape.p2.X) / 2;
            float centerY = (float)(shape.p1.Y + shape.p2.Y) / 2;
            float radius = mathsOfShape.radiusOfCircle(shape.p1, shape.p2);
            path.AddRectangle(new System.Drawing.Rectangle((int)(centerX - radius), (int)(centerY - radius),(int)( 2 * radius),(int)( 2 * radius)));
            
            return path;
        }

        public static GraphicsPath framOfGroup(GroupShape shape)
        {
            regionOfGroup(shape);
            GraphicsPath path = new GraphicsPath();
            
            path.AddRectangle(new System.Drawing.Rectangle(shape.p1.X, shape.p1.Y, shape.p2.X - shape.p1.X, shape.p2.Y - shape.p1.Y));

            return path;
        }

        public static List<GraphicsPath> listPointControl(Shape shape)
        {
          

            if(shape is Circle)
            {
                return addListPathPointControl(listPointControlOfCircle(shape));
            }

            else if(shape is Rectangle)
            {
                return addListPathPointControl(listPointControlOfRectangle(shape));
            }

            else if(shape is Square)
            {
                return addListPathPointControl(listPointControlOfSquare(shape));
            }

            else if (shape is Line)
            {
                 return addListPathPointControl(listPointControlOfLine(shape));
            }

            else if (shape is Ellipse)
            {
                return addListPathPointControl(listPointControlOfRectangle(shape));
            }

            else if(shape is GroupShape)
            {
                return addListPathPointControl(listPointControlOfRectangle(shape));
            }

            else
            {
                return addListPathPointControl(listPointControlOfPolygonOrCurve(shape));
            }
        }

        
        public static void setMinMaxPoint(int maxX, int maxY, int minX, int minY, Point p)
        {
            if (minX > p.X)
                minX = p.X;

            if (minY > p.Y)
                minY = p.Y;

            if (maxX < p.X)
                maxX = p.X;

            if (maxY < p.Y)
                maxY = p.Y;
        }

        public static List<Point> listPointControlOfPolygonOrCurve(Shape shape)
        {
            List<Point> lPointControl = new List<Point>();
            lPointControl = shape.lPoint;
            return lPointControl;
        }

        public static List<Point> listPointControlOfLine(Shape shape)
        {
            List<Point> lPointControl = new List<Point>();
            Point p1 = shape.p1;
            Point p2 = shape.p2;
            lPointControl.Add(p1);
            lPointControl.Add(p2);
            return lPointControl;

        }

        public static List<Point> listPointControlOfSquare(Shape shape)
        {

                List<Point> lPointControl = new List<Point>();
                int high = (int)mathsOfShape.highOfSquare(shape.p1, shape.p2);

                if (shape.lPoint.Count < 1) // tránh trường hợp null
                return null;
                Point p = shape.lPoint[0];
                lPointControl.Add(p);
                lPointControl.Add(new Point(p.X, p.Y + high));
                lPointControl.Add(new Point(p.X + high, p.Y + high));
                lPointControl.Add(new Point(p.X + high, p.Y));
                return lPointControl;
            
        }

        public static List<Point> listPointControlOfRectangle(Shape shape)
        {
            List<Point> lPointControl = new List<Point>();
            Point p1 = shape.p1;
            Point p2 = shape.p2;
            lPointControl.Add(p1);
            lPointControl.Add(p2);
            lPointControl.Add(new Point(p1.X, p2.Y));
            lPointControl.Add(new Point(p2.X, p1.Y));
            return lPointControl;

        }


        public static List<Point> listPointControlOfCircle(Shape shape)
        {
            List<Point> lPointControl = new List<Point>();
            if (shape.lPoint.Count < 1) // tránh trường hợp null
                return null;
            Point p = shape.lPoint[0];
            lPointControl.Add(p);
            int radius = (int)(mathsOfShape.radiusOfCircle(shape.p1, shape.p2));
            lPointControl.Add(new Point(p.X + 2 * radius, p.Y));
            lPointControl.Add(new Point(p.X + 2 * radius, p.Y + 2 * radius));
            lPointControl.Add(new Point(p.X, p.Y + 2 * radius));
            return lPointControl;
        }

        public static void drawPointControl(Graphics gp, Brush brush, Shape shape)
        {
            List<GraphicsPath> lPath = listPointControl(shape);
            for (int i = 0; i < lPath.Count; i++)
                gp.FillPath(brush, lPath[i]);
        }

        public static List<GraphicsPath> addListPathPointControl(List<Point> points)
        {
            List<GraphicsPath> pathPointControl = new List<GraphicsPath>();
            for(int i = 0; i < points.Count; i++)
            {
                GraphicsPath path = new GraphicsPath();
                
                    path.AddEllipse(new System.Drawing.Rectangle(points[i].X - 4, points[i].Y - 4, 8, 8));
                    pathPointControl.Add(path);
               
            }

            return pathPointControl;
        }



      
    }
}
