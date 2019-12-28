using System;
using System.Collections.Generic;
using System.Drawing;
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
    
            g.setPathColor(5,Color.Black);
            int temp = (shape.Info.width + shape.Info.width) / 12;
            shape.Info.point1.X += 2;
            shape.Info.point1.Y += 2;
            shape.draw(g);
            shape.Info.point1.X -= 2;
            shape.Info.point1.Y -= 2;
        }
    }
}
