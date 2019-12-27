using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.Graphics;

namespace FigureDraw.Diagram.ActivityDiagram
{
    public class ADStartBlock : StartBlock
    {
        public override void draw(CommonGraphics graphic)
        {
            graphic.drawFillEllipse(Info.point1.X, Info.point1.Y, Info.width, Info.height);
        }
    }
}
