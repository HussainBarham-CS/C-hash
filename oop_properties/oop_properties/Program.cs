using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_properties
{


    public class Animal
    {
        public int id;
        public string name;
        private string description;

        public int _id//must add '_' or write capital latter
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string _name//must add '_' or write capital latter
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string _description 
        { 
            get => this.description; 
            set => this.description = value; 
        }


        public void print()
        {
            Console.WriteLine("id : {0} name : {1} description : {2}",this.id,this.name, this.description);  
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal();
            dog._id = 1;
            dog._name = "shown";
            dog._description = "bad dog";


            dog.print();
        }
    }
}
