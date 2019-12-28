using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Common
{
    public enum DiagramType
    {
        FC = 1,
        AD = 2
    }
    public enum DiagramBlock
    {
        Start =1,
        Input = 2,
        Handle = 3,
        Output =4,
        Condition = 5,
        Step = 6,
        End = 7
    }
}
