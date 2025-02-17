using System;

public class ConsumoAgua
{
    public double MetrosCubicos { get; set; }

    public ConsumoAgua(double metrosCubicos)
    {
        MetrosCubicos = metrosCubicos;
    }

    public double CalcularLitros()
    {
        return MetrosCubicos * 1000;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese los metros cúbicos consumidos: ");
        double metrosCubicos = double.Parse(Console.ReadLine() ?? "");

        ConsumoAgua consumo = new ConsumoAgua(metrosCubicos);
        Console.WriteLine($"Litros consumidos: {consumo.CalcularLitros()}");
    }
}
