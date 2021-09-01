using System;

namespace PrecticaTallerII
{
    class Program
    {
        static void Main(string[] args)
        {
            Random objNum = new Random();
            int num = objNum.Next(11);
            int num2 = -1;
            int intentos = 0;

            Console.WriteLine("Se genera aleatoriamente un numero entre 1 y 10");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Trate de adivinar el numero, ingrese un valor entre 1 y 10");

            while (num != num2)
            {
                try
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                    if (num > num2)
                    {
                        Console.WriteLine("El valor ingresado es menor");
                    }
                    else
                    {
                        Console.WriteLine("El valor ingresado es mayor");
                    }
                    Console.WriteLine("ingrese otro valor");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("El valor ingresado no es valido");
                }
                intentos++;
            }

            Console.WriteLine("**********************************");
            Console.WriteLine("el numero es el correto: " + num + " en el intento nro: " + intentos);
            Console.WriteLine("**********************************");
        }
    }
}