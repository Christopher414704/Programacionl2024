using System;
using System.Reflection.Metadata.Ecma335;


namespace desafio1
{

    class parte1
    {

        static void Pares(int numero)
        {
            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
                
            }
        }
        public static void Main(string[]args)
        {

            Console.WriteLine("Ingresa un numero");
            int par = Convert.ToInt32(Console.ReadLine());

            if (par <= 0)
            {
                Console.WriteLine("Error: Ingrese un numero entero positivo");
            }
            else
            {
                Console.WriteLine($"Los numeros pares de {par} son:");
                Pares(par);
            }

        }

    }



}