using FigureDraw.Common;
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
        public void add(DiagramBlock block,DiagramFactory factory)
        {
            switch (block)
            {
                case DiagramBlock.Start:
                    {
                        StartBlock a = factory.createStartBlock(Info);
                        blocks.Add(a);
                        break;
                    }
                case DiagramBlock.Input:
                    {
                        InputBlock a = factory.createInputBlock(Info);
                        blocks.Add(a);
                        break;
                    }
                case DiagramBlock.Handle:
                    {
                        HandleBlock a = factory.createHandleBlock(Info);
                        blocks.Add(a);
                        break;
                    }
                case DiagramBlock.Output:
                    {
                        OutputBlock a = factory.createOutputBlock(Info);
                        blocks.Add(a);
                        break;
                    }
                case DiagramBlock.Condition:
                    {
                        ConditionBlock a = factory.createConditionBlock(Info);
                        blocks.Add(a);
                        break;
                    }
                case DiagramBlock.Step:
                    {
                        StepBlock a = factory.createStepBlock(Info);
                        blocks.Add(a);
                        break;
                    }
                case DiagramBlock.End:
                    {
                        EndBlock a = factory.createEndBlock(Info);
                        blocks.Add(a);
                    }
                    break;
                default:
                    break;
            }

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
