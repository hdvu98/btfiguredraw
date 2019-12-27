using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
    public class Diagram : Shapes.Shape
    {
        private List<Block> blocks= new List<Block>();
        private DiagramFactory factory;

        public Diagram(DiagramFactory factory)
        {
            this.factory = factory;
        }
        public Diagram()
        {

        }
        public void add(DiagramFactory factory)
        {
            ConditionBlock a=  factory.createConditionBlock(Info);
            blocks.Add(a);
        }

        public override void draw(Graphics.CommonGraphics graphic)
        {
            foreach(Block block in blocks)
            {
                block.draw(graphic);
            }
        }
    }
}
