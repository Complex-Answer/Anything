using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{
    partial class Trainer
    {
        private string name;
        private Monster[] pokeBall = new Monster[6];


        public void GetAllCatch(int num, Monster pokemon)
        {
            pokeBall[num] = pokemon;
           
        }
        public void PokeRemove(Monster pokename)
        {
            for (int i = 0; i < pokeBall.Length; i++)
            {
                if (pokeBall[i].Name == null)
                    continue;
                else if (pokename.Name == pokeBall[i].Name)
                {
                    pokeBall[i] = null;
                    break;
                }
                
            }
        }    
            public void PrintAllInfo()
        {
            foreach(Monster pokemon in pokeBall)
            {
                if (pokemon == null)
                    break;
               Console.WriteLine("포켓몬 이름 : "+pokemon.Name);
               Console.WriteLine("레벨 : "+pokemon.Level);

            }


        }
    
    }
}
