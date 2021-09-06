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
        
        static SELECT Town(Player _player)
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
                        return SELECT.Non_select;
                }
            }
        }

        static SELECT Field(Player _player)
        {
            //            Console.WriteLine("This field is closed now.");
            //            Console.ReadKey();

            Monster monster1 = new Monster("Pig");

            // fight until anyone die
            while (monster1.IsDead() == false && _player.IsDead() == false)
            {
                Console.Clear();
                _player.StatusRender();
                monster1.StatusRender();

                monster1.Damage(_player);
                if (monster1.IsDead() == false)
                {
                    _player.Damage(monster1);
                }

            }


            Console.WriteLine("Battle has been completed");

            if (monster1.IsDead() == true)
            {
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine("Defeated");
            }
            Console.ReadKey();
            return SELECT.selecttown;
        }


        static void Main(string[] args)
        {
            Player Player1 = new Player();

            SELECT SelectCheck = Start();


            while (true)
            {
                switch (SelectCheck)
                {
                    case SELECT.selecttown:
                        SelectCheck = Town(Player1);
                        break;
                    case SELECT.selectfield:
                        SelectCheck = Field(Player1);
                        break;
                    case SELECT.Non_select:
                        SelectCheck = Start();
                        break;
                    default:
                        break;
                }
            }
        }
    }






}
