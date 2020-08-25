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
    public class GroupShape : Shape
    {

        

        public override GraphicsPath graphicsPath {
            get
            {
                GraphicsPath path = new GraphicsPath();
                path.AddRectangle(new System.Drawing.Rectangle(p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y));
                return path;
            }
        }


        public override void draw(PaintEventArgs e)
        {
           foreach(Shape shapeIsGruop in lGroup)
            {
                shapeIsGruop.draw(e);
            }
        }

        public override bool isHit(Point location)
        {
            using(GraphicsPath path = graphicsPath)
            {
                return path.IsVisible(location);
            }
        }
    }
}
