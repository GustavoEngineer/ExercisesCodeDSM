using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Collections.Generic;
using System.Diagnostics;


public class Producto
{
    public int Id { get; set;}
    public string Nombre { get; set;}
    public int Cantidad { get; set;}
    public decimal Precio { get; set;}

    //Constructor
    public Producto(int id, string nombre, int cantidad, decimal precio)
    {
        this.Id = id;
        this.Nombre = nombre;
        this.Cantidad = cantidad;
        this.Precio = precio;
    }
}

public class NumberValidator1
{
    public static int GetPositiveInt()
    {
        string input = Console.ReadLine() ?? "";
        if (int.TryParse(input, out int num) && num > 0)
        {
            return num;
        }

        Console.WriteLine("Entrada inválida. Debe ser un número mayor que cero");
        return GetPositiveInt();
    }
}

public class NumberValidator2
{
    public static decimal GetNumberDecimal()
    {
        string entrada = Console.ReadLine() ?? "";
        if (decimal.TryParse(entrada, out decimal num) && num > 0)
        {
            return num;
        }

        Console.WriteLine("⚠️ Advertencia: Debes ingresar un número entero postivo");
        return GetNumberDecimal();
    }
}

class Program
{

    static void AgregarProducto()
        {
            Console.WriteLine("Ingresar el código del producto");
            int id = NumberValidator1.GetPositiveInt();
            Console.WriteLine("Ingresar el nombre del producto");
            string nombre = Console.ReadLine() ?? "";
            Console.WriteLine("Ingresar la cantidad del producto que hay en stock");
            int cantidad = NumberValidator1.GetPositiveInt();
            Console.WriteLine("Ingresar el precio del producto");
            decimal precio = NumberValidator2.GetNumberDecimal();

            Producto producto = new Producto(id, nombre, cantidad, precio);
            List<Producto> productoslista = new List<Producto>();

            if (File.Exists("Inventario.json"))
            {
                string LeerContenido = File.ReadAllText("Inventario.json");
                if(!string.IsNullOrEmpty(LeerContenido))
                {
                    productoslista = JsonSerializer.Deserialize<List<Producto>>(LeerContenido) ?? new List<Producto>();
                }

                bool IdValidator = productoslista.Exists(p => p.Id == id);
                if (IdValidator == true)
                {
                    Console.WriteLine("Ya existe un producto con ese ID. Intenta con otro.");
                    return;
                }
            }

            productoslista.Add(producto);

            string jsonFinal = JsonSerializer.Serialize(productoslista, new JsonSerializerOptions { WriteIndented = true});
            File.WriteAllText("Inventario.json", jsonFinal);

            foreach (Producto p in productoslista)
            {
                Console.WriteLine($"\nID: {p.Id}\nNombre: {p.Nombre}\nCantidad en Stock: {p.Cantidad}\nPrecio: {p.Precio}");
            }
        }

static void BuscarProducto()
{
    Console.WriteLine("Ingresar el nombre del producto que quieres buscar");
    string nombreBuscado = Console.ReadLine() ?? "";

    if(!File.Exists("Inventario.json"))
    {
        Console.WriteLine("No hay productos registrados");
    }

    var leerContenido = File.ReadAllText("Inventario.json");
    var obtenerProductos = JsonSerializer.Deserialize<List<Producto>>(leerContenido) ?? new List<Producto>();
    var productosEncontrados = obtenerProductos.Where(p => p.Nombre.Contains(nombreBuscado, StringComparison.OrdinalIgnoreCase)).ToList();

    if (productosEncontrados.Count == 0)
    {
        Console.WriteLine("⚠️ Advertencia: No se ha encontrado el producto que estás buscando");
    }

    Console.WriteLine("\nProductos Encontrados");
    foreach(var p in productosEncontrados)
    {
        Console.WriteLine($"\nID: {p.Id}\nNombre: {p.Nombre}\nCantidad en Stock: {p.Cantidad}\nPrecio: {p.Precio}");
    }    
}

static void ComprarProducto()
{
    Console.WriteLine("🛒 Escribe el ID del producto que deseas comprar:");
    int id = NumberValidator1.GetPositiveInt();

        if (!File.Exists("Inventario.json"))
        {
            Console.WriteLine("No hay productos registrados.");
            return;
        }

        var leerContenido = File.ReadAllText("Inventario.json");
        var obtenerProductos = JsonSerializer.Deserialize<List<Producto>>(leerContenido) ?? new List<Producto>();

        var buscarProducto = obtenerProductos.Find(p => p.Id == id);
        if (buscarProducto == null)
        {
            Console.WriteLine("No se encontró ese producto.");
            return;
        }

        Console.WriteLine($"¿Cuántas unidades deseas comprar? (Stock disponible: {buscarProducto.Cantidad})");
        int cantidadCompra = NumberValidator1.GetPositiveInt();

        if (cantidadCompra > buscarProducto.Cantidad)
        {
            Console.WriteLine("No hay suficiente stock disponible.");
            return;
        }

        buscarProducto.Cantidad -= cantidadCompra;

        Console.WriteLine("¿Quieres pagar este producto?");
        string eleccion = Console.ReadLine() ?? "".ToLower();
        if (eleccion == "si")
        {
            Console.Write("Ingresar dinero: ");
            decimal dinero = NumberValidator2.GetNumberDecimal();
            decimal totalPagar = buscarProducto.Precio * cantidadCompra;

            
            if (dinero < buscarProducto.Precio)
            {
                Console.WriteLine("⚠️ Advertencia: Dinero insuficiente");
            } else
            {
                decimal cambio = dinero - totalPagar;
                Console.WriteLine($"Haz dado: ${dinero} pesos\nCambio: {cambio}");
                Console.WriteLine($"Compra realizada por ${totalPagar}. Gracias por tu compra!");
            }
        } else
        {
            Console.WriteLine("Compra no finalizada\n");
        }


        string jsonFinal = JsonSerializer.Serialize(obtenerProductos, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("Inventario.json", jsonFinal);

        
}

    static void Main(string[] args)
    {
    Console.WriteLine("Bienvenido a tu tienda virtual\n");

    while (true)
    {
        Console.WriteLine("Elegir una opción\n1. Agregar Producto\n2. Buscar Pruducto\n3. Comprar\n4. Salir");
        string opcion = Console.ReadLine() ?? "";

        switch (opcion)
        {
            case "1":
                AgregarProducto();
                break;
            case "2":
                BuscarProducto();
                break;
            case "3":
                ComprarProducto();
                break;
            case "4":
                return;
            default:
                Console.WriteLine("⚠️ Advertencia: Elige una opcón correcta (1-3)");
                break;
        }
    }

    }
}