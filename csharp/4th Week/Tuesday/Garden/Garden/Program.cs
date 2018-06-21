using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Plant> plants = new List<Plant> {
            new Flower("yellow", 0),
            new Flower("blue", 0),
            new Tree("purple", 0),
            new Tree("orange", 0)
            };

            Garden garden = new Garden();
            garden.Status(plants);

            Console.WriteLine();

            garden.Watering(plants, 40);
            garden.Status(plants);

            Console.WriteLine();

            garden.Watering(plants, 70);
            garden.Status(plants);

            Console.ReadLine();
        }
    }
}
