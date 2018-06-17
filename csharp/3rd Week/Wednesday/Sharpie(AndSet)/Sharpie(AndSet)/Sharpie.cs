using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpie_AndSet_
{
    class Sharpie
    {
        public string color;
        public float width;
        public float inkAmount;

        public Sharpie(string color, float width)
        {
            this.color = color;
            this.width = width;
            inkAmount = 100;
        }

        public void Use()
        {
            if (inkAmount == 0)
            {
                throw new Exception("e");
            }
                inkAmount--;
        }

        public float GetInkStatus()
        {
            return inkAmount;
        }
    }
}
