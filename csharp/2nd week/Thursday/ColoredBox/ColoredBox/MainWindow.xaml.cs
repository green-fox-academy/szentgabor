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

namespace ColoredBox
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
            DrawRectangle(foxDraw);
            // Draw a box that has different colored lines on each edge.
        }
        public static void DrawRectangle(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(5, 5, 5, 55);

            var startPoint = new Point(5, 55);
            var endPoint = new Point(55, 55);
            foxDraw.StrokeColor(Colors.Purple);
            foxDraw.DrawLine(startPoint, endPoint);

            var startPoint2 = new Point(55, 55);
            var endPoint2 = new Point(55, 5);
            foxDraw.StrokeColor(Colors.Yellow);
            foxDraw.DrawLine(startPoint2, endPoint2);

            var startPoint3 = new Point(55, 5);
            var endPoint3 = new Point(5, 5);
            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(startPoint3, endPoint3);
        }
    }
}

