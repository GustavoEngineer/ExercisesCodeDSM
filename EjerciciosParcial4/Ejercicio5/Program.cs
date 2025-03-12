using System;
using System.IO;

class Ejercicio5
{
    static void Main()
    {
        string[] nombres = new string[5];
        Console.WriteLine("Ingrese 5 nombres:");
        for (int i = 0; i < 5; i++)
        {
            nombres[i] = Console.ReadLine();
        }
        File.WriteAllLines("nombres.txt", nombres);
        Console.WriteLine("Nombres guardados en el archivo.");
        
        string[] nombresLeidos = File.ReadAllLines("nombres.txt");
        Console.WriteLine("Nombres leídos del archivo:");
        foreach (var nombre in nombresLeidos)
        {
            Console.WriteLine(nombre);
        }
    }
}
