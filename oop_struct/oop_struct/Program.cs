using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_struct
{



    /// <summary>
    /// 
    /// struct : is a value type on stack memory
    /// small area than class but life span is short 
    /// 
    /// class : is a reffrance type on heap memory and pointers it on stack memory
    /// big area than struct but life span is long
    /// 
    /// </summary>
    public struct Customer
    {
        private int Id;
        private string Name;

        public int _id
        {
            get => this.Id;
            set => this.Id = value;
        }

        public Customer(int Id, string _name)
        {
            this.Id = Id;
            this.Name = _name;
        }


        public void print()
        {
            Console.WriteLine("id : {0} name : {1}",this.Id,this.Name);
        }
    }
     


    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(12,"hussein");
            customer.print();



        }
    }
}
