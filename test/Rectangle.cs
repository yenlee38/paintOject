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
    public class Rectangle: Shape
    {

        public override GraphicsPath graphicsPath { 

            get
            {
                GraphicsPath path = new GraphicsPath();

                
                if (p1.X < p2.X && p1.Y < p2.Y)
                    path.AddRectangle(new System.Drawing.Rectangle(p1.X, p1.Y, Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y)));
                else if (p1.X > p2.X && p1.Y > p2.Y)
                    path.AddRectangle(new System.Drawing.Rectangle(p2.X, p2.Y, Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y)));
                else if (p1.X < p2.X && p1.Y > p2.Y)
                    path.AddRectangle(new System.Drawing.Rectangle(p1.X, p2.Y, Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y)));
                else if (p1.X > p2.X && p1.Y < p2.Y)
                    path.AddRectangle(new System.Drawing.Rectangle(p2.X, p1.Y, Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y)));
                lPoint.Add(p1);
                lPoint.Add(p2);
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
           
        }

    }
}
