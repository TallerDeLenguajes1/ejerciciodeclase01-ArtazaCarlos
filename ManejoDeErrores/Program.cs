using System;

namespace ManejoDeErrores
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list = new string[5];
            list[0] = "Sunday";
            list[1] = "Monday";
            list[2] = "Tuesday";
            list[3] = "Wednesday";
            list[4] = "Thursday";

            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(list[i].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nerror: \n" + ex.Message + "\n" + "El indice 'i' del 'for' se encuentra " +
                    "fuera de los limites de la lista 'list'");
                Console.WriteLine("corremos el codigo nuevamente con una correccion \n");
                for (int i = 0; i < list.Length ; i++)
                {
                    Console.WriteLine(list[i].ToString());
                }
            }
            
            Console.ReadLine();
        }
    }
}
