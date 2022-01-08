using System;
using System.Collections.Generic;
using System.Text;

namespace NewFraction
{
    class Fractions
    {
        public int numerator { get; set; }
        public int denominator { get; set; }
        public Fractions() // конструктор без параметров
        {
            numerator = 0;
            denominator = 0;
        }
        public Fractions(int _numerator, int _denominator)// конструктор с параметрами (числитель - знаменатель)
        {
            numerator = _numerator;
            denominator = _denominator;

        }
        public Fractions (double fract) //конструктор принимающий десятичную дробь
        {
            string Drob = Convert.ToString(fract);
            int ratio = Drob.Length - Drob.IndexOf(",") - 1;
            denominator = 1;
            for (int i = 0; i < ratio; i++)
                denominator *= 10;
            numerator = Convert.ToInt32(Drob.Remove(Drob.IndexOf(","), 1));
            this.Reduce();
        }

        static public int NOK(int n, int m)//наименьшее общее кратное 
        {
            int nok = 0;
            int i = 1;
            bool key = true;
            while (key)
            {
                if (i % m == 0 && i % n == 0)
                {
                    nok = i;
                    key = false;
                }
                i++;
            };

            return nok;
        }
        static public void commonDenominator(Fractions one, Fractions two)//приведение к общему знаменателю
        {
            int nok = NOK(one.denominator, two.denominator); //наименьшее общее кратное 

            int a = nok / one.denominator; //дополнительный множитель первой дроби,
            int b = nok / two.denominator; //дополнительный множитель второй дроби.

            one.numerator *= a;
            one.denominator *= a;
            two.numerator *= b;
            two.denominator *= b;
        }
        public Fractions Reduce()//Сокращение дроби
        {
            if (numerator == 0)
            {
                denominator = 1;
                return this;
            }
            
            int more, less;
            int rest;   
            if (numerator > denominator)
            {
                more = numerator;
                less = denominator;
            }
            else
            {
                less = numerator;
                more = denominator;
            }
            do
            {
                rest = more % less;
                more = less;
                less = rest;
            } while (rest > 0);
            int GCD = more; //GCD - Greatest Common Divider//наибольший общий делитель
            numerator /= GCD;
            denominator /= GCD;
            return this;
        }        
        static public Fractions operator+ (Fractions one, Fractions two)
        {
            Fractions temp = new Fractions();
            if (one.denominator == two.denominator) //одинаковый знаменатель
            {
                temp.numerator = one.numerator + two.numerator;
                temp.denominator = one.denominator;
                temp.Reduce(); //сокращение дроби 
            }
            else                                   //разные знаменатели
            {
                commonDenominator(one, two);

                temp.numerator = one.numerator + two.numerator; //сложение числителя 
                temp.denominator = one.denominator;
                temp.Reduce(); //сокращение дроби 
                one.Reduce();
            }
            return temp;
        }
        static public Fractions operator +(Fractions one, double two)
        {
            Fractions dva = new Fractions(two);
            Fractions temp = new Fractions();
            if (one.denominator == dva.denominator) //одинаковый знаменатель
            {
                temp.numerator = one.numerator + dva.numerator;
                temp.denominator = one.denominator;
                temp.Reduce(); //сокращение дроби 
            }
            else                                   //разные знаменатели
            {
                commonDenominator(one, dva);
                
                temp.numerator = one.numerator + dva.numerator; //сложение числителя 
                temp.denominator = one.denominator;
                temp.Reduce(); //сокращение дроби 
                one.Reduce();
            }
            return temp;
        }
        static public Fractions operator -(Fractions one, Fractions two)
        {
            Fractions temp = new Fractions();
            if (one.denominator == two.denominator) //одинаковый знаменатель
            {
                temp.numerator = one.numerator + two.numerator;
                temp.denominator = one.denominator;
                temp.Reduce(); //сокращение дроби 
            }
            else                                   //разные знаменатели
            {
                int nok = NOK(one.denominator, two.denominator); //наименьшее общее кратное 

                commonDenominator(one, two);

                temp.numerator = one.numerator - two.numerator; //вычитание числителя 
                temp.denominator = one.denominator;
                temp.Reduce(); //сокращение дроби 
                one.Reduce();
            }
            return temp;
        }
        static public Fractions operator* (Fractions one, Fractions two)
        {
            Fractions temp = new Fractions();
            
                temp.numerator = one.numerator * two.numerator;
                temp.denominator = one.denominator * two.denominator;
                temp.Reduce(); //сокращение дроби 
           
            return temp;
        }
        static public Fractions operator *(Fractions one, int two)
        {
            Fractions Integer = new Fractions(two * one.denominator, one.denominator); 
            Fractions temp = new Fractions();

            temp.numerator = one.numerator * Integer.numerator;
            temp.denominator = one.denominator * Integer.denominator;
            temp.Reduce(); //сокращение дроби 

            return temp;
        }
        static public Fractions operator *(int one, Fractions two )
        {          
            return two * one;
        }
        static public Fractions operator /(Fractions one, Fractions two)
        {
            Fractions temp = new Fractions();           
                temp.numerator = one.numerator * two.denominator;
                temp.denominator = one.denominator * two.numerator;
                temp.Reduce(); //сокращение дроби 
            
            return temp;
        }
        static public bool operator ==(Fractions one, Fractions two)
        {
            if (one.numerator == two.numerator && one.denominator == two.denominator)
                return true;
            else
                return false;
        }
        static public bool operator !=(Fractions one, Fractions two)
        {
            if (one.numerator != two.numerator || one.denominator != two.denominator)
                return false;
            else
                return true;
        }
        static public bool operator <(Fractions one, Fractions two)
        {
            commonDenominator(one, two);
            if (one.numerator < two.numerator)
                return true;
            else
                return false;
        }
        static public bool operator >(Fractions one, Fractions two)
        {
            if (one < two)
                return false;
            else
                return true;
        }
        static public bool operator true(Fractions one)
        {
            if (one.numerator < one.denominator)
                return true;
            else
                return false;
        }
        static public bool operator false(Fractions one)
        {
            if (one.numerator > one.denominator)
                return true;
            else
                return false;
        }
        public void Display()
        {
            int integer;
            if (numerator % denominator == 0)
            {
                integer = numerator / denominator;
                Console.WriteLine($"{integer}");
            }
            else if(numerator > denominator)
            {
                integer = numerator / denominator;
                numerator %= denominator;
                    Console.WriteLine($"{integer} {numerator}/{denominator}");
            }            
            else
            Console.WriteLine($"{numerator}/{denominator}");
        }
    }
}
