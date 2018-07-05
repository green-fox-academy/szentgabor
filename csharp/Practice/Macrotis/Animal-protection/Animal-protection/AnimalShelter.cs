using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_protection
{
    class AnimalShelter
    {
        double budget;
        List<Animal> animals = new List<Animal>();
        List<string> adopters = new List<string>();

        public double Budget { get => budget; set => budget = value; }

        public AnimalShelter()
        {
            budget = 50;
        }

        public int Rescue(Animal animal)
        {
            animals.Add(animal);
            return animals.Count;
        }

        public int Heal()
        {
            List<Animal> annimals = new List<Animal>();
            for (int i = 0; i < animals.Count; i++)
            {
                if (!animals[i].IsHealthy && Budget > animals[i].HealCost)
                {
                    animals[i].Heal();
                }
                else
                {
                    annimals.Add(animals[i]);
                }
            }

            if (animals.Count == annimals.Count)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public void AddAdopter(string ownerName)
        {
            adopters.Add(ownerName);
        }

        public void FindNewOwner()
        {
            Random rd = new Random();
            List<string> pairs = new List<string>();

            while (animals.Count > 0 && adopters.Count > 0)
            {
                for (int i = 0; i < animals.Count; i++)
                {
                    int n = rd.Next(adopters.Count);
                    int r = rd.Next(animals.Count);
                    // if (n == 0 || r == 0) { break; }
                    if (adopters.Count > 0)
                    {
                    pairs.Add(adopters[n]);
                    adopters.Remove(adopters[n]);
                    pairs.Add(animals[r].ToString());
                    animals.Remove(animals[r]);
                    }
                }
            }
        }

        public double EarnDonation(int donation)
        {
            return Budget += donation;
        }

        public override string ToString()
        {
            string returner = string.Empty;
            foreach (Animal item in animals)
            {
                returner += $"{ item.ToString()}\n";
            }
            returner += $"Budget: {Budget}EUR, There are {animals.Count} animal(s) and {adopters.Count} potential adopter(s)\n";
            return returner;
        }
    }
}
