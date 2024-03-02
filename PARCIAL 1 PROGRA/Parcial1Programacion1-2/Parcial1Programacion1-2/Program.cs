using System;

namespace Sumatorias
{
    public class Sumas
    {
        public static void Main(string[] args)
        {
            int valores = 0;
            bool ciclo = true;

            while (ciclo)
            {

                Console.WriteLine("Ingresa un valor");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero == 0)
                {
                    ciclo = false;
                }
                else
                {
                    valores = valores + numero;
                }



            }

            Console.WriteLine($"La sumatoria total es de: {valores}");

        }

    }

}