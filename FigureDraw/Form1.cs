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

        CommonGraphics gDraw;
        System.Drawing.Graphics gDrawPanelGDI = null;
        System.Drawing.Graphics gDrawPanelCairo = null;
        CommonGraphics gdiPlusDraw = null;
        CommonGraphics cairoDraw = null;
        public ShapeType shapeType;
        public GraphicType graphicType;
        public Effect effectType;
        Boolean isMouseDown = false;
        System.Drawing.Point p1, p2;

        public Form1()
        {
            InitializeComponent();
            gDrawPanelGDI = panel1.CreateGraphics();
            gDrawPanelCairo = panel1.CreateGraphics();
            gdiPlusDraw = new GDIPlusGraphic(gDrawPanelGDI);
            cairoDraw = new CairoGraphic(gDrawPanelCairo);
            gDraw = gdiPlusDraw;
            shapeType = ShapeType.Line;
            effectType = Effect.Default;
        }

        private void drawArea_Paint(object sender, PaintEventArgs e)
        {
            gGDI = drawArea.CreateGraphics();
            gCairo = drawArea.CreateGraphics();
            CommonGraphics g1;
            if (rdbGDI.Checked) { 
                g1 = new GDIPlusGraphic(gGDI);
            }
            else {
                g1 = new CairoGraphic(gCairo);
            }


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
                point1 = new Point(250, 5),
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

        private void rdbHightlight_CheckedChanged(object sender, EventArgs e)
        {
           effectType = Effect.Highlight;
        }

        private void rdbShadow_CheckedChanged(object sender, EventArgs e)
        {
            effectType = Effect.Shadow;
        }

        private void radioDefault_CheckedChanged(object sender, EventArgs e)
        {
            effectType = Effect.Default;
        }

        private void rdbEllipse_CheckedChanged(object sender, EventArgs e)
        {
            shapeType = ShapeType.Elipse;
        }

        private void rdbRectangle_CheckedChanged(object sender, EventArgs e)
        {
            shapeType = ShapeType.Rectangle;
        }

        private void rdbLine_CheckedChanged(object sender, EventArgs e)
        {
            shapeType = ShapeType.Line;
        }

        private void rdbGDI_CheckedChanged(object sender, EventArgs e)
        {
            graphicType = GraphicType.GDI;
            gDraw = gdiPlusDraw;
            label1.Text = "GDI+ Graphics";
            drawArea.Invalidate();
            drawArea.Update();
            drawArea.Refresh();


            panel1.Invalidate();
            panel1.Update();
            panel1.Refresh();
        }

        private void rdbCairo_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Cairo Graphics";
            gDraw = null;
            gDraw = new CairoGraphic(panel1.CreateGraphics());

            graphicType = GraphicType.Cairo;
            drawArea.Invalidate();
            drawArea.Update();
            drawArea.Refresh();

            panel1.Invalidate();
            panel1.Update();
            panel1.Refresh();
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                p1 = new System.Drawing.Point(e.X, e.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseDown && e.Button == MouseButtons.Left)
            {
                p2 = new System.Drawing.Point(e.X, e.Y);
                switch (shapeType)
                {
                    case ShapeType.Line:
                        {
                          
                            Shape line = new Shapes.Line();
                            line.Info = new ShapeInfo
                            {
                                point1 = p1,
                                point2 = p2,
                                color = System.Drawing.Color.Black,
                            };
                            if (effectType == Effect.Shadow)
                            {
                                EffectedShape eff = new ShadowShape();
                                eff.shape = line;
                                eff.draw(gDraw);
                            }
                            else if (effectType == Effect.Highlight)
                            {
                                EffectedShape eff = new HighlightShape();
                                eff.shape = line;
                                eff.draw(gDraw);
                            }
                            else
                            {
                                line.draw(gDraw);
                            }
                            break;
                        }

                    case ShapeType.Rectangle:
                        Shape rect = new Shapes.Rectangle();
                        rect.Info = new ShapeInfo
                        {
                            point1 = p1,
                            width = Math.Abs(p1.X - p2.X),
                            height = Math.Abs(p1.Y - p2.Y),
                            color = Color.Black,
                        };
                        if (effectType == Effect.Shadow)
                        {
                            EffectedShape eff = new ShadowShape();
                            eff.shape = rect;
                            eff.draw(gDraw);
                        }
                        else if (effectType == Effect.Highlight)
                        {
                            EffectedShape eff = new HighlightShape();
                            eff.shape = rect;
                            eff.draw(gDraw);
                        }
                        else
                        {
                            rect.draw(gDraw);
                        }
                        break;

                    case ShapeType.Elipse:
                        Shape ellipse = new Ellipse();
                        ellipse.Info = new ShapeInfo
                        {
                            point1 = p1,
                            width = Math.Abs(p1.X - p2.X),
                            height = Math.Abs(p1.Y - p2.Y),
                        };
                        if (effectType == Effect.Shadow)
                        {
                            EffectedShape eff = new ShadowShape();
                            eff.shape = ellipse;
                            eff.draw(gDraw);
                        }
                        else if (effectType == Effect.Highlight)
                        {
                            EffectedShape eff = new HighlightShape();
                            eff.shape = ellipse;
                            eff.draw(gDraw);
                        }
                        else
                        {
                            ellipse.draw(gDraw);
                        }
                        break;
                    default:
                        break;
                    }
                }
            }
    }
}
