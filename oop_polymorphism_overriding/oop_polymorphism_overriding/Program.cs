using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_polymorphism_overriding
{


    public class Employee
    {
        public string firstName = "hussain";
        public string lastName = "barham";
        public string address;


        public virtual void print()
        {
            Console.WriteLine("employee : "+firstName+ " " + lastName);
        }


        public void my_class()
        {
            Console.WriteLine("employee class");
        }
    }


    public class fullTimeEmployee : Employee 
    {
        public override void print()
        {
            Console.WriteLine("full time {0} {1}", base.firstName, base.lastName);
        }


        public new void my_class()
        {
            Console.WriteLine("full employee class");
        }

    }


    public class partTimeEmployee : Employee
    {
        public override void print()
        {
            Console.WriteLine("part time {0} {1}",base.firstName,base.lastName);
        }

    }


    public class tempEmployee : Employee
    {
        public override void print()
        {
            Console.WriteLine("temp time {0} {1}", base.firstName, base.lastName);
        }

    }






    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new fullTimeEmployee();
            employees[2] = new partTimeEmployee();
            employees[3] = new tempEmployee();

            foreach (Employee e in employees)
            {
                e.print();
            }

            Console.WriteLine("-------------------");

            ///<summary>
            ///differnt between hiding and ovarriding
            ///#############################################
            /// </summary>

            Employee x = new fullTimeEmployee();
            x.my_class();// on parent run *new*
            x.print();// on child run *override*




            Console.ReadKey(false);
        }
    }
}
