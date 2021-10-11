using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{

    class FightUnit
    {
        protected string name = "NONE";
        protected int ATK;
        protected int HP;
        public void Damage(FightUnit _OtherFightUnit)
        {
            Console.WriteLine( _OtherFightUnit.ATK + "damaged" + "From" + _OtherFightUnit.name );
            HP -= _OtherFightUnit.ATK;
        }
    }

    class Player : FightUnit
    {
        int ItemATK = 5;

        public Player(string _Name)
        {
            name = _Name;
        }
    }

    class Monster : FightUnit
    {

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
        }
    }
}
