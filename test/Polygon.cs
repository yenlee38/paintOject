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
    public class Polygon : Shape
    {
        public override GraphicsPath graphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                if (lPoint.Count < 3)
                {
                    path.AddLine( lPoint[0], lPoint[1]);
                }

                else
                    path.AddPolygon(lPoint.ToArray());
                return path;
            }
        }
        public override void draw(PaintEventArgs e)
        {
            using (GraphicsPath path = graphicsPath)
            {
                if (!isFill)
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
