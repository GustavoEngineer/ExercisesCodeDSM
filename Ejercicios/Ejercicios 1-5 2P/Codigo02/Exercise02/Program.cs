using System;

public class Compra
{
    public decimal MontoPagado { get; set; }
    public decimal CostoTotal { get; set; }

    public Compra(decimal montoPagado, decimal costoTotal)
    {
        MontoPagado = montoPagado;
        CostoTotal = costoTotal;
    }

    public decimal CalcularCambio()
    {
        return MontoPagado - CostoTotal;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el monto pagado: ");
        decimal montoPagado = decimal.Parse(Console.ReadLine() ?? "");
        Console.Write("Ingrese el costo total: ");
        decimal costoTotal = decimal.Parse(Console.ReadLine() ?? "");

        Compra compra = new Compra(montoPagado, costoTotal);
        Console.WriteLine($"Cambio: {compra.CalcularCambio():C}");
    }
}
