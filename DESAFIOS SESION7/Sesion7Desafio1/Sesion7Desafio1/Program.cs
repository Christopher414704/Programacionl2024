using System;
using System.Security.Cryptography.X509Certificates;


namespace juego
{

    class totito
    {

        public static void Main(string[] args)
        {
            char[] tabla = {'X','O','O'};
            char[] tabla2 = {'O','X','O'};
            char[] tabla3 = {'O', 'O', 'X'};

            Console.WriteLine("Bienvenido a Totito");
            Console.WriteLine(tabla[0].ToString() + "|" + tabla[1] + "|" + tabla[2]);
            Console.WriteLine("-----");
            Console.WriteLine(tabla2[0].ToString() + "|" + tabla2[1] + "|" + tabla2[2]);
            Console.WriteLine("-----");
            Console.WriteLine(tabla3[0].ToString() + "|" + tabla3[1] + "|" + tabla3[2]);
        }


    }

}