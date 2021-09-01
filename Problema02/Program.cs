using System;

namespace Problema02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            byte result;
            try
            {
                num1 = 30;
                num2 = 60;
                result = Convert.ToByte(num1 * num2);
                Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
                Console.WriteLine("El valor resultante de 'num1' * 'num2' es demasiado grande " +
                    "para guardarla en en una variable de tipo byte (8 bytes, numeros del 0 al 255 sin signo) ");
            }
            
            Console.ReadLine();
        }
    }
}
