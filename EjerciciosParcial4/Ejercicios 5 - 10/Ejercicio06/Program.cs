using System;
using System.IO; // Necesario para manejo de archivos

class Program
{
    static void Main()
    {
        string archivo = "notas.txt";

        // Paso 1: Pedir el número de estudiantes
        Console.Write("Ingrese el número de estudiantes: ");
        int numEstudiantes = int.Parse(Console.ReadLine() ?? "");

        // Paso 2: Pedir los datos de cada estudiante
        using (StreamWriter writer = new StreamWriter(archivo))
        {
            for (int i = 0; i < numEstudiantes; i++)
            {
                Console.Write($"\nIngrese el nombre del estudiante {i + 1}: ");
                string nombre = Console.ReadLine() ?? "";

                Console.Write($"Ingrese las 3 calificaciones de {nombre} separadas por espacio: ");
                string calificaciones = Console.ReadLine() ?? "";

                writer.WriteLine($"{nombre} {calificaciones}");
            }
        }

        Console.WriteLine("\nLos datos han sido guardados en notas.txt");

        // Paso 3: Leer el archivo y calcular los promedios
        Console.WriteLine("\nPromedios de los estudiantes:");

        string[] lineas = File.ReadAllLines(archivo);
        foreach (string linea in lineas)
        {
            string[] datos = linea.Split(' '); // Dividimos los datos por espacios
            string nombre = datos[0]; // El primer dato es el nombre

            // Convertimos las calificaciones a enteros
            int nota1 = int.Parse(datos[1]);
            int nota2 = int.Parse(datos[2]);
            int nota3 = int.Parse(datos[3]);

            double promedio = (nota1 + nota2 + nota3) / 3.0; // Calculamos el promedio

            Console.WriteLine($"{nombre} - Promedio: {promedio:F1}");
        }
    }
}
