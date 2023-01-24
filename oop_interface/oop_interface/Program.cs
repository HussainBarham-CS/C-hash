using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_interface
{


    interface ICustomer
    {
        /*
         * 
         * 
         * 
         * 
         * int id;//error
         * 
         * 
         * */
        void Print();//not public 
        int add(int id);
    }


    public class Customer : ICustomer
    {
        public int add(int id)
        {
            return 1 + 2;
        }

        public void Print()
        {
            Console.WriteLine("Customer class");
        }
    }










    interface x
    {
        void Print();
    }

    interface y
    {
        void Print();
    }

    /// <summary>
    /// emplict interface
    /// print in tow interface
    /// </summary>

    public class temp : x, y
    {
        public void Print()
        {
            Console.WriteLine("interface defult");
        }

        void x.Print()
        {
            Console.WriteLine("interface x");

        }

        void y.Print()
        {
            Console.WriteLine("interface y");

        }
    }






    internal class Program
    {
        static void Main(string[] args)
        {
            ICustomer customer = new Customer();//more safty
            Customer custome = new Customer();//you can do it but not perfect
            customer.Print();

            Console.WriteLine("--------------");

            temp c = new temp();
            c.Print();

            x v = new temp();
            v.Print();

            y vv = new temp();
            vv.Print();





        }
    }
}
