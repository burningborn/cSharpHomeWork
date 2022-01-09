using System;
using System.Collections.Generic;
using System.Text;
using MyClassLib.WordOfTanks;

namespace MyClassLib.WordOfTanks
{
    public class Tank
    {
        public string name;       //название танка
        public int ammunition;    //боекомплект
        public int armor;         //уровень брони
        public int mobility;      //уровень маневренности

        Random rnd = new Random();
        public Tank()
        {
            name = null;
            ammunition = 0;
            armor = 0;
            mobility = 0;
        }
        public Tank(string _name)
        {

            name = _name;
            ammunition = rnd.Next(0, 100);
            armor = rnd.Next(0, 100);
            mobility = rnd.Next(0, 100);
        }

        public static bool operator ^(Tank tankOne, Tank tankTwo)
        {
            int winer = 0;

            if (tankOne.ammunition > tankTwo.ammunition) winer++;
            if (tankOne.armor > tankTwo.armor) winer++;
            if (tankOne.mobility > tankTwo.mobility) winer++;

            return winer >= 2;
        }
        public void Display()
        {
            Console.WriteLine($"\n Name - { name}, Armor - {armor}, Mobility - {mobility}, Ammunition - {ammunition}");
        }
    }
}
