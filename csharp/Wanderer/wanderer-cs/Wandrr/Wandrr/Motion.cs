using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GreenFox;

namespace Wandrr
{
    public class Motion
    {
        private int posX;
        private int posY;

        public Motion()
        {
            this.posX = 0;
            this.posY = 0;
        }

        public int PosX
        {
            get
            {
                return posX;
            }
        }

        public int PosY
        {
            get
            {
                return posY;
            }
        }

        public void MoveRight()
        {
            posX += 50;
            if (posX > 450)
            {
                posX = 450;
            }
        }
        public void MoveLeft()
        {
            posX -= 50;
            if (posX < 0)
            {
                posX = 0;
            }
        }
        public void MoveUp()
        {
            posY -= 50;
            if (posY < 0)
            {
                posY = 0;
            }
        }
        public void MoveDown()
        {
            posY += 50;
            if (posY > 450)
            {
                posY = 450;
            }
        }
    }
}
