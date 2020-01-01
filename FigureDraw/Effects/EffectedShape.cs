using FigureDraw.Graphics;
using FigureDraw.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Effects
{
    public abstract class EffectedShape : Shape
    {
        public Shape shape;
        public override void draw(CommonGraphics graphic)
        {
            format(graphic, shape);
            graphic.setPathColor(2, System.Drawing.Color.Blue);
            shape.draw(graphic);
            graphic.setPathColor(2, System.Drawing.Color.Black);


        }
        protected abstract void format(CommonGraphics g, Shape shape);
    }
}
