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
    public static class statusPaint
    {
        public static bool isDrawPolygon = false;
        public static bool isStart = false;
        public static bool isNotDrawing = false;
        public static bool isSelectedShape = false;
        public static bool isEraser = false;
        public static bool isSelectedOneShape = false;
        public static bool isMouseDown = false;
        public static bool isZoom = false;
        public static bool isChangeColor = false;
        public static bool isChangeWidth = false;
        public static bool isChangeStyte = false;
    }
}
