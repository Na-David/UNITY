using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG001
{
    class FightUnit
    {
        protected string Name = "None";
        protected int ATK = 10;
        protected int HP = 50;
        protected int m_MaxHP = 100;

        public int MaxHP
        {
            get
            {
                return m_MaxHP;
            }
            set
            {
                m_MaxHP = value;
            }
        }

        public bool IsDead()
        {
            return HP <= 0;
        }

        public void SetName(string _Name)
        {
            Name = _Name;
        }

        public void StatusRender()
        {
            Console.WriteLine(Name + "'s Status ===");
            Console.WriteLine("ATK : " + ATK.ToString());

            Console.WriteLine("HP : " + HP.ToString() + "/" + MaxHP.ToString());
            Console.WriteLine("=====================");
        }

        public void Damage(FightUnit _OtherUnit)
        {
            Console.WriteLine(Name + " got " + _OtherUnit.ATK + " damage.");
            HP -= _OtherUnit.ATK;
            Console.ReadKey();
        }
    }
}
