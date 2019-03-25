using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Windows.Threading;

namespace geometricas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<FiguraGeometrica> figuritas;
        Random rnd;
        DispatcherTimer elTimer;

        public MainWindow()
        {
            InitializeComponent();
            figuritas = new List<FiguraGeometrica>();
            rnd = new Random();
            elTimer = new DispatcherTimer();
            elTimer.Interval = new TimeSpan(0, 0, 1);
            elTimer.Tick += MueveFiguras;
        }

        private void MueveFiguras(object sender, EventArgs e)
        {
            foreach (var figura in figuritas)
            {
                figura.Animate(elCanvas);
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < 100; i++)
            {
                int figura = rnd.Next(0, 5);

                if (figura == 0)
                {
                    int radio = rnd.Next(10, 21);
                    circulo l = new circulo(radio);
                    l.posX = rnd.Next(0, 983 - radio * 2);
                    l.posY = rnd.Next(0, 413 - radio * 2);
                    figuritas.Add(l);
                }
                else if (figura == 1)
                {
                    int lado = rnd.Next(10, 50);
                    Triangulo l = new Triangulo(lado);
                    l.posX = rnd.Next(0, 983 - lado);
                    l.posY = rnd.Next(0, 413 - (int)l.altura);
                    figuritas.Add(l);
                }
                else if (figura == 2)
                {
                    int altura = rnd.Next(10, 50);
                    int _base = rnd.Next(10, 100);
                    Rectangulo rec = new Rectangulo(_base, altura);
                    rec.posX = rnd.Next(0, 983 - _base);
                    rec.posY = rnd.Next(0, 413 - altura);
                    figuritas.Add(rec);
                }
                else if (figura == 3)
                {
                    int dx = rnd.Next(10, 50);
                    int dy = rnd.Next(10, 50);
                    Diamante d = new Diamante(dx, dy);
                    d.posX = rnd.Next(0, 983 - dx);
                    d.posY = rnd.Next(0, 413 - dy);
                    figuritas.Add(d);
                }
                else if (figura == 4)
                {
                    int bM = rnd.Next(11, 50);
                    int bm = rnd.Next(5, bM - 5);
                    int altura = rnd.Next(10, bM);
                    Trapecio d = new Trapecio(bM, bm, altura);
                    d.posX = rnd.Next(0, 983 - bM);
                    d.posY = rnd.Next(0, 413 - altura);
                    figuritas.Add(d);
                }
                figuritas[i].dx = rnd.Next(-3, 4);
                figuritas[i].dy = rnd.Next(-3, 4);
                figuritas[i].relleno = new SolidColorBrush(Color.FromRgb( (byte)rnd.Next(256) , (byte)rnd.Next(256) , (byte)rnd.Next(256)));
            }
            DibujaTodas();
            elTimer.Start();
            }
            public void DibujaTodas()
            {
                foreach (var figura in figuritas)
                {
                figura.Animate(elCanvas);
                    figura.dibujate(elCanvas);
                }
            }
        }
    }
