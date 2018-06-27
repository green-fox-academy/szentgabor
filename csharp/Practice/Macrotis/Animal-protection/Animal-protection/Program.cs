using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_protection
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalShelter = new AnimalShelter();

            animalShelter.Rescue(new Cat());
            animalShelter.Rescue(new Dog("Furkesz"));
            animalShelter.Rescue(new Parrot());
            Console.WriteLine(animalShelter.ToString());
            // Budget: 50€, There are 3 animal(s) and 0 potential adopter(s)
            // Cat is not healthy (3€) and not adoptable
            // Furkesz is not healthy (1€) and not adoptable
            // Parrot is not healthy (7€) and not adoptable

            animalShelter.Heal();
            Console.WriteLine(animalShelter.ToString());
            // Budget: 47€, There are 3 animal(s) and 0 potential adopter(s)
            // Cat is healthy and adoptable
            // Furkesz is not healthy (1€) and not adoptable
            // Parrot is not healthy (7€) and not adoptable     

            animalShelter.AddAdopter("Kond");
            Console.WriteLine(animalShelter.ToString());
            // Budget: 47€, There are 3 animal(s) and 1 potential adopter(s)
            // Cat is healthy and adoptable
            // Furkesz is not healthy (1€) and not adoptable
            // Parrot is not healthy (7€) and not adoptable

            animalShelter.FindNewOwner();
            animalShelter.EarnDonation(30);
            Console.WriteLine(animalShelter.ToString());
            // Budget: 77€, There are 2 animal(s) and 0 potential adopter(s)
            // Furkesz is not healthy (1€) and not adoptable
            // Parrot is not healthy (7€) and not adoptable

            Console.ReadLine();
        }
    }
}
