using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectConsole
{
    class Enemy
    {
        public string name { get; set; }
        public int hp { get; set; }
        public int mp { get; set; }
        //public Skill skil_1 { get; set; }
        //public Skill skil_2 { get; set; }
        //public Skill skil_3 { get; set; }
        public bool isAlive { get; set; }
        public Enemy()
        {

        }
        public virtual void Showinfo()
        {
            Console.WriteLine(this.name);
            Console.WriteLine("  H  P  : {0} ", this.hp);
            Console.WriteLine("  M  P  : {0} ", this.mp);
            //Console.WriteLine(" S K L 1: {0} ", this.skil_1.name);
            //Console.WriteLine(" S K L 2: {0} ", this.skil_2.name);
            //Console.WriteLine(" S K L 3: {0} ", this.skil_3.name);
        }
    }
    class Player : Enemy
    {
        public bool isFight;
        public List<Item> Inventory { get; set; }
        public Player(string name, int hp, int mp)
        {
            this.name = name;
            this.hp = hp;
            this.mp = mp;
            this.isAlive = true;
            this.isFight = false;
            this.Inventory = new List<Item>();
        }
        public override void Showinfo()
        {
            base.Showinfo();
            Console.WriteLine("■■■■■ Inventory ■■■■■");
            foreach (var item in this.Inventory)
            {
                Console.WriteLine($"{item.name}, {item.amount}ea");
            }
        }
    }
}
