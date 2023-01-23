using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace comments
{
    internal class Program
    {

        public void fun(int i) {
            Console.WriteLine("FUN");
        }

        static void fun1(int i)
        {
            Console.WriteLine("FUN1");
        }

        static int fun2(int i)
        {
            return i;
        }


        /// <summary>
        /// PASS BY REFERANCE PARAMETERS
        /// </summary>
        /// 
        public static int fun4(ref int x,ref int y)
        {
            x = 10;
            y = 12;

            return 0;
        }




        /// <summary>
        /// PASS BY OUT PARAMETERS
        /// </summary>

        public static int fun3(int num1,int num2,out int div,out int mult) {
        
            div = num1/num2;
            mult = num2*num1;
            return num1 + num2;
        
        }



        /// <summary>
        /// PASS BY OUT PARAMETERS
        /// </summary>
        /// 
        public static void fun5(params int[] args)
        {
            Console.WriteLine("---------array params------------");
            foreach(int i in args)
            {
                Console.WriteLine(i);
            }
        }


        static void Main(string[] args)
        {
            //line
            /*
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * *///Multi line
            ///<summary>
            ///
            /// 
            /// 
            /// </summary>
            /// 

            int y= 15;

            //fun(y);//error
            //CALL FUNCTION
            Program P = new Program();
            P.fun(y);

            //call static function
            Program.fun1(y);

            //call static return function
            Console.WriteLine(Program.fun2(y));










            fun5(1,2,3,4,5,6);

            int div = 0;
            int mult = 0;
            fun3(20,10,out div,out mult);
            Console.WriteLine("----------pass by out parameters-------");
            Console.WriteLine(div); Console.WriteLine(mult);

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                




            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(num);
        }

    }
}
