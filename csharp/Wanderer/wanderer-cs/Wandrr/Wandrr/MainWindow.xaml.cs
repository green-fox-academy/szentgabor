using System;
using System.Collections.Generic;
using System.IO;
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
using GreenFox;

namespace Wandrr
{
    public partial class MainWindow : Window
    {
        Motion motion = new Motion();

        public MainWindow()
        {
            InitializeComponent();
            MapDraw.foxDraw = new FoxDraw(canvas);
            MapDraw.DrawMap();

            MapDraw.foxDraw.AddImage(@"Assets/hero-down.png", 0, 0);
        }
        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                Console.WriteLine("To the left!");
                canvas.Children.Clear();
                MapDraw.DrawMap();
                if (MapDraw.GetLeftWallPosition(motion) != 1)
                {
                    motion.MoveLeft();
                    MapDraw.foxDraw.AddImage(@"Assets/hero-left.png", motion.PosX, motion.PosY);
                }
                else
                {
                    MapDraw.foxDraw.AddImage(@"Assets/hero-left.png", motion.PosX, motion.PosY);
                }
            }

            if (e.Key == Key.Right)
            {
                Console.WriteLine("To the right!");
                canvas.Children.Clear();
                MapDraw.DrawMap();
                if (MapDraw.GetRightWallPosition(motion) != 1)
                {
                    motion.MoveRight();
                    MapDraw.foxDraw.AddImage(@"Assets/hero-right.png", motion.PosX, motion.PosY);
                }
                else
                {
                    MapDraw.foxDraw.AddImage(@"Assets/hero-right.png", motion.PosX, motion.PosY);
                }
            }
            if (e.Key == Key.Up)
            {
                Console.WriteLine("Up!");
                canvas.Children.Clear();
                MapDraw.DrawMap();
                if (MapDraw.GetUpWallPosition(motion) != 1)
                {
                    motion.MoveUp();
                    MapDraw.foxDraw.AddImage(@"Assets/hero-up.png", motion.PosX, motion.PosY);
                }
                else
                {
                    MapDraw.foxDraw.AddImage(@"Assets/hero-up.png", motion.PosX, motion.PosY);
                }
            }
            if (e.Key == Key.Down)
            {
                Console.WriteLine("Down!");
                canvas.Children.Clear();
                MapDraw.DrawMap();
                if (MapDraw.GetDownWallPosition(motion) != 1)
                {
                    motion.MoveDown();
                    MapDraw.foxDraw.AddImage(@"Assets/hero-down.png", motion.PosX, motion.PosY);
                }
                else
                {
                    MapDraw.foxDraw.AddImage(@"Assets/hero-down.png", motion.PosX, motion.PosY);
                }
            }
        }
    }
}
