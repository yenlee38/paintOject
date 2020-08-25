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
    public class Circle : Shape
    {
        
        public override GraphicsPath graphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                float centerX = (float)(p1.X + p2.X) / 2;
                float centerY = (float)(p1.Y + p2.Y) / 2;
                float radius = mathsOfShape.radiusOfCircle(p1, p2);
                path.AddEllipse(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
                lPoint.Clear();
                this.lPoint.Add(new Point((int)(centerX - radius), (int)(centerY - radius)));
                return path;
            }
        }

        
        public override void draw(PaintEventArgs e)
        {
            GraphicsPath path = graphicsPath;
            if (!this.isFill)
                e.Graphics.DrawPath(myPen, path);
            else
                e.Graphics.FillPath(myBrush, path);
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
