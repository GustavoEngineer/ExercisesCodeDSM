using System;

class Program
{
    static void Main()
    {
        string[] nombres = new string[5]; // Declaramos un array de 5 nombres

        // Llenamos el array con nombres ingresados por el usuario
        Console.WriteLine("Ingresa 5 nombres:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Nombre {i + 1}: ");
            nombres[i] = Console.ReadLine() ?? "";
        }

        // Solicitamos el nombre a buscar
        Console.Write("\nIngrese el nombre que desea buscar: ");
        string nombreBuscado = Console.ReadLine() ?? "";

        // Buscamos el nombre en el array
        int posicion = -1; // -1 indica que no se encontró
        for (int i = 0; i < 5; i++)
        {
            if (nombres[i].Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase)) // Comparación sin diferenciar mayúsculas
            {
                posicion = i;
                break; // Detenemos la búsqueda al encontrar el primer resultado
            }
        }

        // Mostramos el resultado
        if (posicion != -1)
        {
            Console.WriteLine($"\nEl nombre '{nombreBuscado}' fue encontrado en la posición {posicion}.");
        }
        else
        {
            Console.WriteLine($"\nEl nombre '{nombreBuscado}' no está en la lista.");
        }
    }
}
