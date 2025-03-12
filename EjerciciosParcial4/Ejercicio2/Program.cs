using System;

class Program
{
    static void Main(string[] args)
    {
        string [] Nombres = new string[5];

        Console.WriteLine("Escribe 5 nombres diferentes");
    
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Nombre {i + 1}: ");
                Nombres[i] = Console.ReadLine() ?? "";
            }

        // Buscador de nombres
            Console.Write("Ingrese un nombre para buscar: ");
            string nombreBuscado = Console.ReadLine() ?? "";

        // Salida
            int Posision = Array.IndexOf(Nombres, nombreBuscado);
            
            if (Posision == -1)
            {
                Console.WriteLine($"El nombre {nombreBuscado} no se encuentra disponible");
            } else
            {
                Console.WriteLine($"El nombre {nombreBuscado} se encuentra en la posisión {Posision + 1}");
            }
    }
}