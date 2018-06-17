using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(50);
            Station station1 = new Station(950);

            Console.WriteLine($"Car1 capacity: {car1.capacity} \nCar1 Gas: {car1.gas} \nStation1 capacity: {station1.capacity} \nStation1 actualgas: {station1.actual}");
            car1.Drive(170);
            Console.WriteLine("Car1 has driven 170km.");
            Console.WriteLine();
            Console.WriteLine($"Car1 capacity: {car1.capacity} \nCar1 Gas: {car1.gas} \nStation1 capacity: {station1.capacity} \nStation1 actualgas: {station1.actual}");
            Console.WriteLine();
            car1.Drive(100);
            Console.WriteLine($"Car1 capacity: {car1.capacity} \nCar1 Gas: {car1.gas} \nStation1 capacity: {station1.capacity} \nStation1 actualgas: {station1.actual}");
            Console.WriteLine();
            station1.Refill(car1);
            Console.WriteLine($"Car1 capacity: {car1.capacity} \nCar1 Gas: {car1.gas} \nStation1 capacity: {station1.capacity} \nStation1 actualgas: {station1.actual}");
            Console.WriteLine();
            try
            {
                car1.Drive(1000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
