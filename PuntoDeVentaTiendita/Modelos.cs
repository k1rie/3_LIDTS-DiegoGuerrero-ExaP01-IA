using System.Globalization;
using System.Linq;

namespace PuntoDeVentaTiendita;

/// <summary>
/// Producto del catálogo de la tiendita (precio y descripción, punto 7 del examen).
/// </summary>
public record Producto(string Descripcion, decimal Precio);

/// <summary>
/// Línea de la venta actual (producto + cantidad agregados al carrito).
/// </summary>
public class LineaVenta
{
    public required Producto Producto { get; init; }
    public int Cantidad { get; set; }
    public decimal Importe => Producto.Precio * Cantidad;
}

/// <summary>
/// Reglas de negocio de la venta, separadas del formulario para poder probarlas
/// sin depender de la interfaz gráfica (WinForms).
/// </summary>
public static class LogicaVenta
{
    public const decimal PorcentajeIva = 0.16m;
    private static readonly CultureInfo Cultura = CultureInfo.GetCultureInfo("es-MX");

    public static (decimal Subtotal, decimal Iva, decimal Total) CalcularTotales(IEnumerable<LineaVenta> carrito)
    {
        decimal subtotal = carrito.Sum(l => l.Importe);
        decimal iva = subtotal * PorcentajeIva;
        return (subtotal, iva, subtotal + iva);
    }

    /// <summary>
    /// Calcula el siguiente folio de venta contando los archivos ya guardados en la carpeta Ventas.
    /// </summary>
    public static string GenerarSiguienteFolio(string carpetaVentas)
    {
        int siguiente = Directory.Exists(carpetaVentas)
            ? Directory.GetFiles(carpetaVentas, "Venta_*.txt").Length + 1
            : 1;
        return $"V-{siguiente:D4}";
    }

    /// <summary>
    /// Valida que la venta tenga la información mínima requerida antes de guardarla.
    /// </summary>
    public static string? ValidarVenta(string usuario, string cliente, IReadOnlyCollection<LineaVenta> carrito)
    {
        if (string.IsNullOrWhiteSpace(usuario))
        {
            return "El Usuario de Venta es obligatorio.";
        }
        if (string.IsNullOrWhiteSpace(cliente))
        {
            return "El Cliente es obligatorio.";
        }
        if (carrito.Count == 0)
        {
            return "Agrega al menos un producto a la venta.";
        }
        return null;
    }

    public static string ConstruirContenidoVenta(string folio, string fecha, string usuario, string cliente, IReadOnlyList<LineaVenta> carrito)
    {
        var (subtotal, iva, total) = CalcularTotales(carrito);

        var contenido = new System.Text.StringBuilder();
        contenido.AppendLine("===== TIENDITA EL BUEN PRECIO =====");
        contenido.AppendLine($"Folio de Venta : {folio}");
        contenido.AppendLine($"Fecha          : {fecha}");
        contenido.AppendLine($"Usuario Venta  : {usuario}");
        contenido.AppendLine($"Cliente        : {cliente}");
        contenido.AppendLine(new string('-', 60));
        contenido.AppendLine($"{"Producto",-35}{"Cant.",6}{"Importe",19}");
        foreach (var linea in carrito)
        {
            contenido.AppendLine($"{linea.Producto.Descripcion,-35}{linea.Cantidad,6}{linea.Importe.ToString("C2", Cultura),19}");
        }
        contenido.AppendLine(new string('-', 60));
        contenido.AppendLine($"{"Subtotal:",41}{subtotal.ToString("C2", Cultura),19}");
        contenido.AppendLine($"{"IVA (16%):",41}{iva.ToString("C2", Cultura),19}");
        contenido.AppendLine($"{"TOTAL:",41}{total.ToString("C2", Cultura),19}");
        contenido.AppendLine("====================================");
        return contenido.ToString();
    }

    public static string NombreArchivo(string folio) => $"Venta_{folio.Replace("V-", "")}.txt";
}
