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
    public class Square : Shape
    {
        public override GraphicsPath graphicsPath {

            get
            {
                GraphicsPath path = new GraphicsPath();
                float high = mathsOfShape.highOfSquare(p1, p2);
                if (p1.X < p2.X && p1.Y < p2.Y)
                {
                    path.AddRectangle(new System.Drawing.Rectangle(p1.X, p1.Y, (int)high, (int)high));
                    lPoint.Clear();
                    lPoint.Add(p1);
                }
                else if (p1.X > p2.X && p1.Y > p2.Y)
                {
                    path.AddRectangle(new System.Drawing.Rectangle(p2.X, p2.Y, (int)high, (int)high));
                    lPoint.Clear();
                    lPoint.Add(p2);
                }
                else if (p1.X < p2.X && p1.Y > p2.Y)
                {
                    path.AddRectangle(new System.Drawing.Rectangle(p1.X, p1.Y - (int)high, (int)high, (int)high));
                    lPoint.Clear();
                    lPoint.Add(new Point(p1.X, p1.Y - (int)high));
                }
                else if (p1.X > p2.X && p1.Y < p2.Y)
                {
                    path.AddRectangle(new System.Drawing.Rectangle(p1.X - (int)high, p1.Y, (int)high, (int)high));
                    lPoint.Clear();
                    lPoint.Add(new Point(p1.X - (int)high, p1.Y));
                }
                return path;
            }
        }
        public override void draw(PaintEventArgs e)
        {
            using (GraphicsPath path = graphicsPath)

            {
                if (!this.isFill)
                {
                    e.Graphics.DrawPath(myPen, path);

                }
                else

                {
                    e.Graphics.FillPath(myBrush, path);
                }
            }
        }


        public override bool isHit(Point location)
        {
            using (GraphicsPath path = graphicsPath)
            {
                if (!this.isFill)
                {
                    return path.IsOutlineVisible(location, myPen);
                }

                else
                    return path.IsVisible(location);
            }
            return false;

        }
    }
}
