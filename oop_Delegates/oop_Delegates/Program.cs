using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Delegates
{

    class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }



        public Employee() { }
        public Employee(int id) { }


        public static void UpdateSalary(Employee[] emps , needUpdated NeedUpdated) 
        {
            foreach (Employee emp in emps)
            {
                if(NeedUpdated(emp))
                {
                    Console.WriteLine("Employee {0} UPDATED ",emp.Name);
                }
            }
        }
        
        
    }

    delegate bool needUpdated(Employee emp);



    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[4];

            emp[0] = new Employee() { Id = 1, Name = "ahmed", Experience = 4, Salary = 3200 };
            emp[1] = new Employee() { Id = 1, Name = "hussain", Experience = 7, Salary = 6100 };
            emp[2] = new Employee() { Id = 1, Name = "ameen", Experience = 6, Salary = 100000 };
            emp[3] = new Employee() { Id = 1, Name = "omar", Experience = 3, Salary = 5600 };


            needUpdated nu = new needUpdated(isNeedUpdated);


            Employee.UpdateSalary(emp,nu);



            Console.ReadKey(true);

        }


        public static bool isNeedUpdated(Employee emp)
        {
            if (emp.Experience >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }



    
}
