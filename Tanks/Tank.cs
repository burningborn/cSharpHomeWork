using System;
using System.Collections.Generic;
using System.Text;

namespace Tanks
{
    class Tank
    {
       string name;       //название танка
       int ammunition;    //боекомплект
       int armor;         //уровень брони
       int mobility;      //уровень маневренности

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
        public string getAmmunition
        {
            get =>Convert.ToString(ammunition);
        }
        public string getArmor
        {
            get => Convert.ToString(armor);
        }
        public string getMobility
        {
            get => Convert.ToString(mobility);
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
