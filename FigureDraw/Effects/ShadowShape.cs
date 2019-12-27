using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.Graphics;
using FigureDraw.Shapes;

namespace FigureDraw.Effects
{
    public class ShadowShape : EffectedShape
    {
        protected override void format(CommonGraphics g, Shape shape)
        {
            g.drawFillEllipse(shape.Info.point1.X, shape.Info.point1.Y, shape.Info.width, shape.Info.height);
            shape.Info.point1.X += 5;
            shape.Info.point1.Y += 5;
            shape.draw(g);
        }
    }
}
