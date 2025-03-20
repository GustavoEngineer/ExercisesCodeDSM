using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[5]; // Paso 1: Declarar el array

        // Paso 2: Pedir los 5 números al usuario
        Console.WriteLine("Ingrese 5 números enteros:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine() ?? "");
        }

        // Paso 3: Mostrar el array original
        Console.WriteLine("\nArray original:");
        MostrarArray(numeros);

        // Paso 4: Mostrar el array invertido recorriéndolo al revés
        Console.WriteLine("\nArray invertido:");
        for (int i = 4; i >= 0; i--)  // Recorremos el array desde el final hasta el inicio
        {
            Console.Write(numeros[i] + " ");
        }
        Console.WriteLine();
    }

    // Método para mostrar el array en una sola línea
    static void MostrarArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
