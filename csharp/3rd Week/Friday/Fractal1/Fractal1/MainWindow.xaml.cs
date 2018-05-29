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

namespace Fractal1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.FillColor(Colors.White);
            foxDraw.BackgroundColor(Colors.Green);
            foxDraw.StrokeColor(Colors.Black);
            double x = 0;
            double y = 0;
            double baseSide = canvas.Width;
            DrawTriangles(foxDraw);
        }
            public static void DrawTriangles(FoxDraw foxDraw)
            {
            // var points = new List<Point>();
            // points.Add(new Point(250, 0));
            // points.Add(new Point(450, 0));
            // points.Add(new Point(350, 173));
            // foxDraw.FillColor(Colors.White);
            // foxDraw.DrawPolygon(points);

            var aPoint = new Point(250, 5);
            var bPoint = new Point(450, 5);
            var cPoint = new Point(350, 178);
            foxDraw.FillColor(Colors.White);
            foxDraw.DrawLine(aPoint, bPoint);
            foxDraw.DrawLine(bPoint, cPoint);
            foxDraw.DrawLine(cPoint, aPoint);

            var halverA = new Point((aPoint.X + bPoint.X) / 2, (aPoint.Y + bPoint.Y) / 2);
            var halverB = new Point((bPoint.X + cPoint.X) / 2, (bPoint.Y + cPoint.Y) / 2);
            var halverC = new Point((cPoint.X + aPoint.X) / 2, (cPoint.Y + aPoint.Y) / 2);
            foxDraw.DrawLine(halverA, halverB);
            foxDraw.DrawLine(halverB, halverC);
            foxDraw.DrawLine(halverC, halverA);

            public static void DrawMoreTriangles(FoxDraw foxDraw, Point a, Point b, Point c)
            {
                if ()
                    //ha egy pont == két ismert pont felezőpontja, akkor onnan draw triangle-t (az új háromszög pontjai koordinátáinak meghatározásához is valahogy a már ismert pontokat hasznáni), ezt háromszor a három irányba, majd ugyanezt visszahívni (erre lehet, be kell vezetni három új változót, amik átíródnak az új koordinátákká minden körbefutás után.)
            }
                }
        }
    }