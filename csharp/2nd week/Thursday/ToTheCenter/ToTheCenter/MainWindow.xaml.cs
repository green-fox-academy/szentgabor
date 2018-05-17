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

namespace ToTheCenter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object foxDraw;

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawLineToCenter(foxDraw);

            // Create a line drawing function that takes 2 parameters:
            // The x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // Draw 3 lines with that function. Use loop for that.
        }

        public static void DrawLineToCenter(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            int[] x = { 300, 400, 500 };
            int[] y = { 200, 500, 300 };
            for (int i = 0; i < 3; i++)
            {
                var startPoint = new Point(x[i], y[i]);
                var endPoint = new Point(400, 225);
                foxDraw.DrawLine(startPoint, endPoint);
            }
        }

    }
}
