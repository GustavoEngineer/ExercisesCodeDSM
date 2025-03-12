using System;

class Ejercicio4
{
    static void Main()
    {
        int[] numeros = new int[5];
        Console.WriteLine("Ingrese 5 números enteros:");
        for (int i = 0; i < 5; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine() ?? "");
        }
        Console.WriteLine("Arreglo original: " + string.Join(", ", numeros));
        Array.Reverse(numeros);
        Console.WriteLine("Arreglo invertido: " + string.Join(", ", numeros));
    }
}
