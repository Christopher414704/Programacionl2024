using System;

namespace Banco
{
    public class Funciones
    {
        public int Sumatoria(int monto_cuenta, int cantidad_sumatoria)
        {
            int resultado = monto_cuenta + cantidad_sumatoria;
            return resultado;
        }

        public int Resta(int monto_cuenta, int cantidad_retiro)
        {
            int resultado = monto_cuenta - cantidad_retiro;
            return resultado;
        }
    }
    public class Cajero
    { 

        public static void Main(string[]args)
        {
            int cuenta_monto = 1500;
            int monto = 0;
            bool ciclo = true;

            Funciones oFunciones = new Funciones();

            Console.WriteLine("Ingrese su numero de PIN");
            string pin = Console.ReadLine();

            while (ciclo)
            {
                
                Console.WriteLine("BIENVENIDO A BANCOS AMERICA");    
                Console.WriteLine($"Hola usuario {pin}, En que podes ayudarlo?");
                Console.WriteLine("1. Estado de Cuenta");
                Console.WriteLine("2. Retirar Saldo");
                Console.WriteLine("3. Depositar Saldo");
                Console.WriteLine("4. Salir del Sistema");
                int funcion = Convert.ToInt32(Console.ReadLine());

                switch (funcion)
                {
                    case 1:
                        Console.WriteLine($"Su estado de cuenta es: {cuenta_monto}");           

                        break;
                    case 2:
                        Console.WriteLine("Introdusca el monto a Retirar");
                        monto = Convert.ToInt32(Console.ReadLine());

                        if (monto < cuenta_monto)
                        {
                            int res = oFunciones.Resta(cuenta_monto, monto);
                            cuenta_monto= cuenta_monto - monto;

                            Console.WriteLine($"Se ha retirado de su cuenta {monto}, exitosamente");
                            Console.WriteLine($"Ahora tiene un saldo de: {res}");

                        }
                        else
                        {
                            Console.WriteLine("Error: La cantidad sobrepasa lo que hay en existencia");
                        }
                        break;
                    case 3:
                        
                        Console.WriteLine("Introdusca el monto a Despositar");
                        int monto_deposito = Convert.ToInt32(Console.ReadLine());

                        int res2 = oFunciones.Sumatoria(cuenta_monto,monto_deposito);
                        cuenta_monto = cuenta_monto + monto_deposito;

                        Console.WriteLine($"Se ha depositado en su cuenta {monto_deposito}, Correctamente");
                        Console.WriteLine($"Ahora tiene un saldo de: {res2}");
                        
                        break;
                    case 4:
                        ciclo = false;
                        break;
                }

            }
 

        }

     
    }

}