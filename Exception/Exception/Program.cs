using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    internal class Program
    {
        static void Main()
        {
            StreamReader streamReader = null;
            try
            {

                streamReader = new StreamReader(@"C:\Users\pc\Desktop\text.txt");
                Console.WriteLine(streamReader.ReadToEnd());

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("===========================");
                Console.WriteLine(ex.FileName);
                Console.WriteLine("===========================");
                Console.WriteLine(ex.StackTrace);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("===========================");
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("===========================");
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Close();
            }

            

            Console.ReadKey(true);
        }
    }
}
