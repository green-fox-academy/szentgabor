using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpie_AndSet_
{
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie sharpie = new Sharpie("red", 25);
            Sharpie sharpie1 = new Sharpie("grey", 3);

            sharpie.Use();
            Console.WriteLine(sharpie.color);
            Console.WriteLine(sharpie.GetInkStatus());

            SharpieSet sharpieList = new SharpieSet();
            sharpieList.Add(new Sharpie("red", 25));
            sharpieList.Add(new Sharpie("orange", 5));
            sharpieList.Add(new Sharpie("green", 50));
            sharpieList.Add(new Sharpie("red", 75));
            sharpieList.Add(new Sharpie("blue", 75));
            sharpieList.Add(new Sharpie("purple", 25));
            sharpieList.Add(new Sharpie("white", 125));
            sharpieList.Add(new Sharpie("black", 125));
            sharpieList.Add(sharpie);
            sharpieList.Add(sharpie1);

            Console.WriteLine(sharpieList.CountUsable());

            //float kl = sharpie1.inkAmount;
            //for (int i = 0; i < kl; i++)
            //{
            //        sharpie1.Use();
            //}
            while (sharpie1.inkAmount > 0)
            {
                sharpie1.Use();
            }

            Console.WriteLine(sharpie1.GetInkStatus());
            Console.WriteLine(sharpieList.CountUsable());

            sharpieList.Print();
            sharpieList.RemoveTrash();
            sharpieList.Print();

            Console.ReadLine();
        }

    }
}
