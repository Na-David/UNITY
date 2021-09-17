using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoading
{

    enum DMGTYPE
    {
        Physical_DMG, Magical_DMG, Hybrid_DMG
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Overloading Function
            Player NewPlayer = new Player();
            //NewPlayer.Damage()
            NewPlayer.Damage(30, DMGTYPE.Physical_DMG);

            Player NewPlayer1 = new Player(10000);
            NewPlayer1.Damage(2000, DMGTYPE.Magical_DMG);
        }
    }

    
    class Player
    {
        int HP = 1000;
        int Physical_Def = 50;
        int Magical_Def = 10;
        int Hybrid_Def = 30;

        public Player()
        {

        }

        public Player(int _HP)
        {
            HP = _HP;
        }

        // DamageIntInt
        public void Damage(int _Damage, DMGTYPE _Type)
        {
            switch (_Type)
            {
                case DMGTYPE.Physical_DMG:
                    _Damage -= Physical_Def;
                    break;
                case DMGTYPE.Magical_DMG:
                    _Damage -= Magical_Def;
                    break;
                case DMGTYPE.Hybrid_DMG:
                    _Damage -= Hybrid_Def;
                    break;
            }
            Damage(_Damage);
        }
        // DamageInt
        public void Damage(int _Damage)
        {

        }
    }
}
