using System;

namespace Problema04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            try
            {
                Console.WriteLine("{0} - {1} - {2}", a, b);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nerror: \n" + ex.Message + "\nLos indices entre los '{}' no coinciden con la cantidad de argumentos\n" +
                    "debe escribirse como ''Console.WriteLine(\"{ 0}- { 1}\" , a, b)");
            }
            
            Console.ReadLine();
        }
    }
}
