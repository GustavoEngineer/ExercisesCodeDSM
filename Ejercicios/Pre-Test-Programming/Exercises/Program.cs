using System;
using System.Collections.Generic;

class CuentaBancaria
{
    public string NumeroCuenta { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; set; }

    public CuentaBancaria(string numeroCuenta, string titular, double saldo)
    {
        NumeroCuenta = numeroCuenta;
        Titular = titular;
        Saldo = saldo;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Cuenta: {NumeroCuenta}, Titular: {Titular}, Saldo: ${Saldo}");
    }
}

class Banco
{
    private List<CuentaBancaria> cuentas = new List<CuentaBancaria>();

    public void AgregarCuenta(CuentaBancaria cuenta)
    {
        cuentas.Add(cuenta);
    }

    public void MostrarCuentas()
    {
        Console.WriteLine("\n=== Lista de Cuentas Bancarias ===");
        foreach (var cuenta in cuentas)
        {
            cuenta.MostrarInformacion();
        }
    }

    public double CalcularSaldoTotal(int index = 0)
    {
        if (index >= cuentas.Count) // Caso base: si ya revisamos todas las cuentas
        {
            return 0;
        }
        // Llamada recursiva sumando el saldo de la cuenta actual
        return cuentas[index].Saldo + CalcularSaldoTotal(index + 1);
    }
}

class Program
{
    static void Main()
    {
        Banco banco = new Banco();

        // Agregamos cuentas bancarias
        banco.AgregarCuenta(new CuentaBancaria("123456", "Juan Pérez", 1500.50));
        banco.AgregarCuenta(new CuentaBancaria("789012", "María López", 2300.75));
        banco.AgregarCuenta(new CuentaBancaria("345678", "Carlos Gómez", 1750.30));

        // Mostramos todas las cuentas
        banco.MostrarCuentas();

        // Calculamos el saldo total usando recursión
        double saldoTotal = banco.CalcularSaldoTotal();
        Console.WriteLine($"\nSaldo Total en el Banco: ${saldoTotal}");
    }
}
