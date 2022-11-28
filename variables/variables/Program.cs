using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // set defult value 
            string name = "barham";
            int num = 5;
            double avg = 5.26;
            DateTime date = DateTime.Now;

            //print value 
            Console.WriteLine(name);
            Console.WriteLine(num);
            Console.WriteLine(avg);
            Console.WriteLine(date);

            Console.WriteLine("----------------------------");


            //input value
            string lastName = Console.ReadLine();
            int number = Convert.ToInt32(Console.ReadLine());
            double avrage = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("----------------------------");

            //print value 
            Console.WriteLine(lastName);
            Console.WriteLine(number);
            Console.WriteLine(avrage);






        }
    }
}
