using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_abstract
{

    abstract class myClass //: inhert true but interface cant inherted abstract
    {
        int variable = 2;//true

        void print()
        {
            Console.WriteLine("myClass RUNNING ");
        }

        public abstract void method();

        public abstract void info();

    }

    sealed class temp// i can use instanse but i cant inhereted
    {
        public int variable;
        public void print()
        {
            Console.WriteLine("any things");

        }

    }

    class m : myClass
    {
        public override void info()
        {
            Console.WriteLine("hi info");
        }

        public override void method()
        {
            Console.WriteLine("hi method");
        }
    }






    internal class Program
    {
        static void Main()
        {
            m x = new m();
            x.info();
            x.method();


            //myClass m = new myClass();// error

            temp n = new temp();
            n.print();  



            Console.ReadKey(false);
        }
    }

  
}
