using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Fight
{
    protected int ATK;

    public Fight()
    {
        int a = 100;
    }
}

class Player : Fight
{
    // no need return value
    // when Player class has been created, this constructor automatically executed one time
    public Player()
    {
        ATK = 100;
        int a = 10;
    }
}

namespace ClassConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
        }
    }
}
