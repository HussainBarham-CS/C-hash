using oop_class.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal("Black", 1.2, "Rio");
            cat.printInfo();//public function
            Project.Animal.PrintInfo();//static function 
            Console.ReadKey(true);
        }
    }

    namespace Project
    {
        class Animal
        {
            public static string _color;
            public static double _len;
            public static string _name;

            public Animal(string color, double len, string name)
            {
                _color = color;
                _len = len;
                _name = name;
            }

            public void printInfo()
            {
                Console.WriteLine("color = {0} , len = {1} , name = {2}", _color, _len, _name);
            }

            public static void PrintInfo()
            {
                Console.WriteLine("color = {0} , len = {1} , name = {2}", _color, _len, _name);
            }

            ~Animal()
            {
                //clean the project
                _color= null;
                _len= 0;
                _name= null;
            }
        }
    }

    
}
