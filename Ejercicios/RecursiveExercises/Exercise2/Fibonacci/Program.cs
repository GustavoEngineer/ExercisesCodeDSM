using System;

class Program
{
    // Función recursiva para calcular Fibonacci
    static int Fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1; 
        
        // Llamada recursiva
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        Console.Write("Ingresa un número: ");
        int numero = Convert.ToInt16(Console.ReadLine());

        // Llamamos a la función recursiva
        int resultado = Fibonacci(numero);

        // Mostramos el resultado
        Console.WriteLine($"El término {numero} de Fibonacci es: {resultado}");
    }
}
