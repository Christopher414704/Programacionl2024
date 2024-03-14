using System;

namespace Promedio
{

    class Promedios
    {
        public static void Main(string[]args)
        {
            List<string> cursos = new List<string>();
            List<int> calificaciones = new List<int>();
            bool estado = true;
            int posicion = 0;
            Console.WriteLine("Bienvenido Profesor");
            while (estado)
            {
                Console.WriteLine("Ingresa el Nombre del Curso");
                string curso = Console.ReadLine();
                Console.WriteLine("Ingresa la Calificacion");
                int calificacion = Convert.ToInt16(Console.ReadLine());

                if (calificacion >= 1 && calificacion <= 10)
                {
                    cursos.Add(curso);
                    calificaciones.Add(calificacion);

                    Console.WriteLine("¿Desea Seguir Ingresango Notas?");
                    Console.WriteLine("Si: . ");
                    Console.WriteLine("No: fin ");
                    string funcion = Console.ReadLine();

                    if (funcion == "fin" || funcion == "Fin")
                    {
                        estado = false;
                    }

                }
                else
                {
                    Console.WriteLine("Error Vuelve a Intentarlo");
                }
            }

            int sumatoria = 0;

            Console.WriteLine("------------------------------------------------");
            for (int i = 0; i < cursos.Count;i++)
            {
                Console.WriteLine($"{cursos[i]} Tiene una nota de: {calificaciones[i]}");
                sumatoria = sumatoria + calificaciones[i];
            }

            Console.WriteLine($"Promedio Total: {sumatoria / Convert.ToDouble(cursos.Count)}");
            Console.WriteLine("------------------------------------------------");
        }

    }


}