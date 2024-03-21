using System;

class Program
{
    
    static double CalcularDescuento(double total)
    {
        if (total >= 100 && total < 1000)
        {
            return total * 0.10; 
        }
        else if (total >= 1000)
        {
            return total * 0.20; 
        }
        else
        {
            return 0; 
        }
    }

    static void Main(string[] args)
    {
        
        double[,] comprasClientes = {
            { 80, 120, 500, 1500, 300 },
            { 200, 300, 1000, 1200, 150 },
            { 50, 150, 600, 800, 2000 },
            { 300, 400, 150, 200, 1100 },
            { 1500, 800, 900, 200, 1200 }
        };

        
        for (int cliente = 0; cliente < comprasClientes.GetLength(0); cliente++)
        {
            Console.WriteLine($"Cliente {cliente + 1}:");
            for (int compra = 0; compra < comprasClientes.GetLength(1); compra++)
            {
                double total = comprasClientes[cliente, compra];
                double descuento = CalcularDescuento(total);
                double totalConDescuento = total - descuento;

                Console.WriteLine($"  Compra {compra + 1}: Total = ${total}, Descuento = ${descuento}, Total con descuento = ${totalConDescuento}");
            }
            Console.WriteLine();
        }
    }
}
