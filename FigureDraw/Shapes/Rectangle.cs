using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.Common;
using FigureDraw.Graphics;

namespace FigureDraw.Shapes
{
    public class Rectangle : Shape
    {

        public override void draw(CommonGraphics graphic)
        {
            graphic.drawRectangle(Info.point1.X, Info.point1.Y, Info.width, Info.height);
        }
    }
}
