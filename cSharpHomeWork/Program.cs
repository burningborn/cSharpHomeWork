using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpHomeWork
{
    struct Complexus
    {
        public double A;
        public double B;
        //public static double i = Math.Sqrt(-1);
        
        public Complexus(double a, double b) 
        {
            A = a;
            B = b;
        }
        public static Complexus operator+ (Complexus a, Complexus b)
        {
            Complexus Z = new Complexus(a.A + b.A, a.B + b.B);
            return Z;
        }
        public static Complexus operator- (Complexus a, Complexus b)
        {
            Complexus Z = new Complexus(a.A - b.A, a.B - b.B);
            return Z;
        }
        public static Complexus operator* (Complexus a, Complexus b)
        {
            Complexus Z = new Complexus();
            Z.A = a.A * b.A + a.B * b.B;
            Z.B = a.B * b.A + a.A * b.B;
            return Z;
        }
        public static Complexus operator /(Complexus a, Complexus b)
        {
            Complexus Z = new Complexus();
           //// if ((a.A != 0) && (b.A != 0))
           // {
           //     //Z.A = (a.B * b.B - a.A * b.A) / (b.A * b.A + b.B * b.B);
           //     //Z.B = (b.A * a.B - b.B * a.A) / (b.A * b.A + b.B * b.B);
           // }
           // else
           // {
           //     //throw new DivideByZeroException();
                return Z;
           // }
        }
        public void Print()
        {
            Console.WriteLine($"A - {A}, B - {B}");
        }

    }
    
    struct Auto
    {
        public double Length; 
        public double Clirence;
        public double engineVolume;
        public double Power; 
        public double weelSize;
        public string Colour;
        public string gearBox; 


    }

    class Program
    {       
        static void Main(string[] args)
        {
            double A = 7, B = 8;
            Complexus comp1 = new Complexus(A, B);
            comp1.Print();
            Complexus comp2 = new Complexus(5, 6);
            comp2.Print();
            Complexus comp = comp1 + comp2;
            comp.Print();
            comp = comp1 - comp2;
            comp.Print();
            comp = comp1 * comp2;
            comp.Print();
            //comp = comp1 / comp2;
            //comp.Print();
        }
    }
}
