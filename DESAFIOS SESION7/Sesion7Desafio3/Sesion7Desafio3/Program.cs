using System;


namespace documento
{
    class listado
    {
        public static void Main(string[]args)
        {
            bool estado = true;

            List<string> listadoTareas = new List<string>();
            while (estado) { 
                        Console.WriteLine("Bienvenido Usuario, eliga una opcion (escriba el numero)");
                        Console.WriteLine("1. Mostrar");
                        Console.WriteLine("2. Agregar");
                        Console.WriteLine("3. Eliminar");
                        string opcion = Console.ReadLine();

                if (opcion == "1")
                    {
                    Console.WriteLine("Listado de Tareas:");
                    Console.WriteLine("------------------------");
                    for (int i = 0; i < listadoTareas.Count; i++)
                    {
                        Console.WriteLine(listadoTareas[i]);
                    }
                    Console.WriteLine("------------------------");
                }
                else
                {
                    if (opcion == "2")
                    {
                        Console.WriteLine("Ingrese la tarea a ingresar");
                        string tarea = Console.ReadLine();
                        
                            listadoTareas.Add(tarea);
                        
                        
                            Console.WriteLine("Error: No se pudo agregar la tarea, intenta mas tarde");
                        
                    }
                    else
                    {
                        if (opcion == "3")
                        {
                            Console.WriteLine("Ingrese la tarea a Eliminar");
                            string tarea = Console.ReadLine();

                            
                                listadoTareas.Remove(tarea);
                            
                                Console.WriteLine("Error: Esta tarea no Existe, Ingrese denuevo la tarea");
                            
                        }
                    }
                }
                     
                

            }



        }

    }


}