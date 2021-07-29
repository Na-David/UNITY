using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Fight
{
    protected int ATK = 10;
    protected int HP = 100;

    public void Damage(Fight _fight)
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

}

namespace Inheritance
{


    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            Monster NewMonster = new Monster();


        }
    }
}
