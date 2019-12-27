using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureDraw.Common;

namespace FigureDraw.Diagram.FlowChart
{
    public class FCFactory : DiagramFactory
    {
        public ConditionBlock createConditionBlock(ShapeInfo info)
        {
            ConditionBlock block= new FCConditionBlock();
            block.Info = info;
            return block;
        }

        public EndBlock createEndBlock(ShapeInfo info)
        {
            EndBlock block = new FCEndBlock();
            block.Info = info;
            return block;
        }

        public HandleBlock createHandleBlock(ShapeInfo info)
        {
            HandleBlock block = new FCHandleBlock();
            block.Info = info;
            return block;
        }

        public InputBlock createInputBlock(ShapeInfo info)
        {
            InputBlock block = new FCInputBlock();
            block.Info = info;
            return block;
        }

        public OutputBlock createOutputBlock(ShapeInfo info)
        {
            OutputBlock block = new FCOutputBlock();
            block.Info = info;
            return block;
        }

        public StartBlock createStartBlock(ShapeInfo info)
        {
            StartBlock block = new FCStartBlock();
            block.Info = info;
            return block;
        }

        public StepBlock createStepBlock(ShapeInfo info)
        {
            StepBlock block = new FCStepBlock();
            block.Info = info;
            return block;
        }
    }
}
