using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrier
{
    class Program
    {
        static void Main(string[] args)
        {
            F16 fighter1 = new F16();
            F16 fighter2 = new F16();
            F16 fighter3 = new F16();
            F35 fighter4 = new F35();
            F35 fighter5 = new F35();
            F35 fighter6 = new F35();

            List<Aircraft> aircrafts1 = new List<Aircraft> { fighter1, fighter2, fighter3};
            List<Aircraft> aircrafts2 = new List<Aircraft> { fighter4, fighter5, fighter6 };

            Carrier carrier1 = new Carrier(aircrafts1);
            Carrier carrier2 = new Carrier(aircrafts2);

            //foreach (Aircraft item in aircrafts2)
            //{
            //    Console.WriteLine(item.GetStatus());
            //}
            Console.WriteLine();
            Console.WriteLine(carrier1.GetStatus());
            // Console.WriteLine(carrier2.GetStatus());

            Console.WriteLine(fighter1.Refill(5));

            Console.WriteLine();

            Console.WriteLine(carrier2.GetStatus());
            
            F35 fighter7 = new F35();

            carrier2.Add(fighter7);
            carrier2.Fill();
            carrier1.Fill();

            Console.WriteLine();

            Console.WriteLine(carrier1.GetStatus());
            Console.WriteLine(carrier2.GetStatus());

            carrier2.Fight(carrier1);

            Console.WriteLine(carrier1.GetStatus());
            Console.WriteLine(carrier2.GetStatus());

            carrier1.Fight(carrier2);
            carrier2.Fill();

            Console.WriteLine(carrier1.GetStatus());
            Console.WriteLine(carrier2.GetStatus());

            carrier2.Fight(carrier1);

            Console.WriteLine(carrier1.GetStatus());
            Console.WriteLine(carrier2.GetStatus());

            Console.ReadLine();
        }
    }
}
