using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 5, 3, 8, 4, 2 }; // Array desordenado

        Console.WriteLine("Array antes de ordenar:");
        MostrarArray(numeros); // Mostramos los números originales

        OrdenamientoBurbuja(numeros); // Aplicamos el método de ordenamiento

        Console.WriteLine("\nArray después de ordenar:");
        MostrarArray(numeros); // Mostramos el array ordenado
    }

    // Método que implementa el Ordenamiento Burbuja
    static void OrdenamientoBurbuja(int[] arreglo)
    {
        int n = arreglo.Length; // Tamaño del array

        for (int i = 0; i < n - 1; i++) // Bucle para controlar el número de pasadas
        {
            for (int j = 0; j < n - i - 1; j++) // Comparaciones dentro de cada pasada
            {
                if (arreglo[j] > arreglo[j + 1]) // Si el número actual es mayor que el siguiente
                {
                    // Intercambiamos los valores (swap)
                    int temp = arreglo[j];
                    arreglo[j] = arreglo[j + 1];
                    arreglo[j + 1] = temp;
                }
            }
        }
    }

    // Método para mostrar el array
    static void MostrarArray(int[] arreglo)
    {
        foreach (int num in arreglo)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
