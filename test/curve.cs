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
    public class Curve : Shape
    {

        public override GraphicsPath graphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                if (this.lPoint.Count >= 3)
                    path.AddCurve(lPoint.ToArray());
                else
                    path.AddLine(lPoint[0], lPoint[1]);
                return path;
            }
        }

        public override void draw(PaintEventArgs e)
        {
            using(GraphicsPath path = graphicsPath)
                e.Graphics.DrawPath(myPen, path);


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
