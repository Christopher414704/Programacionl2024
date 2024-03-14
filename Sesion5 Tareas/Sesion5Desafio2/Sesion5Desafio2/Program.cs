using System;

namespace primos
{

    class numerosprimos
    {

        public static void Main(string[]args)
        {
            Console.WriteLine("Ingresa un numero");
            int numero = Convert.ToInt16(Console.ReadLine());

            if (numero <= 0)
            {
                Console.WriteLine($"El numero {numero} es negativo , Introdusca otro numero");

            }
            else
            {

                bool EsPrimo = true;
                for (int i = 2; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        EsPrimo = false;
                        break;
                    }
                    
                }

                if (EsPrimo)
                {
                    Console.WriteLine("Es un Numero Primo");
                }
                else
                {
                    Console.WriteLine("No es un numero Primo");
                }

            }

        }

    }


}