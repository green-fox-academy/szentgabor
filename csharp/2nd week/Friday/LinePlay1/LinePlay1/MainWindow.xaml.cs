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

namespace LinePlay1
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
            

            foxDraw.BackgroundColor(Colors.White);

            int jump = 5;

            CurvedLookingLine1(foxDraw, jump);
            CurvedLookingLine2(foxDraw, jump);

        }
        public static void CurvedLookingLine1(FoxDraw foxDraw, int jump)
        {
            int x1StartingPoint = 0;
            int y1StartingPoint = 0;
            int x2EndingPoint = jump;
            int y2EndingPoint = 450 - jump;
            foxDraw.StrokeColor(Colors.Green);

            for (int i = 0; i < (450); i += jump)
            {
                foxDraw.DrawLine(x1StartingPoint, y1StartingPoint += jump, x2EndingPoint += jump, y2EndingPoint);
            }
        }
        public static void CurvedLookingLine2(FoxDraw foxDraw, int jump, Canvas canvas)
        {
            int x1StartingPoint = 600 - jump;
            int y1StartingPoint = 450 - jump;
            int x2EndingPoint = 600 - 2*jump;
            int y2EndingPoint = jump;
            foxDraw.StrokeColor(Colors.Purple);
            
            {

            }

            for (int i = 0; i < (450); i += jump)
            {
                
                foxDraw.DrawLine(x1StartingPoint, y1StartingPoint += jump, x2EndingPoint += jump, y2EndingPoint);
            }
        }
    }
}

