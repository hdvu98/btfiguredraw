using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.Graphics;

namespace FigureDraw.Shapes
{
    public class Ellipse : Shape
    {
        public override void draw(CommonGraphics graphic)
        {
            graphic.drawEllipse(Info.point1.X, Info.point1.Y, Info.width, Info.height); 
        }
    }
}
