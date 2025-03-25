using System;

public class Persona
{
    public string PrimerNombre { get; set; }
    public string SegundoNombre { get; set; }
    public string PrimerApellido { get; set; }
    public string SegundoApellido { get; set; }

    // Constructor con sobrecarga para permitir nombres y apellidos opcionales
    public Persona(string primerNombre, string segundoNombre, string primerApellido, string segundoApellido)
    {
        PrimerNombre = primerNombre;
        SegundoNombre = segundoNombre;
        PrimerApellido = primerApellido;
        SegundoApellido = segundoApellido;
    }

    public string EscribirNombre()
    {
        return $"Tu nombre es: {PrimerNombre} {SegundoNombre} {PrimerApellido} {SegundoApellido}".Trim();
    }

    public string EscribirNombreAlrevez()
    {
        return $"Tu nombre es: {PrimerApellido} {SegundoApellido} {PrimerNombre} {SegundoNombre}".Trim();
    }
}

class Program
{
    static void Main()
    {
        string primerNombre = "", segundoNombre = "";
        string primerApellido = "", segundoApellido = "";

        primerNombre = ObtenerDato("Ingrese su primer nombre:");

        if (ObtenerOpcion("¿Tienes un segundo nombre?", "Sí", "No") == "1")
        {
            segundoNombre = ObtenerDato("Ingrese su segundo nombre:");
        }

        primerApellido = ObtenerDato("Ingrese su primer apellido:");

        if (ObtenerOpcion("¿Tienes un segundo apellido?", "Sí", "No") == "1")
        {
            segundoApellido = ObtenerDato("Ingrese su segundo apellido:");
        }

        // Crear y mostrar información de la persona
        Persona persona = new Persona(primerNombre, segundoNombre, primerApellido, segundoApellido);
        Console.WriteLine(persona.EscribirNombre());
        Console.WriteLine(persona.EscribirNombreAlrevez());
    }

    /// <summary>
    /// Método para obtener un dato ingresado por el usuario.
    /// </summary>
    private static string ObtenerDato(string mensaje)
    {
        Console.WriteLine (mensaje);
        return Console.ReadLine()?.Trim() ?? "";
    }

    /// <summary>
    /// Método para obtener una opción del usuario con dos opciones.
    /// </summary>
    private static string ObtenerOpcion(string pregunta, string opcion1, string opcion2)
    {
        Console.WriteLine($"{pregunta}\n1. {opcion1}\n2. {opcion2}");
        string opcion;
        do
        {
            opcion = Console.ReadLine()?.Trim() ?? "";
        } while (opcion != "1" && opcion != "2");

        return opcion;
    }
}
