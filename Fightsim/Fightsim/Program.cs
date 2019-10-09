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
            Console.WriteLine("WELCOME TO: 'So u want smoke huh?'");
            Thread.Sleep(1000);
            Console.WriteLine("Name yoself:");

            Fighter f1 = new Fighter();

            f1.name = Console.ReadLine();

            Console.WriteLine("Now name yo opponent: ");

            Fighter f2 = new Fighter();

            f2.name = Console.ReadLine();
        }
    }
}
