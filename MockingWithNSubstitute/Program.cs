using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MockingWithNSubstitute.Interfaces;

namespace MockingWithNSubstitute
{
    class Program
    {
        private static IBakery _bakery;

        public static void Initialise()
        {
            _bakery = new Bakery();
        }

        static void Main(string[] args)
        {
            Initialise();
             
            Console.WriteLine("Pick a type of dough:");
            Console.WriteLine("1. Hard Dough");
            Console.WriteLine("2. Soft Dough");
            Console.WriteLine();
            
            var choice = Console.ReadLine();
            
            Console.WriteLine("Press a key to start making bread.");
            Console.ReadKey();

            var bread = _bakery.MakeBread(Convert.ToInt16(choice));

            Console.WriteLine("Your bread is ready boss. Press any key to receive");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine(bread.ToString());
            Console.ReadKey();
        }
    }
}
