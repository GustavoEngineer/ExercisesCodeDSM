using System;

public class Aguinaldo
{
    public decimal SalarioDiario { get; set; }

    public Aguinaldo(decimal salarioDiario)
    {
        SalarioDiario = salarioDiario;
    }

    public decimal CalcularAguinaldo()
    {
        return SalarioDiario * 15;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el salario diario: ");
        decimal salarioDiario = decimal.Parse(Console.ReadLine() ?? "");

        Aguinaldo aguinaldo = new Aguinaldo(salarioDiario);
        Console.WriteLine($"Monto del aguinaldo: {aguinaldo.CalcularAguinaldo():C}");
    }
}
