using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FigureDraw.Graphics
{
    public abstract class CommonGraphics
    {
        protected Color lineColor = Color.Black;
        protected Color fillColor = Color.White;
        protected int lineWidth = 5;
        protected bool isFill = false;
        public abstract void drawLine(int x1, int y1, int x2, int y2);
        public abstract void drawRectangle(int x1, int y1, int width, int height);
        public abstract void drawEllipse(int cx, int cy, int hradius, int vradius);
        public abstract void drawText(string content, Brush brush, Point position, Font font);

    }
}
