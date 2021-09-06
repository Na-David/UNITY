using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG001
{
    class Player : FightUnit
    {
        public void Heal()
        {
            if (HP >= MaxHP)
            {
                Console.WriteLine("");
                Console.WriteLine("Player's HP is already full.");
                Console.ReadKey();
            }
            else
            {
                HP = MaxHP;
                HPStatus();
                return;
            }
        }

        public Player()
        {
            Name = "Magician";
        }

        public void HPStatus()
        {
            Console.WriteLine("");
            Console.Write("Player's HP is now: {0}", HP);
            Console.ReadKey();
        }
    }

}
