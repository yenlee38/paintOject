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
    public class Ellipse : Shape
    {


        public override GraphicsPath graphicsPath { 
            get
            {
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
                return path;
            }
        }

        public override void draw(PaintEventArgs e)
        {
            using (GraphicsPath path = graphicsPath)
            {
                if (!this.isFill)
                    e.Graphics.DrawPath(myPen, path);
                else
                    e.Graphics.FillPath(myBrush, path);
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
