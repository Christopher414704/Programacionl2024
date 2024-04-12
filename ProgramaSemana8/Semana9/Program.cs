using System;
using System.Text.RegularExpressions;

namespace correo
{

    class Program
    {

        public static void Main(string[]args)
        {
            string Texto = "Hola Kevin, Este es mi nuevo correo: antoniocristofer577@gmail.com , Enviame los documentos faltantes";

            string PatronIdentificacion = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";

            Regex regex = new Regex(PatronIdentificacion);

            MatchCollection coincidir = regex.Matches(Texto);

            foreach(Match match in coincidir){
                Console.WriteLine(match.Value);
            }

        }



    }




}