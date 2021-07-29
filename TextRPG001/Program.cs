using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum SELECT
{
    selectstart, selecttown, selectfield, Non_select
}


namespace TextRPG001
{
    class Program
    {

        // start
        // go to home or field
        static SELECT Start()
        {
            Console.Clear();
            Console.WriteLine("1. Go Home");
            Console.WriteLine("2. Go Field");
            Console.WriteLine("Where you want to go?");
            // 리턴하게되면 즉시 모든 함수 종료 - 밑에 코드들이 있어도 종료됨
            
            ConsoleKeyInfo CKI = Console.ReadKey();
            Console.WriteLine("");

            switch (CKI.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Going home.");
                    Console.ReadKey();
                    return SELECT.selecttown;
                case ConsoleKey.D2:
                    Console.WriteLine("Start Battle.");
                    Console.ReadKey();
                    return SELECT.selectfield;
                default:
                    Console.WriteLine("Wrong number.");
                    return SELECT.Non_select;
            }

        }
        
        static void Town(Player _player)
        {

            while (true)
            {
                Console.Clear();
                _player.StatusRender();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Restore the HP");
                Console.WriteLine("2. Enhance the weapon");
                Console.WriteLine("3. Leave Town");

                //            Console.ReadKey();
                //            ConsoleKey CK = Console.ReadKey().Key;

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:

                        Console.WriteLine("");
                        Console.Write("Restoring the HP ......");
                        Console.ReadKey();
                        _player.Heal();
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        return;
                }
            }
        }

        static void Field(Player _player)
        {
            //            Console.WriteLine("This field is closed now.");
            //            Console.ReadKey();

            Monster monster1 = new Monster();

            while (true)
            {
                Console.Clear();
                _player.StatusRender();
                monster1.StatusRender();
                Console.ReadKey();
            }
        }


        static void Main(string[] args)
        {
            Player Player1 = new Player();

            while (true)
            {
                SELECT SelectCheck = Start();

                switch (SelectCheck)
                {
                    case SELECT.selecttown:
                        Town(Player1);
                        break;
                    case SELECT.selectfield:
                        Field(Player1);
                        break;
                    default:
                        break;
                }
            }
        }
    }

    class Player
    {
        string Name = "Player";
        int ATK = 10;
        int HP = 50;
        int MaxHP = 100;

        public void Heal()
        {
            if (HP >= MaxHP)
            {
                Console.WriteLine("");
                Console.WriteLine("Player's HP is already full.");
                Console.ReadKey();
            } else
            {
                HP = MaxHP;
                HPStatus();
                return;
            }
        }

        public void StatusRender()
        {
            Console.WriteLine(Name);
            Console.Write("ATK : ");
            Console.WriteLine(ATK);

            Console.Write("HP : ");
            Console.Write(HP);
            Console.Write("/");
            Console.WriteLine(MaxHP);
            Console.WriteLine("---------------------------------");
        }

        public void HPStatus()
        {
            Console.WriteLine("");
            Console.Write("Player's HP is now: {0}",HP);
            Console.ReadKey();
        }
    }

    class Monster
    {
        string Name = "Monster";
        int ATK = 10;
        int HP = 50;
        int MaxHP = 100;

        public void StatusRender()
        {
            Console.WriteLine(Name);
            Console.Write("ATK : ");
            Console.WriteLine(ATK);

            Console.Write("HP : ");
            Console.Write(HP);
            Console.Write("/");
            Console.WriteLine(MaxHP);
            Console.WriteLine("---------------------------------");
        }

    }
}
