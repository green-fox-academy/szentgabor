using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrier
{
    abstract class Aircraft
    {
        int ammo;
        int ammoCapacity;
        int baseDamage;

        public int Ammo { get => ammo; set => ammo = value; }
        public int AmmoCapacity { get => ammoCapacity; set => ammoCapacity = value; }
        public int BaseDamage { get => baseDamage; set => baseDamage = value; }

        public Aircraft(int ammoCapacity, int baseDamage)
        {
            Ammo = 0;
            AmmoCapacity = ammoCapacity;
            BaseDamage = baseDamage;
        }

        public int Fight()
        {
            int damageDealt = baseDamage * ammo;
            ammo = 0;
            return damageDealt;
        }

        public int Refill(int fill)
        {
            if (fill >= AmmoCapacity - Ammo)
            {
                fill -= (AmmoCapacity - Ammo);
                Ammo = AmmoCapacity;
                Console.WriteLine(Ammo);
            }
            else
            {
                Ammo += fill;
                Console.WriteLine(Ammo);
                fill = 0;
            }
                return fill;
        }

        public string GetAircraftType()
        {
            return GetType().ToString();
        }

        public string GetStatus()
        {
            string status = $"Type : {GetType().Name}, ammo: {Ammo}, Base Damage: {baseDamage}, Strike Force: {Ammo * BaseDamage}";
            return status;
        }

        public bool IsPriority()
        {
            return this is F35;
        }
    }
}
