using System;
using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace RainbowBoxes
{
    public partial class MainWindow : Window
    {
        int i;
        int difference = 20;

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Create a square drawing function that takes 2 parameters:
            // The square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares,
            // all squares should be centered, but growing in size

            int size;
            string color;
            string colorB = "black";
            string[] colors = new string[] { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };

            //for (i = 0; i < (int)Height / difference; i++)
            //{
            //    size = (int)Height - (i * difference);
            //    color = colors[i % colors.Length];
            //    SquareDrawing(size, color);
            //}

            //for (i = 0; i < (int)Height / difference; i++)
            //{
            //    size = (int)Height - (i * difference);

            //    if ((0 <= i) && (i < 6))
            //    {
            //        color = colors[0];
            //        SquareDrawing(size, color);
            //    }

            //    if ((6 <= i) && (i < 12))
            //    {
            //        color = colors[1];
            //        SquareDrawing(size, color);
            //    }

            //    if ((12 <= i) && (i < 18))
            //    {
            //        color = colors[2];
            //        SquareDrawing(size, color);
            //    }

            //    if ((18 <= i) && (i < 24))
            //    {
            //        color = colors[3];
            //        SquareDrawing(size, color);
            //    }

            //    if ((24 <= i) && (i < 30))
            //    {
            //        color = colors[4];
            //        SquareDrawing(size, color);
            //    }

            //    if ((30 <= i) && (i < 36))
            //    {
            //        color = colors[5];
            //        SquareDrawing(size, color);
            //    }

            //    if (36 <= i)
            //    {
            //        color = colors[6];
            //        SquareDrawing(size, color);
            //    }
            //}

            //for (i = 0; i < (int)Height / difference; i++)
            //{
            //    size = (int)Height - (i * difference);

            //    if (i < 6)
            //    {
            //        color = colors[0];
            //        SquareDrawing(size, color);
            //    }

            //    else if (i < 12)
            //    {
            //        color = colors[1];
            //        SquareDrawing(size, color);
            //    }

            //    else if (i < 18)
            //    {
            //        color = colors[2];
            //        SquareDrawing(size, color);
            //    }

            //    else if (i < 24)
            //    {
            //        color = colors[3];
            //        SquareDrawing(size, color);
            //    }

            //    else if (i < 30)
            //    {
            //        color = colors[4];
            //        SquareDrawing(size, color);
            //    }

            //    else if (i < 36)
            //    {
            //        color = colors[5];
            //        SquareDrawing(size, color);
            //    }

            //    else
            //    {
            //        color = colors[6];
            //        SquareDrawing(size, color);
            //    }
            //}

            //for (i = 0; i < (int)Height / difference; i++)
            //{
            //    size = (int)Height - (i * difference);

            //    int amountOfBoxesWithSameColor = ((int)Height / difference) / colors.Length;

            //    for (int j = 0; j < colors.Length; j++)
            //    {
            //        if ((j * amountOfBoxesWithSameColor <= i) && (i < (j + 1) * amountOfBoxesWithSameColor))
            //        {
            //            color = colors[j];
            //            SquareDrawing(size, color);
            //        }
            //    }
            //}

            //for (i = 0; i < (int)Height / difference; i++)
            //{
            //    size = (int)Height - (i * difference);

            //    if (i % 2 == 0)
            //    {
            //        color = colors[i % colors.Length];
            //        SquareDrawing(size, color);
            //    }

            //    else
            //    {
            //        color = colorB;
            //        SquareDrawing(size, color);
            //    }
            //}

            for (i = 0; i < (int)Height / difference; i++)
            {
                size = (int)Height - (i * difference);

                int amountOfBoxesWithSameColor = ((int)Height / difference) / colors.Length;

                for (int j = 0; j < colors.Length; j++)
                {
                    if ((j * amountOfBoxesWithSameColor <= i) && (i < (j + 1) * amountOfBoxesWithSameColor))
                    {
                        if (i % 3 == 0)
                        {
                            color = colorB;
                            SquareDrawing(size, color);
                        }

                        else
                        {
                            color = colors[j];
                            SquareDrawing(size, color);
                        }
                    }
                }
            }
        }

        public void SquareDrawing(int sizeB, string colorB)
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            Color fillColor = (Color)ColorConverter.ConvertFromString(colorB);
            foxDraw.FillColor(fillColor);

            foxDraw.DrawRectangle((i * difference) / 2, (i * difference) / 2, sizeB, sizeB);
        }
    }
}
