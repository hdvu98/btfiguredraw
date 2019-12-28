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
            CommonGraphics g1 = new GDIPlusGraphic(gGDI);


            //Activity Diagram
            Diagram.DiagramFactory factory = new ADFactory();

            Diagram.Diagram ad = new Diagram.Diagram();
            ad.Info = new ShapeInfo
            {
                point1 = new Point(170, 10),
                width = 20,
                height = 20
            };
            ad.add(DiagramBlock.Start, factory);
            ad.Info = new ShapeInfo
            {
                point1 = new Point(150, 40),
                width = 60,
                height = 30
            };
            ad.add(DiagramBlock.Input, factory);

            ad.Info = new ShapeInfo
            {
                point1 = new Point(145, 80),
                width = 70,
                height = 30
            };
            ad.add(DiagramBlock.Handle, factory);

            ad.Info = new ShapeInfo
            {
                point1 = new Point(150, 120),
                width = 60,
                height = 30
            };
            ad.add(DiagramBlock.Output, factory);

            ad.Info = new ShapeInfo
            {
                point1 = new Point(150, 160),
                width = 60,
                height = 30
            };
            ad.add(DiagramBlock.Condition, factory);

            ad.Info = new ShapeInfo
            {
                point1 = new Point(150, 200),
                width = 60,
                height = 30
            };
            ad.add(DiagramBlock.Step, factory);

            ad.Info = new ShapeInfo
            {
                point1 = new Point(170, 220),
                width = 20,
                height = 20
            };
            ad.add(DiagramBlock.End, factory);

            ad.draw(g1);

            //Flow Chart Diagram

            Diagram.DiagramFactory FCfactory = new FCFactory();

            Diagram.Diagram fc = new Diagram.Diagram();
            fc.Info = new ShapeInfo
            {
                point1 = new Point(250, 10),
                width = 50,
                height = 20
            };
            fc.add(DiagramBlock.Start, FCfactory);
            fc.Info = new ShapeInfo
            {
                point1 = new Point(250, 40),
                width = 60,
                height = 30
            };
            fc.add(DiagramBlock.Input, FCfactory);

            fc.Info = new ShapeInfo
            {
                point1 = new Point(250, 80),
                width = 70,
                height = 30
            };
            fc.add(DiagramBlock.Handle, FCfactory);

            fc.Info = new ShapeInfo
            {
                point1 = new Point(250, 120),
                width = 60,
                height = 30
            };
            fc.add(DiagramBlock.Output, FCfactory);

            fc.Info = new ShapeInfo
            {
                point1 = new Point(250, 160),
                width = 60,
                height = 30
            };
            fc.add(DiagramBlock.Condition, FCfactory);

            fc.Info = new ShapeInfo
            {
                point1 = new Point(250, 200),
                width = 60,
                height = 30
            };
            fc.add(DiagramBlock.Step, FCfactory);

            fc.Info = new ShapeInfo
            {
                point1 = new Point(250, 220),
                width = 50,
                height = 20
            };
            fc.add(DiagramBlock.End, FCfactory);

            fc.draw(g1);

            Shape regtangleDemo = new Shapes.Rectangle();
            regtangleDemo.Info = new ShapeInfo
            {
                point1 = new Point(10, 10),
                width = 100,
                height = 50
            };
            regtangleDemo.draw(g1);

            Shape lineDemo = new Shapes.Line();
            lineDemo.Info = new ShapeInfo
            {
                point1 = new Point(10, 70),
                point2 = new Point(110, 70)
            };
            lineDemo.draw(g1);

            Shape ellipseDemo = new Shapes.Ellipse();
            ellipseDemo.Info = new ShapeInfo
            {
                point1 = new Point(10, 80),
                width = 100,
                height = 50
            };
            ellipseDemo.draw(g1);

            Shape ellipseDemo3 = new Shapes.Ellipse();
            ellipseDemo3.Info = new ShapeInfo
            {
                point1 = new Point(10, 140),
                width = 100,
                height = 50
            };
            EffectedShape effShapeelipse = new HighlightShape();
            effShapeelipse.shape = ellipseDemo3;
            effShapeelipse.draw(g1);

            Shape reg = new Shapes.Rectangle();
            reg.Info = new ShapeInfo
            {
                point1 = new Point(10, 200),
                width = 100,
                height = 50
            };
            EffectedShape regShadow = new ShadowShape();
            regShadow.shape = reg;
            regShadow.draw(g1);

        }
    }
}
