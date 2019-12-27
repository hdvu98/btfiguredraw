using FigureDraw.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Diagram
{
     public interface DiagramFactory
    {
         StartBlock createStartBlock(ShapeInfo info);
         InputBlock createInputBlock(ShapeInfo info);
         HandleBlock createHandleBlock(ShapeInfo info);
         OutputBlock createOutputBlock(ShapeInfo info);
         ConditionBlock createConditionBlock(ShapeInfo info);
         StepBlock createStepBlock(ShapeInfo info);
         EndBlock createEndBlock(ShapeInfo info);
    }
}
