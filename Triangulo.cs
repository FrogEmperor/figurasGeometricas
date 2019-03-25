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
    class Triangulo : FiguraGeometrica
    {
        public double lado { get; set; }
        Polygon p;

        public Triangulo(double lado) : 
            base(3, "Triangulo Equilatero")
        {
            this.lado = lado;
             p = new Polygon();
            p.Points.Add(new Point(lado / 2, 0));
            p.Points.Add(new Point(0, altura));
            p.Points.Add(new Point(lado, altura));
        }

        public override double area()
        {
            
            return (lado * altura) / 2; ;
        }

        public override double Perimetro()
        {
            return lado * 3;
        }

        public double altura
        {

          get
          {
                double lado2 = lado / 2;
                double suma = Math.Pow(lado, 2) + Math.Pow(lado2, 2);
                double altura = Math.Sqrt(suma);
                return altura;
          }
        }

        public override void dibujate(Canvas miCanvas)
        {
            if (!miCanvas.Children.Contains(p))
            {
                miCanvas.Children.Add(p);
            }           
            Canvas.SetTop(p, posY);
            Canvas.SetLeft(p, posX);
            p.Fill = Brushes.PaleVioletRed;
            p.Stroke = Brushes.Black;
                
        }
    }
}
