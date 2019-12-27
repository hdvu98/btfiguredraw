using FigureDraw.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram.FlowChart
{
    public class FCStartBlock:StartBlock
    {
        public override void draw(CommonGraphics g)
        {
            g.drawEllipse(Info.point1.X, Info.point1.Y, Info.width+10, Info.height+10);

            SolidBrush color = new SolidBrush(Color.Black);
            Font f = new Font("Arial", Info.height / 2);
            g.drawText("Start", color, new Point(Info.point1.X+10, Info.point1.Y+10), f);

        }
    }
}
