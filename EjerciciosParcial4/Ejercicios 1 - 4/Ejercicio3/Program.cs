using System;

class Program
{
    static void Main()
    {
        // Paso 1: Pedimos el tamaño del array
        Console.Write("Ingrese la cantidad de números: ");
        int n = int.Parse(Console.ReadLine() ?? "");
        int[] numeros = new int[n]; // Creamos el array

        // Paso 2: Pedimos los números al usuario
        Console.WriteLine($"Ingrese {n} números:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine() ?? "");
        }

        // Paso 3: Aplicamos el método de burbuja
        BubbleSort(numeros);

        // Paso 4: Mostramos los números ordenados
        Console.WriteLine("\nNúmeros ordenados de menor a mayor:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }
    }

    // Método que implementa el ordenamiento burbuja
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++) // Bucle externo controla las pasadas
        {
            for (int j = 0; j < n - i - 1; j++) // Bucle interno para comparar elementos
            {
                if (arr[j] > arr[j + 1]) // Si el número actual es mayor al siguiente, los intercambiamos
                {
                    int temp = arr[j]; // Guardamos el valor temporalmente
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
