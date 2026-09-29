using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PuntoDeVentaTiendita;

public partial class Form1 : Form
{
    private static readonly Producto[] CatalogoProductos =
    {
        new("Coca-Cola 600ml",              18.00m),
        new("Sabritas Original 45g",        17.50m),
        new("Pan Bimbo Grande 680g",        52.00m),
        new("Leche Lala Entera 1L",         26.50m),
        new("Huevo San Juan 12pz",          38.00m),
        new("Galletas Marías 170g",         15.00m),
        new("Detergente Ariel 1kg",         65.00m),
        new("Jabón Zote Barra",             12.00m),
        new("Agua Ciel 1.5L",               14.00m),
        new("Café Nescafé Clásico 100g",    78.00m),
        new("Atún Dolores en agua 140g",    19.50m),
        new("Arroz Morelos 1kg",            28.00m),
    };

    private readonly List<LineaVenta> carrito = new();
    private readonly string carpetaVentas = string.Empty;

    public Form1()
    {
        InitializeComponent();

        // Evita que el diseñador visual de Visual Studio ejecute lógica de negocio
        // (icono, carpeta de ventas, catálogo) al abrir el formulario en modo diseño.
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
        {
            return;
        }

        carpetaVentas = Path.Combine(AppContext.BaseDirectory, "Ventas");
        Directory.CreateDirectory(carpetaVentas);

        AsignarIconoPersonalizado();

        foreach (var producto in CatalogoProductos)
        {
            cmbProducto.Items.Add($"{producto.Descripcion} - {producto.Precio.ToString("C2", CultureInfo.GetCultureInfo("es-MX"))}");
        }
        if (cmbProducto.Items.Count > 0)
        {
            cmbProducto.SelectedIndex = 0;
        }

        LimpiarCampos();
    }

    [DllImport("user32.dll")]
    private static extern bool DestroyIcon(IntPtr handle);

    /// <summary>
    /// Genera un icono en tiempo de ejecución (sin archivo .ico externo) para
    /// personalizar la ventana e identificar la app en la barra de tareas.
    /// </summary>
    private void AsignarIconoPersonalizado()
    {
        using var bitmap = new Bitmap(32, 32);
        using (var g = Graphics.FromImage(bitmap))
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using var fondo = new SolidBrush(Color.FromArgb(46, 125, 50));
            g.FillEllipse(fondo, 0, 0, 32, 32);
            using var fuente = new Font("Segoe UI", 14F, FontStyle.Bold);
            using var textoBrush = new SolidBrush(Color.White);
            g.DrawString("T", fuente, textoBrush, new PointF(8, 4));
        }

        IntPtr hIcon = bitmap.GetHicon();
        try
        {
            using var iconoTemporal = Icon.FromHandle(hIcon);
            this.Icon = (Icon)iconoTemporal.Clone();
        }
        finally
        {
            DestroyIcon(hIcon);
        }
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        if (cmbProducto.SelectedIndex < 0)
        {
            MessageBox.Show("Selecciona un producto.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var producto = CatalogoProductos[cmbProducto.SelectedIndex];
        int cantidad = (int)numCantidad.Value;

        var lineaExistente = carrito.Find(l => l.Producto.Descripcion == producto.Descripcion);
        if (lineaExistente != null)
        {
            lineaExistente.Cantidad += cantidad;
        }
        else
        {
            carrito.Add(new LineaVenta { Producto = producto, Cantidad = cantidad });
        }

        numCantidad.Value = 1;
        ActualizarCarritoEnPantalla();
    }

    private void btnQuitar_Click(object sender, EventArgs e)
    {
        if (lstCarrito.SelectedIndices.Count == 0)
        {
            return;
        }
        int indice = lstCarrito.SelectedIndices[0];
        carrito.RemoveAt(indice);
        ActualizarCarritoEnPantalla();
    }

    private void ActualizarCarritoEnPantalla()
    {
        lstCarrito.Items.Clear();
        foreach (var linea in carrito)
        {
            var item = new ListViewItem(linea.Producto.Descripcion);
            item.SubItems.Add(linea.Cantidad.ToString());
            item.SubItems.Add(linea.Producto.Precio.ToString("C2", CultureInfo.GetCultureInfo("es-MX")));
            item.SubItems.Add(linea.Importe.ToString("C2", CultureInfo.GetCultureInfo("es-MX")));
            lstCarrito.Items.Add(item);
        }

        var (subtotal, iva, total) = LogicaVenta.CalcularTotales(carrito);

        var cultura = CultureInfo.GetCultureInfo("es-MX");
        txtSubtotal.Text = subtotal.ToString("C2", cultura);
        txtIva.Text = iva.ToString("C2", cultura);
        txtTotal.Text = total.ToString("C2", cultura);
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        GuardarVenta();
    }

    /// <summary>
    /// Función para guardar el método: arma el contenido de la venta y lo escribe
    /// en un archivo TXT independiente (punto 9 y 10 del examen).
    /// </summary>
    private void GuardarVenta()
    {
        string usuario = txtUsuario.Text.Trim();
        string cliente = txtCliente.Text.Trim();

        string? error = LogicaVenta.ValidarVenta(usuario, cliente, carrito);
        if (error != null)
        {
            MessageBox.Show(error, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var cultura = CultureInfo.GetCultureInfo("es-MX");
        string folio = LogicaVenta.GenerarSiguienteFolio(carpetaVentas);
        string fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", cultura);
        var (_, _, total) = LogicaVenta.CalcularTotales(carrito);
        string contenido = LogicaVenta.ConstruirContenidoVenta(folio, fecha, usuario, cliente, carrito);

        string rutaArchivo = Path.Combine(carpetaVentas, LogicaVenta.NombreArchivo(folio));
        try
        {
            File.WriteAllText(rutaArchivo, contenido, System.Text.Encoding.UTF8);
        }
        catch (IOException ex)
        {
            MessageBox.Show("No se pudo guardar el archivo:\n" + ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        lblStatus.Text = $"Venta {folio} guardada en: {rutaArchivo}";
        MessageBox.Show($"Venta guardada con éxito.\n\nFolio: {folio}\nTotal: {total.ToString("C2", cultura)}\nArchivo: {rutaArchivo}",
            "Venta registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        LimpiarCampos();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        LimpiarCampos();
    }

    /// <summary>
    /// Función para limpiar los campos del formulario (punto 9 del examen).
    /// </summary>
    private void LimpiarCampos()
    {
        carrito.Clear();
        lstCarrito.Items.Clear();
        txtUsuario.Clear();
        txtCliente.Text = "Público en general";
        numCantidad.Value = 1;
        if (cmbProducto.Items.Count > 0)
        {
            cmbProducto.SelectedIndex = 0;
        }

        var cultura = CultureInfo.GetCultureInfo("es-MX");
        txtSubtotal.Text = 0m.ToString("C2", cultura);
        txtIva.Text = 0m.ToString("C2", cultura);
        txtTotal.Text = 0m.ToString("C2", cultura);

        txtFolio.Text = LogicaVenta.GenerarSiguienteFolio(carpetaVentas);
        txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", cultura);

        txtUsuario.Focus();
    }
}
