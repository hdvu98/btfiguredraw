using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.Graphics;

namespace FigureDraw.Diagram.ActivityDiagram
{
    public class ADHandleBlock : HandleBlock
    {
        public override void draw(CommonGraphics graphic)
        {
            graphic.drawLine(Info.point1.X + 10, Info.point1.Y, Info.point1.X + Info.width - 10, Info.point1.Y);
            graphic.drawLine(Info.point1.X + 5, Info.point1.Y + 5, Info.point1.X + 5, Info.point1.Y + Info.height - 5);
            graphic.drawLine(Info.point1.X + 10, Info.point1.Y, Info.point1.X + 5, Info.point1.Y + 5);
            graphic.drawLine(Info.point1.X + 5, Info.point1.Y + Info.height - 5, Info.point1.X + 10, Info.point1.Y + Info.height);

            graphic.drawLine(Info.point1.X + 10, Info.point1.Y + Info.height, Info.point1.X + Info.width -10, Info.point1.Y + Info.height );
            graphic.drawLine(Info.point1.X -5 + Info.width, Info.point1.Y -5 + Info.height, Info.point1.X + Info.width -5, Info.point1.Y + 5);
            graphic.drawLine( Info.point1.X + Info.width - 10, Info.point1.Y + Info.height, Info.point1.X - 5 + Info.width, Info.point1.Y - 5 + Info.height);
            graphic.drawLine(Info.point1.X - 5 + Info.width, Info.point1.Y +5, Info.point1.X + Info.width - 10, Info.point1.Y);

        }
    }
}
