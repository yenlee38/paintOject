using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {

        public Graphics gp;
        Pen myPen;
        int width;
        Color myColor;
        IsShape isShape = IsShape.Non;
        bool Fill = false;
        bool pressControl = false;
        int indexShapeSelected = -1;
        Point pFirst;
        Point pLast;
        int pastDistanceX = 0;
        int pastDistanceY = 0;

        /// <summary>
        /// Pen của khung khi chọn hình - isSelecdted
        /// </summary>
        Pen framPen = new Pen(Color.Blue, 1);

        /// <summary>
        /// Brush của khung khi chọn hình - isSelecdted
        /// </summary>
        Brush framBrush;
        List<Shape> lShape = new List<Shape>();

        public Form1()
        {
            InitializeComponent();
            gp = this.plMain.CreateGraphics();
            myColor = Color.Black;
            width = 1;
            myPen = new Pen(Color.Black, 5);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.plMain.SetDoubleBuffered();


            this.Cursor = Cursors.Default;
            this.plMain.Cursor = Cursors.Cross;
            this.cmbFill.Text = "No Fill";
            this.cmbStytePen.Text = "Solid";
            this.framPen.DashStyle = DashStyle.DashDot;
            this.framBrush = new SolidBrush(Color.Teal);
        }


        private void plMain_Paint(object sender, PaintEventArgs e)
        {


            if (statusPaint.isStart == true)
            {
                lShape.ForEach(shape =>
                {

                    using (GraphicsPath path = shape.graphicsPath)

                    {
                        shape.draw(e);
                        if (shape.isSelected == true)
                        {
                            if (shape is Ellipse)
                            {

                                e.Graphics.DrawRectangle(framPen, shape.p1.X, shape.p1.Y, Math.Abs(shape.p2.X - shape.p1.X), Math.Abs(shape.p2.Y - shape.p1.Y));
                                //FindRegion.drawPointControl(e.Graphics, framBrush, shape);
                            }
                            else if (shape is Circle)
                            {
                                e.Graphics.DrawPath(framPen, FindRegion.framOfCircle(shape as Circle));

                            }

                            else if (shape is Curve || shape is Polygon)
                            {
                                for (int i = 0; i < shape.lPoint.Count; i++)
                                    e.Graphics.FillEllipse(framBrush, shape.lPoint[i].X - 3, shape.lPoint[i].Y - 3, 8, 8);
                            }

                            else if (shape is lPen)
                            {
                                // Không thực hiện chọn
                            }

                            else if (shape is GroupShape)
                            {
                                using (GraphicsPath pathG = shape.graphicsPath)
                                {
                                    e.Graphics.DrawPath(framPen, FindRegion.framOfGroup(shape as GroupShape));
                                }


                            }

                            FindRegion.drawPointControl(e.Graphics, framBrush, shape);

                        }
                        else
                            shape.draw(e);
                    }
                }
                );
                this.plMain.Focus();
            }
        }

        #region SHAPE

        private void bntLine_Click(object sender, EventArgs e)
        {
            isShape = IsShape.Line;
            this.Cursor = Cursors.Cross;

        }

        private void bntRectangle_Click(object sender, EventArgs e)
        {
            isShape = IsShape.Rectangle;
            this.Cursor = Cursors.Cross;
        }

        private void bntEllipse_Click(object sender, EventArgs e)
        {
            isShape = IsShape.Ellipes;
            this.Cursor = Cursors.Cross;
        }

        private void bntCircle_Click(object sender, EventArgs e)
        {
            isShape = IsShape.Circle;
            this.Cursor = Cursors.Cross;
        }

        private void bntSquare_Click(object sender, EventArgs e)
        {
            isShape = IsShape.Square;
            this.Cursor = Cursors.Cross;

        }

        private void bntPolygon_Click(object sender, EventArgs e)
        {
            isShape = IsShape.Polygon;
            this.Cursor = Cursors.Cross;
        }

        private void bntRamdow(object sender, EventArgs e)
        {
            isShape = IsShape.Pen;
        }

        private void bntCurve_Click(object sender, EventArgs e)
        {
            isShape = IsShape.Curve;

        }

        #endregion

        #region MOUSE EVENT

        private void plMain_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void plMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (statusPaint.isNotDrawing == false)
            {

                switch (isShape)
                {
                    case IsShape.Line:
                        {
                            Shape temp = new Line();
                            setPropertiesShape(temp);
                            temp.p1 = e.Location;
                            temp.p2 = e.Location;
                            lShape.Add(temp);
                            statusPaint.isStart = true;
                            break;
                        }

                    case IsShape.Rectangle:
                        {
                            Shape temp = new Rectangle();
                            setPropertiesShape(temp);
                            temp.p1 = e.Location;
                            temp.p2 = e.Location;
                            lShape.Add(temp);
                            statusPaint.isStart = true;
                            break;
                        }

                    case IsShape.Ellipes:
                        {
                            Shape temp = new Ellipse();

                            setPropertiesShape(temp);
                            temp.p1 = e.Location;
                            temp.p2 = e.Location;
                            lShape.Add(temp);
                            statusPaint.isStart = true;
                            break;
                        }

                    case IsShape.Circle:
                        {
                            Shape temp = new Circle();
                            setPropertiesShape(temp);
                            temp.p1 = e.Location;
                            temp.p2 = e.Location;
                            lShape.Add(temp);
                            statusPaint.isStart = true;
                            break;
                        }

                    case IsShape.Square:
                        {
                            Shape temp = new Square();
                            setPropertiesShape(temp);
                            temp.p1 = e.Location;
                            temp.p2 = e.Location;

                            lShape.Add(temp);
                            statusPaint.isStart = true;
                            break;
                        }

                    case IsShape.Pen:
                        {

                            Shape temp = new lPen();
                            setPropertiesShape(temp);

                            temp.p1 = e.Location;
                            temp.p2 = e.Location;

                            lShape.Add(temp);
                            statusPaint.isStart = true;
                            break;
                        }

                    case IsShape.Polygon:
                        {
                            if (statusPaint.isDrawPolygon == false)
                            {
                                statusPaint.isDrawPolygon = true;
                                Shape temp = new Polygon();
                                setPropertiesShape(temp);
                                temp.lPoint.Add(e.Location);
                                temp.lPoint.Add(e.Location);
                                lShape.Add(temp);

                                statusPaint.isStart = true;
                            }

                            else
                            {

                                Polygon temp = lShape[lShape.Count - 1] as Polygon;
                                temp.lPoint[temp.lPoint.Count - 1] = e.Location;
                                temp.lPoint.Add(e.Location);
                            }

                            break;

                        }

                    case IsShape.Curve:
                        {
                            if (statusPaint.isDrawPolygon == false)
                            {
                                Shape temp = new Curve();
                                setPropertiesShape(temp);
                                temp.lPoint.Add(e.Location);
                                temp.lPoint.Add(e.Location);
                                lShape.Add(temp);

                                statusPaint.isStart = true;
                                statusPaint.isDrawPolygon = true;
                            }

                            else

                            {
                                Curve temp = lShape[lShape.Count - 1] as Curve;
                                temp.lPoint[temp.lPoint.Count - 1] = e.Location;
                                temp.lPoint.Add(e.Location);
                            }
                            break;

                        }

                    default: break;
                }


            }

            else

            {
                plMain.Cursor = Cursors.Default;
                statusPaint.isStart = true;

                if (statusPaint.isSelectedOneShape)
                {
                    statusPaint.isMouseDown = true;
                    pFirst = e.Location;
                    pastDistanceX = 0;
                    pastDistanceY = 0;

                    if (pLast != null && indexShapeSelected != - 1 && lShape.Count > 0 && indexShapeSelected < lShape.Count && lShape[indexShapeSelected].isPointOfControl(pLast) == true)
                    {

                        plMain.Cursor = Cursors.SizeNESW;
                        statusPaint.isZoom = true;
                    }
                }
                else
                {
                    if (pressControl)
                    {

                        plMain.Cursor = Cursors.SizeAll;
                        lShape.ForEach(shape =>
                        {
                            if (shape.isHit(e.Location) && shape.isSelected == false)
                                shape.isSelected = true;

                        });
                        this.plMain.Refresh();
                        statusPaint.isSelectedOneShape = false;

                    }
                    else
                    {
                        plMain.Cursor = Cursors.Default;
                        statusPaint.isSelectedOneShape = false;
                        lShape.ForEach(shape =>
                        { shape.isSelected = false; });
                        selectedShape(e.Location);
                        this.plMain.Refresh();
                    }
                }

            }

        }

        private void setPropertiesShape(Shape temp)
        {
            temp.myPen = new Pen(myColor, width);
            temp.myPen.DashStyle = myPen.DashStyle;
            temp.myBrush = new SolidBrush(myColor);
            temp.isFill = this.Fill;
        }


        private void plMain_MouseMove(object sender, MouseEventArgs e)
        {

            if (statusPaint.isNotDrawing == false)
            {
                if (isShape == IsShape.Pen && statusPaint.isStart == true) // để vẽ đường nét tự do, 
                {
                    Shape temp = new lPen();// tạo 1 hình tạm để fix lỗi khi list hình rỗng
                    temp.myPen = new Pen(myColor, width);
                    temp.p1 = e.Location;
                    temp.p2 = e.Location;

                    lShape.Add(temp);

                    this.lShape[this.lShape.Count - 1].p1 = this.lShape[this.lShape.Count - 2].p2;
                    this.lShape[this.lShape.Count - 1].p2 = e.Location;
                    this.plMain.Refresh();
                }

                else if (statusPaint.isDrawPolygon == true)
                {
                 
                    if (isShape == IsShape.Polygon)
                    {
                        Polygon temp = lShape[lShape.Count - 1] as Polygon;
                        if(temp != null)
                            temp.lPoint[temp.lPoint.Count - 1] = e.Location;

                    }

                    else
                    {
                        Curve temp = lShape[lShape.Count - 1] as Curve;
                        if(temp != null)
                            temp.lPoint[temp.lPoint.Count - 1] = e.Location;
                    }
                    this.plMain.Refresh();
                    
                }
                else if (statusPaint.isStart == true)
                {
                    this.lShape[this.lShape.Count - 1].p2 = e.Location;

                    this.plMain.Refresh();
                }

            }

            else
            {

                if (statusPaint.isMouseDown)
                {

                    if (statusPaint.isSelectedOneShape && indexShapeSelected != -1 && indexShapeSelected < lShape.Count)
                    {

                        pLast = e.Location;

                        if (statusPaint.isZoom)
                        {
                            ZoomShape(indexShapeSelected, pFirst, pLast);
                            this.plMain.Refresh();
                        }

                        else
                        {
                            MoveShape(indexShapeSelected, pFirst, pLast);
                            plMain.Refresh();
                        }
                    }
                }

            }
        }

        private void plMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (statusPaint.isNotDrawing == false)
            {
                if (isShape == IsShape.Curve || isShape == IsShape.Polygon)
                {

                }
                else
                {
                    if (isShape == IsShape.Pen && statusPaint.isStart == true)
                    {
                        Shape temp = new lPen();
                        temp.myPen = new Pen(myColor, width);
                        temp.p1 = e.Location;
                        temp.p2 = e.Location;

                        lShape.Add(temp);
                        this.lShape[this.lShape.Count - 1].p1 = this.lShape[this.lShape.Count - 2].p2;
                        this.lShape[this.lShape.Count - 1].p2 = e.Location;
                        this.plMain.Refresh();
                    }
                    else if (statusPaint.isStart == true)
                    {
                        this.lShape[this.lShape.Count - 1].p2 = e.Location;
                        this.plMain.Refresh();
                    }

                    statusPaint.isStart = false;

                    this.Cursor = Cursors.Default;
                }

            }

            else
            {
                if (statusPaint.isMouseDown)
                {
                    if (statusPaint.isSelectedOneShape)
                    {
                        pLast = e.Location;

                        if (statusPaint.isZoom)
                        {
                            ZoomShape(indexShapeSelected, pFirst, pLast);
                        }
                        else
                        {
                            MoveShape(indexShapeSelected, pFirst, pLast);
                        }
                        plMain.Refresh();
                        statusPaint.isSelectedOneShape = false;
                        statusPaint.isMouseDown = false;
                        statusPaint.isStart = false;
                        statusPaint.isZoom = false;
                    }
                }
            }
        }

        private void plMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (statusPaint.isNotDrawing == false)

            {
                if (isShape == IsShape.Polygon)
                {
                    isShape = IsShape.Non;
                    Polygon temp = lShape[lShape.Count - 1] as Polygon;
                    temp.lPoint.RemoveAt(temp.lPoint.Count - 1);
                    this.plMain.Refresh();
                    statusPaint.isStart = false;
                    statusPaint.isDrawPolygon = false;
                    this.Cursor = Cursors.Default;
                    FindRegion.setPolygonPointFirstEnd(temp);
                }

                if (isShape == IsShape.Curve)
                {
                    isShape = IsShape.Non;
                    Curve temp = lShape[lShape.Count - 1] as Curve;
                    temp.lPoint.RemoveAt(temp.lPoint.Count - 1);
                    this.plMain.Refresh();
                    statusPaint.isStart = false;
                    statusPaint.isDrawPolygon = false;
                    this.Cursor = Cursors.Default;
                    FindRegion.setCurvePointFirstEnd(temp);
                }

            }
        }


        #endregion

        #region PEN - WIDTH - COLOR....

        private void trbWidth_Scroll(object sender, EventArgs e)
        {
            this.width = trbWidth.Value;
            lbWidth.Text = trbWidth.Value.ToString();
            statusPaint.isChangeWidth = true;
            selectChangePen();
            statusPaint.isChangeWidth = false;
        }

        private void bntColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.myColor = colorDialog1.Color;
                statusPaint.isChangeColor = true;
                selectChangePen();
                statusPaint.isChangeColor = false;
                this.pnlCurrentColor.BackColor = myColor;
            }
        }

        private void pnlRed_MouseClick(object sender, MouseEventArgs e)
        {
            myColor = Color.Red;
            statusPaint.isChangeColor = true;
            selectChangePen();
            statusPaint.isChangeColor = false;
            this.pnlCurrentColor.BackColor = myColor;
        }

        private void pnlWhite_MouseClick(object sender, MouseEventArgs e)
        {
            myColor = Color.White;
            statusPaint.isChangeColor = true;
            selectChangePen();
            statusPaint.isChangeColor = false;
            this.pnlCurrentColor.BackColor = myColor;
        }

        private void pnlYellow_MouseClick(object sender, MouseEventArgs e)
        {
            myColor = Color.Yellow;
            statusPaint.isChangeColor = true;
            selectChangePen();
            statusPaint.isChangeColor = false;
            this.pnlCurrentColor.BackColor = myColor;
        }

        private void pnlGreen_MouseClick(object sender, MouseEventArgs e)
        {
            myColor = Color.Green;
            statusPaint.isChangeColor = true;
            selectChangePen();
            statusPaint.isChangeColor = false;
            this.pnlCurrentColor.BackColor = myColor;
        }

        private void pnlBlack_MouseClick(object sender, MouseEventArgs e)
        {
            myColor = Color.Black;
            statusPaint.isChangeColor = true;
            selectChangePen();
            statusPaint.isChangeColor = false;
            this.pnlCurrentColor.BackColor = myColor;
        }

        private void pnlBlue_MouseClick(object sender, MouseEventArgs e)
        {
            myColor = Color.Navy;
            statusPaint.isChangeColor = true;
            selectChangePen();
            statusPaint.isChangeColor = false;
            this.pnlCurrentColor.BackColor = myColor;
        }

        private void pnlSalmon_MouseClick(object sender, MouseEventArgs e)
        {
            myColor = Color.Salmon;
            statusPaint.isChangeColor = true;
            selectChangePen();
            statusPaint.isChangeColor = false;
            this.pnlCurrentColor.BackColor = myColor;
        }

        private void pnlTeal_MouseClick(object sender, MouseEventArgs e)
        {
            myColor = Color.Teal;
            statusPaint.isChangeColor = true;
            selectChangePen();
            statusPaint.isChangeColor = false;
            this.pnlCurrentColor.BackColor = myColor;
        }

        #endregion

        #region STYTE PEN - BRUSH
        private void cmbFill_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            int index = cb.SelectedIndex;
            switch (index)
            {
                case 0: { this.cmbStytePen.Enabled = true; this.Fill = false; break; }
                case 1: { this.cmbStytePen.Enabled = false; this.Fill = true; break; }
                default:
                    break;
            }
        }

        private void cmbStytePen_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            int index = cb.SelectedIndex;
            switch (index)
            {
                case 0: { myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid; break; }
                case 1: { myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash; break; }
                case 2: { myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot; break; }
                case 3: { myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot; break; }
                case 4: { myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot; break; }
                default:
                    break;
            }
            statusPaint.isChangeStyte = true;
            selectChangePen();
            statusPaint.isChangeStyte = false;
        }

        #endregion

        #region SELECTED
        private void selectChangePen()
        {
            
            if (statusPaint.isSelectedShape)
            {
                statusPaint.isStart = true;
                lShape.ForEach(p =>
              {
                  if (p.isSelected == true)
                  {
                      if (p is GroupShape)
                      {
                          selectChangeShapeIsGroup(p as GroupShape);
                      }
                      else
                      {

                          Pen temp = new Pen(myColor);
                          temp.DashStyle = p.myPen.DashStyle; // gán giá trị dashStyte
                          if (statusPaint.isChangeColor)
                          {
                             
                              p.myPen = new Pen(myColor, p.myPen.Width);
                              p.myPen.DashStyle = temp.DashStyle;
                          }

                          if (statusPaint.isChangeWidth)
                          {
                              p.myPen = new Pen(p.myPen.Color, width);
                              p.myPen.DashStyle = temp.DashStyle;
                          }

                          if(statusPaint.isChangeStyte)
                             p.myPen.DashStyle = myPen.DashStyle;
                          
                            p.myBrush = new SolidBrush(myColor);
                      }
                  }

              });
                this.plMain.Refresh();
            }
        }

        private void selectChangeShapeIsGroup(GroupShape shape)
        {
            shape.lGroup.ForEach(p =>
            {
                if (p is GroupShape)
                {
                    p.lGroup.ForEach(sh =>
                    {
                        sh.myPen = new Pen(myColor, width);
                        sh.myPen.DashStyle = myPen.DashStyle;
                        sh.myBrush = new SolidBrush(myColor);
                    });
                }

                else
                {
                    p.myPen = new Pen(myColor, width);
                    p.myPen.DashStyle = myPen.DashStyle;
                    p.myBrush = new SolidBrush(myColor);
                }
            });

            this.plMain.Refresh();
        }

        private void ckbSelected_CheckedChanged(object sender, EventArgs e)
        {
            statusPaint.isStart = true;
            this.plMain.Refresh();
            this.Cursor = Cursors.Default;
            //plMain.Cursor = Cursors.Default;
            if (ckbSelected.Checked == true)
            {
                statusPaint.isNotDrawing = true;
                statusPaint.isSelectedShape = true;
                isShape = IsShape.Non;
            }

            else

            {
                statusPaint.isNotDrawing = false;
                statusPaint.isSelectedShape = false;
                lShape.ForEach(shape =>
                { shape.isSelected = false; });
                this.plMain.Refresh();

                statusPaint.isStart = false;

            }
        }

        private void selectedShape(Point point)
        {

            for (int i = 0; i < lShape.Count; i++)
                if (lShape[i].isHit(point))
                {
                    lShape[i].isSelected = true;
                    plMain.Cursor = Cursors.SizeAll;
                    statusPaint.isSelectedOneShape = true;
                    indexShapeSelected = i;
                    break;
                }

        }


        #endregion

        #region EARSER
        private void bntEaser_Click(object sender, EventArgs e)
        {
            statusPaint.isEraser = true;
            Eraser();

            this.plMain.Refresh();
        }


        private void Eraser()
        {
            statusPaint.isStart = true;
            for (int i = 0; i < lShape.Count; i++)
                if (lShape[i].isSelected)
                {
                    lShape.RemoveAt(i);
                    i--;
                }

            statusPaint.isEraser = false;
            ///indexShapeSelected = -1;

        }

        #endregion

        #region KEYDOWN-KEYUP

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            pressControl = e.Control;
            this.plMain.Focus();
            if (statusPaint.isSelectedShape)
            {
                switch (e.KeyCode)
                {
                    case Keys.Delete:

                    case Keys.Back:
                        {

                            bntEaser.PerformClick();
                            break;

                        }
                    default:
                        {
                            break;
                        }
                }

                if (e.Shift)
                {
                    if (indexShapeSelected != -1 &&indexShapeSelected < lShape.Count && lShape[indexShapeSelected] is GroupShape) // unGroup
                    {
                        if (e.Control == true && e.KeyCode == Keys.G)
                        {
                            for (int i = 0; i < lShape[indexShapeSelected].lGroup.Count; i++)
                            {
                                Shape temp = lShape[indexShapeSelected].lGroup[i];
                                lShape.Add(temp);

                            }
                            lShape[indexShapeSelected].lGroup.Clear();
                            lShape.Remove(lShape[indexShapeSelected]);
                            statusPaint.isSelectedOneShape = false;
                            statusPaint.isStart = true;
                            plMain.Refresh();
                        }
                    }
                }

                else
                {
                    if (e.Control == true && e.KeyCode == Keys.G) // Group
                    {
                        Shape lgroup = new GroupShape();

                        for (int i = 0; i < lShape.Count; i++)
                        {
                            if (lShape[i].isSelected)
                            {
                                if (lShape[i] is GroupShape)
                                {
                                    for (int index = 0; index < lShape[i].lGroup.Count; index++)
                                    {
                                        Shape temp = lShape[i].lGroup[index];
                                        lgroup.lGroup.Add(temp);
                                    }
                                    lShape[i].lGroup.Clear();
                                    lShape.Remove(lShape[i]);
                                    i--;
                                }
                                else
                                {
                                    lgroup.lGroup.Add(lShape[i]);
                                    lShape.Remove(lShape[i]);
                                    i--;
                                }
                            }
                        }

                        if (lgroup.lGroup.Count > 0)
                        {
                            FindRegion.regionOfGroup(lgroup);
                            lgroup.isSelected = true;
                            lShape.Add(lgroup);
                            indexShapeSelected = lShape.Count - 1;
                            
                        }
                        plMain.Refresh();
                    }
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            pressControl = e.Control;
        }

        #endregion

        #region ZOOM

        private void ZoomShape(int index, Point p1, Point p2)
        {
            if (index < lShape.Count)
            {
                Shape shape = lShape[index];
                if (shape is Polygon || shape is Curve)
                    ZoomCurveOrPolygon(shape, p1, p2);
                else if (shape is GroupShape)
                    ZoomGroup(index, p1, p2);
                else
                    ZoomShapeBasic(shape, p1, p2);
            }
        }

        private void ZoomGroup(int index, Point p1, Point p2)
        {
            int distanceX = p2.X - p1.X;
            int distanceY = p2.Y - p1.Y;
            for (int i = 0; i < lShape[index].lGroup.Count; i++)
            {
                if (lShape[index].lGroup[i] is Curve || lShape[index].lGroup[i] is Polygon)
                {
                    for (int j = 1; j < lShape[index].lGroup[i].lPoint.Count; j++)
                    {
                        Point p = lShape[index].lGroup[i].lPoint[j];

                        p.X += distanceX - pastDistanceX;
                        p.Y += distanceY - pastDistanceY;

                        lShape[index].lGroup[i].lPoint[j] = p;

                    }
                }

                else
                {
                    lShape[index].lGroup[i].p2.X += distanceX - pastDistanceX;
                    lShape[index].lGroup[i].p2.Y += distanceY - pastDistanceY;
                }
            }

            pastDistanceX = distanceX;
            pastDistanceY = distanceY;
        }

        private void ZoomShapeBasic(Shape shape, Point p1, Point p2)
        {
            int distanceX = p2.X - p1.X;
            int distanceY = p2.Y - p1.Y;


            shape.p2.X += distanceX - pastDistanceX;
            shape.p2.Y += distanceY - pastDistanceY;

            pastDistanceX = distanceX;
            pastDistanceY = distanceY;
        }


        private void ZoomCurveOrPolygon(Shape shape, Point p1, Point p2)
        {
            int distanceX = p2.X - p1.X;
            int distanceY = p2.Y - p1.Y;
            //Point p0 = shape.lPoint[0]; //
            //shape.lPoint[0] = new Point(p0.X, p0.Y += distanceX - pastDistanceX);//
            for (int i = 1; i < shape.lPoint.Count; i++)
            {               
                Point p = shape.lPoint[i];
                shape.lPoint[i] = new Point(p.X += distanceX - pastDistanceX, p.Y += distanceY - pastDistanceY);
            }

            pastDistanceX = distanceX;
            pastDistanceY = distanceY;
        }


        #endregion

        #region MOVE

        private void MoveShape(int index, Point p1, Point p2)
        {
            if (index < lShape.Count)
            {
                if (lShape[index] is Curve || lShape[index] is Polygon)

                    moveCurveAndPolygon(lShape[index], p1, p2);

                else if (lShape[index] is GroupShape)
                    moveGroup(index, p1, p2);

                else
                    moveShapeBasic(lShape[index], p1, p2);
            }

        }

        private void moveGroup(int index, Point p1, Point p2)
        {
            int distanceX = p2.X - p1.X;
            int distanceY = p2.Y - p1.Y;

            for (int i = 0; i < lShape[index].lGroup.Count; i++)
            {
                if (lShape[index].lGroup[i] is Curve || lShape[index].lGroup[i] is Polygon)
                {
                    for (int j = 0; j < lShape[index].lGroup[i].lPoint.Count; j++)
                    {
                        Point p = new Point(lShape[index].lGroup[i].lPoint[j].X, lShape[index].lGroup[i].lPoint[j].Y);
                        p.X += distanceX - pastDistanceX;
                        p.Y += distanceY - pastDistanceY;

                        lShape[index].lGroup[i].lPoint[j] = p;

                    }
                }
                else
                {
                    lShape[index].lGroup[i].p1.X += distanceX - pastDistanceX;
                    lShape[index].lGroup[i].p1.Y += distanceY - pastDistanceY;
                    lShape[index].lGroup[i].p2.X += distanceX - pastDistanceX;
                    lShape[index].lGroup[i].p2.Y += distanceY - pastDistanceY;
                }
            }

            pastDistanceX = distanceX;
            pastDistanceY = distanceY;
        }



        private void moveCurveAndPolygon(Shape shape, Point p1, Point p2)
        {
            int distanceX = p2.X - p1.X;
            int distanceY = p2.Y - p1.Y;

            for (int i = 0; i < shape.lPoint.Count; i++)
            {
                Point p = new Point(shape.lPoint[i].X, shape.lPoint[i].Y);
                p.X += distanceX - pastDistanceX;
                p.Y += distanceY - pastDistanceY;

                shape.lPoint[i] = p;

            }

            pastDistanceX = distanceX;
            pastDistanceY = distanceY;
        }

        private void moveShapeBasic(Shape shape, Point p1, Point p2)

        {
            int distanceX = p2.X - p1.X;
            int distanceY = p2.Y - p1.Y;

            shape.p1.X += distanceX - pastDistanceX;
            shape.p1.Y += distanceY - pastDistanceY;
            shape.p2.X += distanceX - pastDistanceX;
            shape.p2.Y += distanceY - pastDistanceY;

            pastDistanceX = distanceX;
            pastDistanceY = distanceY;
        }

        #endregion

        private void bntGroup_Click(object sender, EventArgs e)
        {
            if (statusPaint.isSelectedShape)
            {
                statusPaint.isStart = true;//
                Shape lgroup = new GroupShape();

                for (int i = 0; i < lShape.Count; i++)
                {
                    if (lShape[i].isSelected)
                    {
                        if (lShape[i] is GroupShape)
                        {
                            for (int index = 0; index < lShape[i].lGroup.Count; index++)
                            {
                                Shape temp = lShape[i].lGroup[index];
                                lgroup.lGroup.Add(temp);
                            }
                            lShape[i].lGroup.Clear();
                            lShape.Remove(lShape[i]);
                            i--;
                        }
                        else
                        {
                            lgroup.lGroup.Add(lShape[i]);
                            lShape.Remove(lShape[i]);
                            i--;
                        }
                    }
                }

                if (lgroup.lGroup.Count > 0)
                {
                    FindRegion.regionOfGroup(lgroup);
                    lgroup.isSelected = true;
                    lShape.Add(lgroup);
                    indexShapeSelected = lShape.Count - 1;
                   
                }
                plMain.Refresh();
            }
           
        }

        private void btnUngroup_Click(object sender, EventArgs e)
        {
            if (statusPaint.isSelectedShape)
            {
                if (indexShapeSelected != -1 && lShape[indexShapeSelected] is GroupShape)
                {
                    for (int i = 0; i < lShape[indexShapeSelected].lGroup.Count; i++)
                    {
                        Shape temp = lShape[indexShapeSelected].lGroup[i];
                        lShape.Add(temp);

                    }
                    lShape[indexShapeSelected].lGroup.Clear();
                    lShape.Remove(lShape[indexShapeSelected]);
                    statusPaint.isSelectedOneShape = false;
                    statusPaint.isStart = true;
                    plMain.Refresh();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
