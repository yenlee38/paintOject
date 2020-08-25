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
    public class lPen : Shape
    {


        public override GraphicsPath graphicsPath {
        
            get
            {
                GraphicsPath path = new GraphicsPath();

                path.AddLine(p1, p2);
                return path;
            }
        }
        public lPen()
        {
            
        }

        public override void draw(PaintEventArgs e)
        {
            using(GraphicsPath path = graphicsPath)
            {
                e.Graphics.DrawPath(myPen, path);
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
