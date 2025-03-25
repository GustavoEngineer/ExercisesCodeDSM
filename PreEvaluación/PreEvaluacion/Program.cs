/*
Ejercicio: Gestión de Inventario de una Tienda 
Una tienda desea implementar un sistema para registrar su inventario de productos 
en un archivo de texto y consultar la información cuando sea necesario. 

Requisitos: 
    1. El programa debe permitir al usuario ingresar datos de productos:  
        - Código del producto 
        - Nombre del producto 
        - Cantidad en stock 
        - Precio unitario 

    2. Los datos deben guardarse en un archivo llamado "inventario.json", donde cada línea represente 
    un producto con sus datos separados por comas. 

    3. Después de guardar la información, el programa debe:
        - leer el archivo
        - Mostrar en pantalla todos los productos registrados con su respectivo stock y precio. 
*/

// Importación de namespaces necesarios para el funcionamiento del programa
using System; 
using System.IO; // Permite leer y escribir archivos
using System.Text.Json; // Facilita la serialización y deserialización de objetos en formato JSON
using System.Collections.Generic; // Contiene estructuras de datos como List<T>

// Definición de la clase Producto que representa un producto en inventario
public class Producto
{
    // Propiedades públicas con getters y setters automáticos
    public string Codigo { get; set; } 
    public string Nombre { get; set; } 
    public int Cantidad { get; set; }     
    public decimal Precio { get; set; }

    // Constructor que inicializa todas las propiedades del producto
    public Producto(string codigo, string nombre, int cantidad, decimal precio)
    {
        Codigo = codigo;
        Nombre = nombre;
        Cantidad = cantidad;
        Precio = precio;
    }
}

// Clase de utilidad para validar la entrada de números enteros positivos
public class NumberValidator
{
    public static int GetPositiveNumber()
    {
        string entrada = Console.ReadLine() ?? ""; // Lee entrada desde consola, asegura que no sea null
        if (int.TryParse(entrada, out int numero) && numero > 0) // Valida si es un número entero positivo
        {
            return numero; // Retorna el número válido
        }

        Console.WriteLine("❌ Entrada inválida. Debe ser un número mayor que cero.");
        return GetPositiveNumber(); // Llamada recursiva si la entrada es inválida
    }
}

// Clase de utilidad similar a la anterior, pero para números decimales positivos
public class NumberValidator2
{
    public static decimal GetPositiveDecimal()
    {
        string entrada = Console.ReadLine() ?? "";
        if (decimal.TryParse(entrada, out decimal numero2) && numero2 > 0)
        {
            return numero2;
        }

        Console.WriteLine("❌ Entrada inválida. Debe ser un número mayor que cero.");
        return GetPositiveDecimal();
    }
}

// Clase principal que contiene el punto de entrada del programa
class Program
{
    public static void Main(string[] args)
    {
        // Recolección de datos del producto desde la consola
        Console.Write("Ingrese el código del producto: ");
        string codigo = Console.ReadLine() ?? "";

        Console.Write("Ingrese el nombre del producto: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Ingrese la cantidad del producto: ");
        int cantidad = NumberValidator.GetPositiveNumber(); // Validación de cantidad positiva

        Console.Write("Ingrese el precio del producto: ");
        decimal precio = NumberValidator2.GetPositiveDecimal(); // Validación de precio positivo

        Producto producto = new Producto(codigo, nombre, cantidad, precio);

        // Creación del objeto producto con los datos ingresados
        List<Producto> productos = new List<Producto>();
        if (File.Exists("Inventario.json"))
        {
            string LeerContenido = File.ReadAllText("Inventario.json");
            if (!string.IsNullOrEmpty(LeerContenido))
            {
                productos = JsonSerializer.Deserialize<List<Producto>>(LeerContenido) ?? new List<Producto>();
            }
        }

            productos.Add(producto);

            string jsonFinal = JsonSerializer.Serialize(productos, new JsonSerializerOptions { WriteIndented = true});
            File.WriteAllText("Invenrario.json", jsonFinal);

            foreach (Producto p in productos)
            {
                Console.WriteLine($"Código: {p.Codigo}, Nombre: {p.Nombre}, Cantidad: {p.Cantidad}, Precio: {p.Precio}");
            }
    }
}
