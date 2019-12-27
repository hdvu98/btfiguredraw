using FigureDraw.Common;
using FigureDraw.Diagram.ActivityDiagram;
using FigureDraw.Diagram.FlowChart;
using FigureDraw.Effects;
using FigureDraw.Graphics;
using FigureDraw.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureDraw
{
    public partial class Form1 : Form
    {
        System.Drawing.Graphics gGDI = null;
        System.Drawing.Graphics gCairo = null;
  
        CommonGraphics gdiPlus = null;
        CommonGraphics cairo = null;
        Shape shape = null;
        List<Shape> shapes = new List<Shape>();

        public Form1()
        {
            InitializeComponent();
        }

        private void drawArea_Paint(object sender, PaintEventArgs e)
        {
            gGDI = drawArea.CreateGraphics();
            gCairo = drawArea.CreateGraphics();
            Shape regtangleDemo = new Shapes.Rectangle();
            //regtangleDemo.Info = new ShapeInfo {
            //    point1 = new Point(10, 10),
            //    width = 50,
            //    height = 20
            //};
            //regtangleDemo.draw(new GDIPlusGraphic(gGDI));

            //Shape lineDemo = new Shapes.Line();
            //lineDemo.Info = new ShapeInfo
            //{
            //    point1 = new Point(10, 50),
            //    point2 = new Point(60, 40)
            //};
            //lineDemo.draw(new GDIPlusGraphic(gGDI));

            //Shape ellipseDemo = new Shapes.Ellipse();
            //ellipseDemo.Info = new ShapeInfo
            //{
            //    point1 = new Point(10, 60),
            //    width = 50,
            //    height = 20
            //};
            //ellipseDemo.draw(new GDIPlusGraphic(gGDI));

            //Shape ellipseDemo3 = new Shapes.Ellipse();
            //ellipseDemo3.Info = new ShapeInfo
            //{
            //    point1 = new Point(10, 90),
            //    width = 50,
            //    height = 20
            //};
            //ellipseDemo3.draw(new CairoGraphic(gCairo));

            //Diagram.DiagramFactory factory = new ADFactory();
            //ShapeInfo info = new ShapeInfo();
            //info.point1 = new Point(10, 10);
            //info.width = 10;
            //info.height = 20;
            //Diagram.Diagram dia = new Diagram.Diagram();
            //dia.Info = new ShapeInfo
            //{
            //    point1 = new Point(10, 10),
            //    width = 100,
            //    height = 50
            //};
            //dia.add(factory);
            //dia.draw(new CairoGraphic(gCairo));

            Shape ellipseDemo3 = new Shapes.Ellipse();
            ellipseDemo3.Info = new ShapeInfo
            {
                point1 = new Point(10, 90),
                width = 50,
                height = 20
            };
            EffectedShape effShapeelipse = new ShadowShape();
            effShapeelipse.shape = ellipseDemo3;
            effShapeelipse.draw(new CairoGraphic(gCairo));

        }
    }
}
