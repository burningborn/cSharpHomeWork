using System;


namespace HWcSharp_8
{
    abstract partial class Figures
    {
        public abstract double Square();
        public abstract double Perimeter();

    }
    
    class Program
    {
        static void Main(string[] args)
        {


            //Figures[] figures = { new Rectangle("Rectangle", 3, 4), new Circle("Circle", 5), new Squares("Square", 4),
            // new Triangle("Triangle", 5, 6, 7), new Parallelogram("Parallelogram", 7, 9, 190), new Trapezoid("Trapezoid", 9, 5, 3, 4)};

            //MixFigures figuresMix = new MixFigures();
            //for (int i = 0; i < figures.Length; i++)
            //{
            //    figuresMix.addFigures(figures[i]);
            //}

            //figuresMix.generalSquare();
            //figuresMix.generalPerimeter();

            //Console.WriteLine(figuresMix.ToString());
            Rectangle Rec = new Rectangle("Rectangle", 3, 4);
            Rec.Draw();
            Squares S = new Squares("Square", 7);
            S.Draw();
        }
    }
}
