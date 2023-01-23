using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectA = teamA.projectA;
using projectB = teamA.projectB;
///<summary>
///if i have tow team works on the differnt project but we have the same name of classes
///error !!!! conflect class name 
///soluation :-
///##Aliasing## : add name for namespace
///example:
///using x = teamA.projectA;
///using projectB = teamA.projectB;
/// </summary>
namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            projectA.task1 p = new projectA.task1();//must add path

            p.print1();//i can get method if not static 

            teamA.projectA.task1.print();//this path

            teamA.projectA.task1.print();

            projectB.task1.print();

        }
    }
}






namespace teamA
{
    namespace projectA
    {
        class task1
        {
            public static void print() {

                Console.WriteLine("hello static class A");

            }

            public void print1()
            {

                Console.WriteLine("hello public class A");

            }
        }
    }


    namespace projectB
    {
        class task1
        {
            public static void print()
            {

                Console.WriteLine("hello class B");

            }
        }


        class task2
        {
            public static void print()
            {

                Console.WriteLine("hello static class A");

            }

            public void print1()
            {

                Console.WriteLine("hello public class A");

            }
        }
    }
}
