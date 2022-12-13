using System;

namespace Condition_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yazı-Tura oynuyoruz");
            Console.WriteLine("Yazı mı,tura mı ? Yazı=Y,Tura=T");
            var YazıTura = Console.ReadLine();

            // Yazı da gelse Tura da gelse kazanmak istiyorum..

            bool kazandim = false;

            if (YazıTura == "Y")
                kazandim = false;
            if (YazıTura == "T")
                kazandim = true;
            if(!kazandim)
            {
                kazandim = true;
            }
            if(kazandim)
            {
                Console.WriteLine("Tebrikler,kazandınız!");
            }

            Console.ReadLine();
            
        }
    }
}