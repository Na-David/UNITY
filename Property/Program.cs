using System;

namespace Property
{
    class Player
    {
        int ATK = 10;

        public int HP = 20;

        static int m_StaticValue = 100;
        public static int StaticValue
        {
            get
            {
                return m_StaticValue;
            }

            set
            {
                int a = value;
            }
        }

        public int GetATK()
        {
            return ATK;
        }
        public void SetATK(int _Value)
        {
            if (999 < _Value)
            {
                Console.WriteLine("ATK cannot exceed 999.");
            }
            ATK = _Value;
        }

        public int PropertyATK
        {
            get //must have a return value
            {
                if (999 < ATK)
                {
                    Console.WriteLine("ATK cannot exceed 999.");
                }
                return ATK;
            }
            set // kind of value
            {
                ATK = value;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            //NewPlayer.SetATK(1000);
            int PlayerAT = NewPlayer.PropertyATK;
            Player.StaticValue = 200;

            NewPlayer.HP = 80;

            
        }
    }
}
