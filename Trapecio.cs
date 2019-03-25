using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows;
using System.Windows.Media;

namespace geometricas
{
    class Trapecio : FiguraGeometrica
    {
        public int baseM { get; set; }
        public int basem { get; set; }
        public int altura { get; set; }
        Polygon t;


        public Trapecio(int baseM, int basem, int altura) : base(4, "Trapecio")
        {
            this.baseM = baseM;
            this.basem = basem;
            this.altura = altura;
            t = new Polygon();
            t.Points.Add(new Point((baseM - basem) / 2 + basem, 0));
            t.Points.Add(new Point((baseM - basem) / 2, 0));
            t.Points.Add(new Point(0, altura));
            t.Points.Add(new Point(baseM, altura));

        }

        public override double area()
        {
            return altura * (baseM + basem) / 2;
        }

        public override void dibujate(Canvas miCanvas)
        {
            if (!miCanvas.Children.Contains(t))
            {
                miCanvas.Children.Add(t);
            }

            Canvas.SetTop(t, posY);
            Canvas.SetLeft(t, posX);
            t.Fill = Brushes.LightSeaGreen;
            t.Stroke = Brushes.Black;
        }
        public override double Perimetro()
        {
            return 2 * Math.Pow(Math.Pow(baseM - basem, 2) + Math.Pow(altura, 2), .5) + baseM + basem;
        }
    }
}
