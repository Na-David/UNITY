using System;

namespace Overriding2
{
    class FightUnit
    {
        protected string name = "NONE";
        protected int ATK = 10;
        protected int HP;

        public virtual int GetATK()
        {
            Console.WriteLine("FightUnit's ATK");
            return ATK;
        }
        public void Damage(FightUnit _OtherFightUnit)
        {
            int ATK = _OtherFightUnit.GetATK();
            Console.WriteLine(ATK + " damage " + "From " + _OtherFightUnit.name);
            HP -= ATK;
        }
    }

    class Player : FightUnit
    {
        int ItemATK = 5;

        public override int GetATK()
        {
            return ATK + ItemATK;
        }
        public Player(string _Name)
        {
            name = _Name;
        }
    }

    class Monster : FightUnit
    {
        int MonsterLv = 10;

        public override int GetATK()
        {
            return ATK + MonsterLv;
        }
        public Monster(string _Name)
        {
            name = _Name;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player("User");
            Monster newMonster = new Monster("Fly");


            newPlayer.Damage(newMonster);
            newMonster.Damage(newPlayer);
        }
    }
}
