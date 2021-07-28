using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG001
{
    class Program
    {
        static int TenReturn() 
        { 
            return 10; 
        }

        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKeyInfo KeyInfo = Console.ReadKey();
                Console.WriteLine(KeyInfo.Key);
            }
        }
    }

    class Player
    {

    }

    class Monster
    {

    }
}
