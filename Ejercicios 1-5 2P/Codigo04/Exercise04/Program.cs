using System;

public class AlimentoPerro
{
    public int DiasDeViaje { get; set; }

    public AlimentoPerro(int diasDeViaje)
    {
        DiasDeViaje = diasDeViaje;
    }

    public double CalcularAlimentoNecesario()
    {
        double consumoDiarioGramos = 750;
        return (consumoDiarioGramos * DiasDeViaje) / 1000;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese los días de viaje: ");
        int diasDeViaje = int.Parse(Console.ReadLine() ?? "");

        AlimentoPerro alimento = new AlimentoPerro(diasDeViaje);
        Console.WriteLine($"Kilogramos de alimento necesarios: {alimento.CalcularAlimentoNecesario()}");
    }
}
