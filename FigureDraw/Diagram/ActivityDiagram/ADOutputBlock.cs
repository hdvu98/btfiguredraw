using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.Graphics;

namespace FigureDraw.Diagram.ActivityDiagram
{
    public class ADOutputBlock : OutputBlock
    {
        public override void draw(CommonGraphics graphic)
        {
            graphic.drawLine(Info.point1.X, Info.point1.Y, Info.point1.X + Info.width, Info.point1.Y);
            graphic.drawLine(Info.point1.X, Info.point1.Y, Info.point1.X, Info.point1.Y + Info.height);
            graphic.drawLine(Info.point1.X, Info.point1.Y + Info.height, Info.point1.X + Info.width - (int)(Info.width / 7), Info.point1.Y + Info.height);
            graphic.drawLine(Info.point1.X + Info.width, Info.point1.Y + Info.height - (int)(Info.width / 7), Info.point1.X + Info.width, Info.point1.Y);
            graphic.drawLine(Info.point1.X + Info.width, Info.point1.Y + Info.height - (int)(Info.width / 7), Info.point1.X + Info.width - (int)(Info.width / 7), Info.point1.Y + Info.height);

        }
    }
}
