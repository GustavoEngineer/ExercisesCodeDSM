using System;
using System.IO;
using System.Linq;

class Ejercicio6
{
    static void Main()
    {
        using (StreamWriter sw = new StreamWriter("notas.txt"))
        {
            string continuar;
            do
            {
                Console.Write("Ingrese el nombre del estudiante: ");
                string nombre = Console.ReadLine() ?? "";
                Console.Write("Ingrese 3 calificaciones separadas por espacio: ");
                string calificaciones = Console.ReadLine() ?? "";
                sw.WriteLine(nombre + "," + calificaciones);
                Console.Write("¿Desea ingresar otro estudiante? (s/n): ");
                continuar = Console.ReadLine() ?? "".ToLower();
            } while (continuar == "s");
        }

        Console.WriteLine("Datos guardados en notas.txt.");
        string[] lineas = File.ReadAllLines("notas.txt");
        Console.WriteLine("Promedios de estudiantes:");
        foreach (var linea in lineas)
        {
            var datos = linea.Split(',');
            string nombre = datos[0];
            double promedio = datos.Skip(1).Select(double.Parse).Average();
            Console.WriteLine($"{nombre}: {promedio:F2}");
        }
    }
}
