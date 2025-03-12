using System;
using System.IO;

class Ejercicio7
{
    static void Main()
    {
        Console.WriteLine("Escriba un texto para guardar en el archivo:");
        string texto = Console.ReadLine() ?? "";
        File.WriteAllText("texto.txt", texto);
        Console.WriteLine("Texto guardado en texto.txt");
        
        string contenido = File.ReadAllText("texto.txt");
        int palabraCount = contenido.Split(new char[] {' ', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries).Length;
        Console.WriteLine("Número de palabras en el archivo: " + palabraCount);
    }
}
