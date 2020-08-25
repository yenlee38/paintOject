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
    public abstract class Shape
    {
        public Point p1;
        public Point p2;

        public List<Shape> lGroup = new List<Shape>();
        public  Pen myPen { get; set; }
        public SolidBrush myBrush { get; set; }

        // cho biết hình đang được chọn hay không
        public bool isSelected { get; set; }

        // cho biết hình đang được vẽ Fill 
        public bool isFill { get; set; }   

        // Cho biết hình có đang zoom hay không
        public bool isZoom { get; set; }

        public abstract GraphicsPath graphicsPath { get; }

        public List<Point> lPoint = new List<Point>();     
        public abstract void draw(PaintEventArgs e);

        /// <summary>
        /// Xác định điểm thuộc một hình khi chuột rê tới 
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public abstract bool isHit(Point location);

        public bool isPointOfControl(Point location)
        {
            List<GraphicsPath> lPath = FindRegion.listPointControl(this);
            if (lPath != null)
            {
                for (int i = 0; i < lPath.Count; i++)
                {
                    if (lPath[i].IsVisible(location))
                        return true;
                }
            }
            return false;
        }

     

    }
}
