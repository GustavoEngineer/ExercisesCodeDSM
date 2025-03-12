using System;
using System.IO;
using System.Linq;

class Ejercicio9
{
    static void Main()
    {
        using (StreamWriter sw = new StreamWriter("ventas.csv"))
        {
            string continuar;
            do
            {
                Console.Write("Ingrese el nombre del producto: ");
                string producto = Console.ReadLine();
                Console.Write("Ingrese la cantidad vendida: ");
                int cantidad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el precio unitario: ");
                double precio = double.Parse(Console.ReadLine());
                sw.WriteLine($"{producto},{cantidad},{precio}");
                Console.Write("¿Desea ingresar otra venta? (s/n): ");
                continuar = Console.ReadLine().ToLower();
            } while (continuar == "s");
        }
        
        Console.WriteLine("Ventas registradas en ventas.csv.");
        string[] lineas = File.ReadAllLines("ventas.csv");
        double totalVentas = lineas.Sum(linea => {
            var datos = linea.Split(',');
            return int.Parse(datos[1]) * double.Parse(datos[2]);
        });
        Console.WriteLine($"Total de ventas del día: {totalVentas:C}");
    }
}