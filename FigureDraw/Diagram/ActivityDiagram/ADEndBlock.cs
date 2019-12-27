using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.Graphics;

namespace FigureDraw.Diagram.ActivityDiagram
{
    public class ADEndBlock : EndBlock
    {
        public override void draw(CommonGraphics graphic)
        {
            graphic.drawFillEllipse(Info.point1.X, Info.point1.Y, Info.width, Info.height);
            graphic.drawEllipse(Info.point1.X - 5, Info.point1.Y - 5, Info.width + 10, Info.height + 10);
        }
    }
}
