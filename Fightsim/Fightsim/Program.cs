﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Fightsim
{
    class Program
    {
        static void Main(string[] args)
        {

            bool KillCheckA = true;
            bool KillCheckB = true;

            Console.WriteLine("WELCOME TO: 'So u want smoke huh?'");
            Thread.Sleep(1000);
            Console.WriteLine("Name yoself:");

            Fighter f1 = new Fighter(); // Skapar en ny Fighter-instans.

            f1.name = Console.ReadLine(); // Spelaren får välja namn.

            Console.WriteLine("Now name yo opponent: ");

            Fighter f2 = new Fighter(); // Skapar en ny Fighter-instans.

            f2.name = Console.ReadLine(); // Spelaren får välja namn.

            while (KillCheckA == true && KillCheckB == true)  // Själva loopen som kör spelet, där f1 och f2 skadar varandra tills en av dem når 0 hp.
            {
                f1.Hurt(f2.Attack()); // f1 förlorar damage 

                Console.WriteLine(f1.name + " health: " + f1.getHp());

                KillCheckA = f1.isAlive(); // KillCheckA/B körs genom metoden isALive(), vilket gör att de kan returnas som false och därmed avlsluta loopen.
                KillCheckB = f2.isAlive();

                f2.Hurt(f1.Attack());

                Console.WriteLine(f2.name + " health: " + f2.getHp());

                KillCheckA = f1.isAlive();
                KillCheckB = f2.isAlive();
            }

            if (f1.getHp() > f2.getHp()) // f1 gratuleras om f2 når 0 hp först.
            {
                Console.WriteLine("Congratulations " + f1.name + "!");
            }
            else // f2 gratuleras om f1 når 0 hp först.
            {
                Console.WriteLine("Congratulations " + f2.name + "!");
            }

            Console.ReadLine();


        }
    }
}
