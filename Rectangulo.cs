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
    class Rectangulo : FiguraGeometrica

    {
        public double _base { get; set; }

        public double altura { get; set; }

        Rectangle r;

        public Rectangulo (int _base, int altura):
            base (4, "Rectangulo")
        {
            this._base = _base;
            this.altura = altura;
             r = new Rectangle();
            r.Height = altura;
            r.Width = _base;
        }
        public override double area()
        {
            return _base * altura;
        }

        public override double Perimetro()
        {
            return (2 * _base) + (2 * altura);
        }

        public override void dibujate(Canvas miCanvas)
        {
            if (!miCanvas.Children.Contains(r))
            {
                miCanvas.Children.Add(r);
            }            
           

            Canvas.SetTop(r, posY);
            Canvas.SetLeft(r, posX);

            r.Fill = Brushes.LightCoral;
            r.Stroke = Brushes.Black;
        }
    }
}
// dibujar figuras rectangulo, circulo, triangulo trapecio diamante
// figuras al azar en posiciones al azar
