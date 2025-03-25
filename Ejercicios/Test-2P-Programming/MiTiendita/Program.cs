/*
Instructions
Desarrolla un sistema para gestionar productos en una tienda. 
Cada producto tiene un nombre, un código único y un precio. 
El sistema debe permitir agregar productos, mostrar la información de todos los productos 
y calcular el precio total de todos los productos utilizando recursividad.


Paso 1: Definir la clase Producto
Define una clase Producto con los siguientes atributos y métodos:
Atributos: nombre (String), codigo (int), precio (double).
Métodos: Constructor, getters y setters, y un método toString para mostrar la información del producto.

Paso 2: Crear la clase Tienda
Define una clase Tienda que gestione los productos. 
Esta clase debe incluir métodos para agregar productos, mostrar la información de todos los productos 
y calcular el precio total de todos los productos de manera recursiva. 
Para evitar el uso de listas, arreglos y nodos, utilizaremos referencias directas a los productos.
Paso 3: Crear la clase Main
Finalmente, crea una clase Main para probar el sistema.
Paso 4: Mostrar los resultados en clase y subir el link de Github.
*/

using System;
using System.Collections.Generic;   

class Producto
{
    public string Nombre { get; set; }
    public string Codigo { get; set; }
    public int Precio { get; set; }

    public Producto(string nombre, string codigo, int precio)
    {
        this.Nombre = nombre;
        this.Codigo = codigo;
        this.Precio = precio;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        List<Producto> productos = new List<Producto>();

        Console.WriteLine("Bienvenido a tu tienda virtual");
        Console.ReadKey();

        while (true)
        {
            Console.WriteLine("\n--- Menú ---");
            Console.WriteLine("1. Agregar Producto");
            Console.WriteLine("2. Mostrar productos existentes");
            Console.WriteLine("3. Precio total");
            Console.WriteLine("4. Cerrar tienda");
            Console.Write("Ingresa la opción que desees elegir (1-4): ");
            string opcion = Console.ReadLine() ?? "";

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Ingresar el nombre del producto: ");
                    string nombre = Console.ReadLine() ?? "";

                    Console.WriteLine("Ingresar el código del producto (Asegúrate de que sea único): ");
                    string codigo = Console.ReadLine() ?? "";

                    int precio;
                    Console.WriteLine("Ingresar el precio del producto: ");
                    Console.Write("$");

                    // Validación para asegurarse de que el usuario ingrese un número válido
                    while (!int.TryParse(Console.ReadLine(), out precio) || precio < 0)
                    {
                        Console.WriteLine("Error: Ingresa un precio válido en números enteros.");
                        Console.Write("$");
                    }

                    productos.Add(new Producto(nombre, codigo, precio));
                    Console.WriteLine("El producto ha sido agregado correctamente.");
                    break;

                case "2":
                    Console.WriteLine("Mostrando la información de los productos");
                    Console.ReadKey();

                    if (productos.Count == 0)
                    {
                        Console.WriteLine("Mensaje: No hay productos agregados actualmente.");
                    }
                    else
                    {
                        Console.WriteLine("\nLista de productos:");
                        foreach (var producto in productos)
                        {
                            Console.WriteLine($"Producto: {producto.Nombre}\nCódigo: {producto.Codigo}\nrecio: ${producto.Precio}");
                        }
                    }
                    break;

                case "3":
                    int precioTotal = 0;
                    foreach (var producto in productos)
                    {
                        precioTotal += producto.Precio;
                    }
                    Console.WriteLine($"El precio total de todos los productos es: ${precioTotal}");
                    break;

                case "4":
                    Console.WriteLine("Saliendo de la tienda...");
                    return;

                default:
                    Console.WriteLine("Error: Ingresa una opción válida (1-4).");
                    break;
            }
        }
    }
}
