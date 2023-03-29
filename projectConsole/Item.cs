using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectConsole
{
    class Item
    {
        public string name { get; set; }
        public decimal price { get; set; }
        public int amount { get; set; }

        public Item(string name, decimal price, int amount)
        {
            this.name = name;
            this.price = price;
            this.amount = amount;
        }
        public static Item cRank = new Item("cRank", 150, 1);
        public static Item bRank = new Item("bRank", 300, 1);
        public static Item aRank = new Item("aRank", 600, 1);
        public static Item sRank = new Item("sRank", 1200, 1);
        public static Item exRank = new Item("exRank", 2400, 1);
        public static Item potion = new Item("potion", 800, 1);
        public static Item healscr = new Item("healing scroll", 1500, 1);
    }
}
