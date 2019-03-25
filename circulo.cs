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
    class circulo : FiguraGeometrica
    {
        public double radio { get; set; }
        Ellipse c;
        

        public circulo(int radio):
            base(1, "Circulo")
        {
            this.radio = radio;
            c = new Ellipse();
            c.Width = 2 * radio;
            c.Height = 2 * radio;

        }
        public override double Perimetro()
        {
            return 2 * Math.PI * radio;
        }

        public override double area()
        {
            return Math.PI * radio * radio;
        }

        public override void dibujate(Canvas miCanvas)
        {
            if(!miCanvas.Children.Contains(c))
            {
                miCanvas.Children.Add(c);
            }
            
           
            Canvas.SetTop(c, posY);
            Canvas.SetLeft(c, posX);
            c.Fill = relleno;
            c.Stroke = Brushes.Black;
           
        }
    }
}
