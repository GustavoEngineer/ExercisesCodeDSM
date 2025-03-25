using System;

class Program
{
    // Función recursiva para calcular el factorial
    static int Factorial(int n)
    {
        if (n == 0 || n == 1) // Caso base
        {
            return 1;
        }
        else // Llamada recursiva
        {
            return n * Factorial(n - 1);
        }
    }

    static void Main()
    {
        Console.Write("Ingresa un número: ");
        int numero = Convert.ToInt16(Console.ReadLine());

        // Llamamos a la función recursiva
        int resultado = Factorial(numero);

        // Mostramos el resultado
        Console.WriteLine($"El factorial de {numero} es: {resultado}");
    }
}
