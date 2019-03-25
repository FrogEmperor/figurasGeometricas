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
    class Diamante : FiguraGeometrica
    {
        public int DiagonalX { get; set;}
        public int DiagonalY { get; set;}
        Polygon d;

        public Diamante(int DiagonalX, int DiagonalY ) : 
            base(4,"Diamante")
        {
            this.DiagonalX = DiagonalX;
            this.DiagonalY = DiagonalY;
            d = new Polygon();
            d.Points.Add(new Point(DiagonalX / 2, 0));
            d.Points.Add(new Point(0, DiagonalY / 2));
            d.Points.Add(new Point(DiagonalX / 2, DiagonalY));
            d.Points.Add(new Point(DiagonalX, DiagonalY / 2));

        }

        public override double area()
        {
            return DiagonalX * DiagonalY;
            
        }

        public override void dibujate(Canvas miCanvas)
        {
            if (!miCanvas.Children.Contains(d))
            {
                miCanvas.Children.Add(d);
            }

           
            Canvas.SetTop(d, posY);
            Canvas.SetLeft(d, posX);
            d.Fill = Brushes.LightSkyBlue;
            d.Stroke = Brushes.Black;
        }

        public override double Perimetro()
        {
            return Math.Pow(Math.Pow(DiagonalX / 2, 2) + Math.Pow(DiagonalY / 2, 2), .5);
        }

    }
}
