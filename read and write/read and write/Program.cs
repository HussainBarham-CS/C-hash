using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace read_and_write
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name");
            string name = Console.ReadLine();

            Console.WriteLine("welcome " + name);

            Console.WriteLine("your account is active mr.{0}", name);

            Console.WriteLine("enter age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter avg");
            var avg = Convert.ToInt32(Console.ReadLine());//int just

            Console.WriteLine("welcome " + name + " " + age + " " + avg);


            //variables

             string stringVar = "Hello World!!";
             int intVar = 100;
             float floatVar = 10.2f;
             char charVar = 'A';
             bool boolVar = true;



            Console.WriteLine("max int value {0}", int.MaxValue);
            Console.WriteLine("min int value {0}", int.MinValue);


            //strings

            Console.WriteLine("\"hi\"");
            //Console.WriteLine("c:\newfolder\hussain");//error
            Console.WriteLine(@"c:\newfolder\hussain");



            /////////////nullable type
            bool? isAhmed= null;
            Console.WriteLine("are you ahmed : (y , n) : ");
            string result = Console.ReadLine();
            isAhmed = result == "y" ? true : false;

            Console.WriteLine("is ahmed : {0} ", isAhmed);


            
            int? available = null;
            int av = available ?? 0;
            Console.WriteLine(av);//if null put zero else print value



            ////array

            string str = "hussain barham";
            Console.WriteLine(str[0]);

            int[] numbers = new int[3] { 10, 15, 12 };
            Console.WriteLine(numbers[0]);


            string[] names = new string[3] { "hussain" , "barham" , "ahmed" };
            Console.WriteLine(names[0][1]);













            Console.ReadKey(true);

            

        }
    }
}
