using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cairo;

namespace FigureDraw.Graphics
{
    public class CairoGraphic : CommonGraphics
    {
        protected Context lib;
        protected Surface surface;

        public CairoGraphic(System.Drawing.Graphics g, System.Drawing.Color lineColor, System.Drawing.Color fillColor, int lineWidth, bool isFill)
        {

            surface = new Win32Surface(g.GetHdc());
            lib = new Context(surface);
            this.lineColor = lineColor;
            this.fillColor = fillColor;
            this.lineWidth = lineWidth;
            this.isFill = isFill;
        }

        public CairoGraphic(System.Drawing.Graphics g)
        {
            surface = new Win32Surface(g.GetHdc());
            lib = new Context(surface);
        }

        public override void drawEllipse(int cx, int cy, int hradius, int vradius)
        {
            lib.Save();
            Matrix matrix = lib.Matrix;
            lib.Translate((double)cx + (double)hradius / 2, (double)cy + (double)vradius / 2);
            lib.Scale((double)hradius / 2, (double)vradius / 2);
            lib.NewPath();
            lib.Arc(0, 0, 1, 0, 2 * Math.PI);
            lib.Matrix = matrix;
            if (isFill)
            {
                lib.SetSourceRGB(fillColor.R, fillColor.G, fillColor.B);
                lib.Fill();
            }
            lib.Stroke();
            lib.Restore();
        }

        public override void drawLine(int x1, int y1, int x2, int y2)
        {
            lib.MoveTo(x1, y1);
            lib.LineTo(x2, y2);
            lib.Stroke();
        }

        public override void drawRectangle(int x1, int y1, int width, int height)
        {
            lib.Rectangle(x1, y1, width, height);
            lib.Stroke();
        }

        public override void drawText(string content, Brush brush, System.Drawing.Point position, Font font)
        {
            lib.Save();
            lib.MoveTo(position.X, position.Y);
            lib.SelectFontFace("ariel", FontSlant.Normal, FontWeight.Normal);
            lib.SetFontSize(13);
            lib.ShowText(content);
            lib.Restore();
        }

        public override void drawFillEllipse(int cx, int cy, int hradius, int vradius)
        {
            lib.Save();
            Matrix matrix = lib.Matrix;
            lib.Translate((double)cx + (double)hradius / 2, (double)cy + (double)vradius / 2);
            lib.Scale((double)hradius / 2, (double)vradius / 2);
            lib.NewPath();
            lib.Arc(0, 0, 1, 0, 2 * Math.PI);
            lib.Matrix = matrix;
            lib.Fill();
            lib.Stroke();
            lib.Restore();
        }

        public override void setHighlight(int size, System.Drawing.Color clolor)
        {
            throw new NotImplementedException();
        }

        public override void setFillColor(System.Drawing.Color clolor)
        {
            throw new NotImplementedException();
        }

        public override void setPathColor(int size, System.Drawing.Color clolor)
        {
            lib.LineWidth = size;
            lib.SetSourceRGB(clolor.R, clolor.G, clolor.B);
        }
    }
}
