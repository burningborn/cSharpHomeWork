using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq_Avto
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<Automobile> Park = new List<Automobile>();
            Automobile Lincoln = new Automobile("Navigator", 1500000, 320);
            Automobile Nissan = new Automobile("Micra", 750000, 75);
            Automobile Toyota = new Automobile("Corolla", 950000, 85);
            Automobile Porshe = new Automobile("Cayen", 3200000, 450);
            Automobile VolksWAgen = new Automobile("Golf", 823000, 90);
            Automobile Audi = new Automobile("Q5", 2700000, 320);
            Automobile Mercedes = new Automobile("Gelentvagen", 4100000, 420);
            Park.Add(Lincoln);
            Park.Add(Nissan);
            Park.Add(Toyota);
            Park.Add(Porshe);
            Park.Add(VolksWAgen);
            Park.Add(Audi);
            Park.Add(Mercedes);
            foreach (var item in Park)
                Console.WriteLine(item);
                Console.WriteLine();

            var selectedAuto = from a in Park // определяем каждый объект из Park как а
                               where a.Price > 1000000 // фильтруем по критерю                              
                               select a;     // выбираем объект

            foreach (var item in selectedAuto)
                Console.WriteLine(item);
                Console.WriteLine();


            foreach (var item in selectedAuto)
                Console.WriteLine(item);
            Console.WriteLine();

            selectedAuto = from a in Park // определяем каждый объект из Park как а
                           //where a.Price > 1000000 // фильтруем по критерю
                           orderby a.Price // сортируем по цене
                           select a;     // выбираем объект

            foreach (var item in selectedAuto)
                Console.WriteLine(item);
                Console.WriteLine();

            selectedAuto = from a in Park // определяем каждый объект из Park как а
                           orderby a.Power // сортируем по мощности
                           select a;     // выбираем объект

            foreach (var item in selectedAuto)
                Console.WriteLine(item);
                Console.WriteLine();

        }
    }
}
