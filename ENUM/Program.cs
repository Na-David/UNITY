using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENUM
{

    enum PLAYERJOB
    {

    }

    enum ITEMTYPE
    {
        Equip, Portion, Quest
    }

    class Item
    {
        public ITEMTYPE itemType = ITEMTYPE.Portion;
    }

    // Class, Struct, Enum
    class Program
    {
        static void Main(string[] args)
        {
            Item NewItem = new Item();
            NewItem.itemType = ITEMTYPE.Quest;

            Console.WriteLine(ITEMTYPE.Quest);

            ITEMTYPE Type = ITEMTYPE.Portion;
            switch (Type)
            {
                case ITEMTYPE.Equip:
                    break;
                case ITEMTYPE.Portion:
                    break;
                case ITEMTYPE.Quest:
                    break;
            }
        }
    }
}
