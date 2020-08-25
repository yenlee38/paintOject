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
    public class Line : Shape
    {

        public override GraphicsPath graphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                path.AddLine(p1, p2);
                return path;
            }
        }
        public override void draw(PaintEventArgs e)
        {
            using (GraphicsPath path = graphicsPath)
                e.Graphics.DrawPath(this.myPen,path);
        }

        public override bool isHit(Point location)
        {
            using (GraphicsPath path = graphicsPath)
            {
               
                    return path.IsOutlineVisible(location, myPen);
               
            }
            return false;
        }


    }
}
