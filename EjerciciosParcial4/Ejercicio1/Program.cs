using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int [10];
        int contador = 0;

        Console.WriteLine("Ingresar 10 números enteros");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Ingresar el número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
            contador += numeros[i];
        }

        double promedio = (double)contador / numeros.Length;

        Console.WriteLine("\nResultados:");
        Console.WriteLine($"Suma total: {contador}");
        Console.WriteLine($"Promedio: {promedio}");
    }
}