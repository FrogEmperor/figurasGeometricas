using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace geometricas
{
    abstract class FiguraGeometrica
        //no se pueden hacer instancias, solo herencias
        //es obligatorio hacer override
    {
      
        public int lados { get; }
        public string nombre { get; }
        
        public double posX { get; set; }

        public double posY { get; set; }

        public double dx { get; set; }
        public double dy { get; set; }

        public Brush relleno { get; set; }

        public FiguraGeometrica(int lados, string nombre)
        {
            this.lados = lados;
            this.nombre = nombre;
            
        }

        public FiguraGeometrica(int lados, string nombre, double posX, double posY): this (lados, nombre)
        {
            this.posX = posX;
            this.posY = posY;
        }

        public virtual void Animate(Canvas elCanvas)
        {
            posX += dx;
            posX += dy;
            dibujate(elCanvas);
        }

        public abstract double Perimetro();
        public abstract double area();
        public abstract void dibujate(Canvas miCanvas);
        

    }
}
