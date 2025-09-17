using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{
    internal class Monster
    {
        private string name;
        private int level;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        public Monster(string pokename, int pokelevel)
        {
            name = pokename;
            level = pokelevel;
            
        }
        public void Print()
        {
            Console.WriteLine("포켓몬 이름 : " + name);
            Console.WriteLine("레벨 : " + level);
        }



    }
}
