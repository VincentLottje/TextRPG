using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = showCityScreen();
            Console.WriteLine(selection);
            Console.ReadLine();
            
        }

        static int showCityScreen()
        {
            Console.WriteLine("Du bist in der Stadt");
            Console.WriteLine("Es gibt:");
            Console.WriteLine("1: Shop");
            Console.WriteLine("2: Gasthaus");
            Console.WriteLine("3: Stadt verlassen");

        
            return Convert.ToInt32(Console.ReadLine());

        }
    }
}
