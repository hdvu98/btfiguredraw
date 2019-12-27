using FigureDraw.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram.ActivityDiagram
{
    public class ADFactory:DiagramFactory
    {
        public ConditionBlock createConditionBlock(ShapeInfo info)
        {
            ConditionBlock block = new ADConditionBlock();
            block.Info = info;
            return block;
        }

        public EndBlock createEndBlock(ShapeInfo info)
        {
            EndBlock block = new ADEndBlock();
            block.Info = info;
            return block;
        }

        public HandleBlock createHandleBlock(ShapeInfo info)
        {
            HandleBlock block = new ADHandleBlock();
            block.Info = info;
            return block;
        }

        public InputBlock createInputBlock(ShapeInfo info)
        {
            InputBlock block = new ADInputBlock();
            block.Info = info;
            return block;
        }

        public OutputBlock createOutputBlock(ShapeInfo info)
        {
            OutputBlock block = new ADOutputBlock();
            block.Info = info;
            return block;
        }

        public StartBlock createStartBlock(ShapeInfo info)
        {
            StartBlock block = new ADStartBlock();
            block.Info = info;
            return block;
        }

        public StepBlock createStepBlock(ShapeInfo info)
        {
            StepBlock block = new ADStepBlock();
            block.Info = info;
            return block;
        }
    }
}
