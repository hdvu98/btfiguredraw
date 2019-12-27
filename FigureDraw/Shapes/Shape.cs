using FigureDraw.Common;
using FigureDraw.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Shapes
{
    public abstract class Shape
    {
        private ShapeInfo info;

        public ShapeInfo Info { get => info; set => info = value; }

        public abstract void draw(CommonGraphics graphic);
    }
}
