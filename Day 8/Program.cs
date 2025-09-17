using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{



    internal class Program
    {

        static void Main(string[] args)
        {
            Monster eevee = new Monster("이브이", 5);

            Monster staraptor = new Monster("찌르호크", 49);

            Monster calyrex = new Monster("버드렉스", 85);

            Monster mewtwo = new Monster("뮤츠", 55);

            Monster charmander = new Monster("파이리", 16);
            
            Monster infernape = new Monster("초염몽", 57);







            Trainer Ash = new Trainer();
            Ash.GetAllCatch(0, eevee);
            Ash.GetAllCatch(1, staraptor);
            Ash.GetAllCatch(2, calyrex);
            Ash.GetAllCatch(3, mewtwo);
            Ash.GetAllCatch(4, charmander);
            Ash.GetAllCatch(5, infernape);
            
            Ash.PokeRemove(calyrex);
            Ash.PrintAllInfo();




        }

    }
}
