using System;
using System.Threading;

class Program
{
    
    static int Torres(int NumDiscos)
    {
        if (NumDiscos == 1)
        {
            return 1;
        }
        return (int)Math.Pow(2, NumDiscos) - 1;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el numero de discos: ");
        int NumDiscos = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("El numero de movimientos necesarios es: " + Torres(NumDiscos));
    }
}