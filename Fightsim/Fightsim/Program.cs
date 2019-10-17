using System;
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

            Fighter f1 = new Fighter();

            f1.name = Console.ReadLine();

            Console.WriteLine("Now name yo opponent: ");

            Fighter f2 = new Fighter();

            f2.name = Console.ReadLine();

            while (KillCheckA == true && KillCheckB == true)
            {
                f1.Hurt(f1.Attack());

                Console.WriteLine(f1.name + " health: " + f1.getHp());

                KillCheckA = f1.isAlive();
                KillCheckB = f2.isAlive();

                f2.Hurt(f2.Attack());

                Console.WriteLine(f2.name + " health: " + f2.getHp());

                KillCheckA = f1.isAlive();
                KillCheckB = f2.isAlive();
            }

            if (f1.getHp() > f2.getHp())
            {
                Console.WriteLine("Congratulations " + f1.name + "!");
            }
            else
            {
                Console.WriteLine("Congratulations " + f2.name + "!");
            }

            Console.ReadLine();


        }
    }
}
