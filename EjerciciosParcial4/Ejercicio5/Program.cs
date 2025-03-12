using System;
using System.IO; // Necesario para manejo de archivos

class Program
{
    static void Main()
    {
        string[] nombres = new string[5]; // Paso 1: Crear el array

        // Paso 2: Pedir los nombres al usuario
        Console.WriteLine("Ingrese 5 nombres:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Nombre {i + 1}: ");
            nombres[i] = Console.ReadLine() ?? "";
        }

        // Paso 3: Guardar los nombres en un archivo
        string archivo = "nombres.txt";
        File.WriteAllLines(archivo, nombres);
        Console.WriteLine("\nLos nombres han sido guardados en el archivo nombres.txt");

        // Paso 4: Leer el archivo y mostrar los nombres almacenados
        Console.WriteLine("\nLos nombres guardados en el archivo son:");
        string[] nombresGuardados = File.ReadAllLines(archivo);
        foreach (string nombre in nombresGuardados)
        {
            Console.WriteLine(nombre);
        }
    }
}
