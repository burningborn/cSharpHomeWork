using System;
//using MyClassLib.WordOfTanks;
using Tanks;


namespace Tanks
{
    class Program
    {      
        static void Main(string[] args)
        {
            Tank[] T34 = new Tank[5];        
                T34[0] = new Tank("T 34.1");
                T34[1] = new Tank("T 34.2");
                T34[2] = new Tank("T 34.3");
                T34[3] = new Tank("T 34.4");
                T34[4] = new Tank("T 34.5");

            Tank[] Pantera = new Tank[5];
                Pantera[0] = new Tank("Pantera.1");
                Pantera[1] = new Tank("Pantera.2");
                Pantera[2] = new Tank("Pantera.3");
                Pantera[3] = new Tank("Pantera.4");
                Pantera[4] = new Tank("Pantera.5");

            for (int i = 0; i < 5; i++)
                T34[i].Display();
            for (int i = 0; i < 5; i++)
                Pantera[i].Display();
            int T = 0, P = 0;

            for (int i = 0; i < 5; i++)
            {
            bool Balte = T34[i] ^ Pantera[i];
                if (Balte)
                    T++;
                else
                    P++;
            }
            Console.WriteLine("\n");
            if(T < P)
            Console.WriteLine("Winner is Pantera");
            else
            Console.WriteLine("Winner is T34");
        }
    }
}
