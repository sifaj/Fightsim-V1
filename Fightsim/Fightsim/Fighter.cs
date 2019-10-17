using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightsim
{
    class Fighter
    {
        int hp = 100;

        public string name = "";

        static Random generator = new Random(); // En random generator för att slumpa värdet för bl.a hur mycket skada fighter dealar. 


        public int Attack()
        {
            return generator.Next(101); // Returnar ett värde mellan 0 och 100. 
        }

        public void Hurt (int amount)
        {
            hp = hp - amount; // Subtraherar hp med värdet amount.

            if (hp < 0) //Om hp hamnar under 0 korrigeras det till 0.
            {
                hp = 0;
            }
        }

        public bool isAlive()
        {
            if (hp > 0) // Om hp är över 0 returnas true.
            {
                return true;
            }

            else // Om hp är under 0 returnas false.
            {
                return false;
            }

        }

        public int getHp() // Returnar hp.
        {
            return hp;
        }
    }
}
