using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProyect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-What is your name?.."); // Show message on console
                String name = Console.ReadLine(); // Save what the user write in a var
            Console.WriteLine("");
            Console.WriteLine("Welcome " + name + "!!");
            Console.WriteLine("");
            Console.WriteLine("Press any key to finish...");
            Console.ReadKey();
        }
    }
}
