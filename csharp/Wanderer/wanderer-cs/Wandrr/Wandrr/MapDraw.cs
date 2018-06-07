using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace Wandrr
{
    class MapDraw
    {
        public static FoxDraw foxDraw;
        public static void DrawMap()
        {
            List<String> lines = new List<string>(
            File.ReadAllLines(@"C:\AG\Green Fox Academy\szentgabor\csharp\Wanderer\wanderer-cs\Wandrr\Wandrr\BlocksList.txt"));


            for (int i = 0; i < lines.Count; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    if (lines[i][j] == '1')
                    {
                        foxDraw.AddImage(@"Assets/wall.png", i * 50, j * 50);
                    }
                    else if (lines[i][j] == '0')
                    {
                        foxDraw.AddImage(@"Assets/floor.png", i * 50, j * 50);
                    }
                }
            }
        }
        public static int GetLeftWallPosition(Motion motion)
        {
            int[,] walls = new int[10, 10] {
                { 0,0,0,1,0,1,0,0,0,0 },
                { 0,0,0,1,0,1,0,1,1,0 },
                { 0,1,1,1,0,1,0,1,1,0 },
                { 0,0,0,0,0,1,0,0,0,0 },
                { 1,1,1,1,0,1,1,1,1,0 },
                { 0,1,0,1,0,0,0,0,1,0 },
                { 0,1,0,1,0,1,1,0,1,0 },
                { 0,0,0,0,0,1,1,0,1,0 },
                { 0,1,1,1,0,0,0,0,1,0 },
                { 0,0,0,1,0,1,1,0,0,0 }
            };
            int a = (motion.PosX - 50) / 50;
            int b = motion.PosY / 50;
            int k = 0;
            for (int i = 0; i < walls.Length; i++)
            {
                for (int j = 0; j < walls.Length; j++)
                {
                    if (i == a && j == b)
                    {
                        k = walls[i, j];
                    }
                }
            }
            return k;
        }
        public static int GetRightWallPosition(Motion motion)
        {
            int[,] walls = new int[10, 10] {
                { 0,0,0,1,0,1,0,0,0,0 },
                { 0,0,0,1,0,1,0,1,1,0 },
                { 0,1,1,1,0,1,0,1,1,0 },
                { 0,0,0,0,0,1,0,0,0,0 },
                { 1,1,1,1,0,1,1,1,1,0 },
                { 0,1,0,1,0,0,0,0,1,0 },
                { 0,1,0,1,0,1,1,0,1,0 },
                { 0,0,0,0,0,1,1,0,1,0 },
                { 0,1,1,1,0,0,0,0,1,0 },
                { 0,0,0,1,0,1,1,0,0,0 }
            };
            int a = (motion.PosX + 50) / 50;
            int b = motion.PosY / 50;
            int k = 0;
            for (int i = 0; i < walls.Length; i++)
            {
                for (int j = 0; j < walls.Length; j++)
                {
                    if (i == a && j == b)
                    {
                        k = walls[i, j];
                    }
                }
            }
            return k;
        }
        public static int GetDownWallPosition(Motion motion)
        {
            int[,] walls = new int[10, 10] {
                { 0,0,0,1,0,1,0,0,0,0 },
                { 0,0,0,1,0,1,0,1,1,0 },
                { 0,1,1,1,0,1,0,1,1,0 },
                { 0,0,0,0,0,1,0,0,0,0 },
                { 1,1,1,1,0,1,1,1,1,0 },
                { 0,1,0,1,0,0,0,0,1,0 },
                { 0,1,0,1,0,1,1,0,1,0 },
                { 0,0,0,0,0,1,1,0,1,0 },
                { 0,1,1,1,0,0,0,0,1,0 },
                { 0,0,0,1,0,1,1,0,0,0 }
            };
            int a = motion.PosX / 50;
            int b = (motion.PosY + 50) / 50;
            int k = 0;
            for (int i = 0; i < walls.Length; i++)
            {
                for (int j = 0; j < walls.Length; j++)
                {
                    if (i == a && j == b)
                    {
                        k = walls[i, j];
                    }
                }
            }
            return k;
        }
        public static int GetUpWallPosition(Motion motion)
        {
            int[,] walls = new int[10, 10] {
                { 0,0,0,1,0,1,0,0,0,0 },
                { 0,0,0,1,0,1,0,1,1,0 },
                { 0,1,1,1,0,1,0,1,1,0 },
                { 0,0,0,0,0,1,0,0,0,0 },
                { 1,1,1,1,0,1,1,1,1,0 },
                { 0,1,0,1,0,0,0,0,1,0 },
                { 0,1,0,1,0,1,1,0,1,0 },
                { 0,0,0,0,0,1,1,0,1,0 },
                { 0,1,1,1,0,0,0,0,1,0 },
                { 0,0,0,1,0,1,1,0,0,0 }
            };
            int a = motion.PosX / 50;
            int b = (motion.PosY - 50) / 50;
            int k = 0;
            for (int i = 0; i < walls.Length; i++)
            {
                for (int j = 0; j < walls.Length; j++)
                {
                    if (i == a && j == b)
                    {
                        k = walls[i, j];
                    }
                }
            }
            return k;
        }
    }
}