using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_static_instans_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle._PI = 3.14159;//this value is shared between all instans classes
            Circle.print();//shared function !static! 


            Circle._PI = Convert.ToDouble(3.1415);
            //instans from class
            Circle circle = new Circle(6);
            //circle.print();//errror i cant use static function on instens class
            double Area = circle.CalcAreas();
            Console.WriteLine(Area);

            //instans from class
            Circle circle2 = new Circle(10);

            double Area2 = circle2.CalcAreas();
            Console.WriteLine(Area2);

            //instans from class
            Circle circle3 = new Circle(4);

            double Area3 = circle3.CalcAreas();
            Console.WriteLine(Area3);

            //instans from class
            Circle circle4 = new Circle(2);

            double Area4 = circle4.CalcAreas();
            Console.WriteLine(Area4);




            Console.ReadKey(true);
        }
    }



    class Circle
    {
        public static double _PI = 3.14159f;
        int _Radius;


        public Circle( int radius)
        {
            Console.WriteLine("public RUN");
            _Radius = radius;
        }

        static Circle()
        {
            Console.WriteLine("static RUN");
        }

        public static void print()
        {
            Console.WriteLine("circle");
        }

        public double CalcAreas()
        {
            return this._Radius * Circle._PI;
        }
    }




}
