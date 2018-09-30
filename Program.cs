using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program : Gamble
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Roulette Game!");
            Console.Clear();
            Console.WriteLine("The best part about gambling is the adrenaline rush!");
            Console.Clear();
            Console.WriteLine("Will lady luck be on your side or will you go bankrupt??");
            Console.Clear();
            Console.WriteLine("Press 'enter' to continue! ");
            Console.Clear();



            do
            {
                Gamble placegamble = new Gamble();
                placegamble.GambleMethod();
                Console.ReadLine();
                Console.Clear();



            } while (money > 0);
            Console.WriteLine("");
            Console.WriteLine("Hey bud its okay, ya win some ya lose some. Better luck next time!");
            Console.ReadLine();


        
        }

    }
}
