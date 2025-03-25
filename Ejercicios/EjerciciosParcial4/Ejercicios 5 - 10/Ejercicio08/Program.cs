using System;
using System.Linq;

class Ejercicio8
{
    static void Main()
    {
        int[] numeros = new int[10];
        Console.WriteLine("Ingrese 10 números:");
        for (int i = 0; i < 10; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine() ?? "");
        }
        Console.Write("Ingrese el número a eliminar: ");
        int eliminar = int.Parse(Console.ReadLine() ?? "");
        int[] nuevoArreglo = numeros.Where(n => n != eliminar).ToArray();
        Console.WriteLine("Nuevo arreglo sin el número eliminado: " + string.Join(", ", nuevoArreglo));
    }
}
