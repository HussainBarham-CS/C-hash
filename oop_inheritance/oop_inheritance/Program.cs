using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_inheritance
{

    public class Employee
    {
        public string firstName;
        public string lastName;
        public string address;

        public Employee() {

            Console.WriteLine("Employee is RUNNING");
        }
        public Employee(string firstName, string lastName) {

            Console.WriteLine("Employee is {0} {1}", firstName, lastName);

        }

        public void print()
        {
            Console.WriteLine(this.firstName + "  " + this.lastName);
        }

    }

    public class FullTimeEmployee : Employee {

        public FullTimeEmployee() : base("hussain","barham")//or base() for another construct
        {

            Console.WriteLine("FullTimeEmployee is RUNNING");
        }

        public float theSalary;
    
    }

    public class PartTimeEmployee : Employee
    {

        public float thePartSalary;

    }




    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee emp1 = new FullTimeEmployee();

            //setter
            emp1.firstName = "ahmad";
            emp1.lastName = "saleh";
            emp1.address = "Ramallah";
            emp1.theSalary = 500;

            emp1.print();
        }
    }
}
