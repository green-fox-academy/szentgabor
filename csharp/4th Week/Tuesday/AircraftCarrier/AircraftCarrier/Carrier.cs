using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrier
{
    class Carrier
    {
        List<Aircraft> aircraftList = new List<Aircraft>();
        int ammo;
        int healthPoint;

        public int Ammo { get => ammo; set => ammo = value; }

        public Carrier(List<Aircraft> aircraftList)
        {
            this.aircraftList = aircraftList;
            ammo = 500;
            healthPoint = 2450;
        }

        public void Add(Aircraft aircraft)
        {
            aircraftList.Add(aircraft);
        }

        public void Fill()
        {
            if (ammo == 0)
            {
                throw new Exception("no ammo, no refill");
            }

            foreach (Aircraft item in aircraftList)
            {
                if (item.IsPriority())
                {
                    ammo = item.Refill(ammo);
                }
            }

            foreach (Aircraft item in aircraftList)
            {
                if (!item.IsPriority())
                {
                    ammo = item.Refill(ammo);
                }
            }
        }

        public int Fight(Carrier carrier)
        {
            int damageDealt = 0;
            foreach (Aircraft item in aircraftList)
            {
                carrier.healthPoint -= item.Fight();
                damageDealt += item.Fight();
            }

            if (carrier.healthPoint < 0)
            {
                carrier.healthPoint = 0;
            }
            return damageDealt;
        }

        public string GetStatus()
        {
            if (healthPoint != 0)
            {
                int totalStrikeForce = 0;
                foreach (Aircraft item in aircraftList)
                {
                    totalStrikeForce += item.Ammo * item.BaseDamage;
                }
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append($"HP: {healthPoint}, Aircraft count: {aircraftList.Count}, Ammo Storage: {ammo}, Total striking force: {totalStrikeForce}\nAircrafts:\n");
                foreach (Aircraft item in aircraftList)
                {
                    stringBuilder.Append(item.GetStatus()).Append("\n");
                }
                return stringBuilder.ToString();
            }
            else
            {
                return $"It's sank, Jim.";
            }
        }
    }
}
