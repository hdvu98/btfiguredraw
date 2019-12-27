using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FigureDraw.Graphics
{
    public class GDIPlusGraphic : CommonGraphics
    {
        static private Pen pen = new Pen(Color.Black, 5);
        private System.Drawing.Graphics lib;

        public GDIPlusGraphic(System.Drawing.Graphics lib, Color lineColor, Color fillColor,int lineWidth,bool isFill)
        {
            this.lib = lib;
            this.lineColor = lineColor;
            this.fillColor = fillColor;
            this.lineWidth = lineWidth;
            this.isFill = isFill;
        }

        public GDIPlusGraphic(System.Drawing.Graphics lib)
        {
            this.lib = lib;
        }

        public override void drawEllipse(int cx, int cy, int hradius, int vradius)
        {
            lib.DrawEllipse(pen, cx, cy, hradius, vradius);
        }

        public override void drawLine(int x1, int y1, int x2, int y2)
        {
            lib.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
        }

        public override void drawRectangle(int x1, int y1, int width, int height)
        {
            lib.DrawRectangle(pen, x1, y1, width, height);
        }

        public override void drawText(string content, Brush brush, Point position, Font font)
        {
            lib.DrawString(content, font, brush, position);
        }


    }
}
