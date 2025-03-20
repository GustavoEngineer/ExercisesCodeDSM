using System;

class Ejercicio10
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];
        Console.WriteLine("Ingrese los valores de la matriz 3x3:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine() ?? "");
            }
        }
        
        Console.Write("Ingrese un número para multiplicar cada fila: ");
        int multiplicador = int.Parse(Console.ReadLine() ?? "");
        
        Console.WriteLine("Matriz resultante:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matriz[i, j] *= multiplicador;
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
