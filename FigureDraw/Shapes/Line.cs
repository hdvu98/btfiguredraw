using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.Graphics;

namespace FigureDraw.Shapes
{
    public class Line : Shape
    {
        public override void draw(CommonGraphics graphic)
        {
            graphic.drawLine(Info.point1.X, Info.point1.Y, Info.point2.X, Info.point2.Y);
        }
    }
}
