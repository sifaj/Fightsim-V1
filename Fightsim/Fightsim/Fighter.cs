using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightsim
{
    class Fighter
    {
        int hp = 0;

        public string name = "";

        Random generator = new Random(); // En random generator för att slumpa värdet för bl.a hur mycket skada fighter dealar


        public int Attack()
        {
            return generator.Next(100);
        }

        public void Hurt (int amount)
        {

        }

        public bool isAlive()
        {

        }

        public int getHp()
        {

        }
    }
}
