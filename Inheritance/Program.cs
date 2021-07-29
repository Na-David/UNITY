using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Fight
{
    protected int ATK = 10;
    protected int HP = 100;

    public void Damage(Fight _OtherUnit)
    {

    }
}

class Player : Fight
{
    int Lv = 1;

    void Heal()
    {
        HP = 100;
        
    }
}

class Monster : Fight
{
    int EXP = 10;
}

namespace Inheritance
{


    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            Monster NewMonster = new Monster();

//            Fight fight = NewPlayer;
            NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);
        }
    }
}
