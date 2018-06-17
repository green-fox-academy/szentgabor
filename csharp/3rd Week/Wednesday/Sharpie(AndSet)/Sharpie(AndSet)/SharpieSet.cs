using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpie_AndSet_
{
    class SharpieSet
    {
        List<Sharpie> SharpieList = new List<Sharpie>();

        public void Add(Sharpie sharpie)
        {
            SharpieList.Add(sharpie);
        }

        public int CountUsable()
        {
            int usable = 0;
            for (int i = 0; i < SharpieList.Count; i++)
            {
                if (SharpieList[i].inkAmount > 0)
                {
                    usable++;
                }
            }
            return usable;
        }

        public void RemoveTrash()
        {
            for (int i = 0; i < SharpieList.Count; i++)
            {
                if (SharpieList[i].inkAmount == 0)
                {
                    SharpieList.RemoveAt(i);
                    i--;
                }
            }
        }

        public void Print()
        {
            foreach (Sharpie item in SharpieList)
            {
                Console.WriteLine($"{ item.GetInkStatus()}");
            }
        }
    }
}
