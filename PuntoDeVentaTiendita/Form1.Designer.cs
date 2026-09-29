namespace PuntoDeVentaTiendita;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private Panel panelHeader;
    private Label lblTitulo;
    private Label lblFolioCap;
    private TextBox txtFolio;
    private Label lblFechaCap;
    private TextBox txtFecha;
    private Label lblUsuarioCap;
    private TextBox txtUsuario;
    private Label lblClienteCap;
    private TextBox txtCliente;
    private GroupBox groupProductos;
    private Label lblProductoCap;
    private ComboBox cmbProducto;
    private Label lblCantidadCap;
    private NumericUpDown numCantidad;
    private Button btnAgregar;
    private ListView lstCarrito;
    private ColumnHeader colProducto;
    private ColumnHeader colCantidad;
    private ColumnHeader colPrecioUnit;
    private ColumnHeader colImporte;
    private Button btnQuitar;
    private Label lblSubtotalCap;
    private TextBox txtSubtotal;
    private Label lblIvaCap;
    private TextBox txtIva;
    private Label lblTotalCap;
    private TextBox txtTotal;
    private Button btnGuardar;
    private Button btnLimpiar;
    private Label lblStatus;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.panelHeader = new Panel();
        this.lblTitulo = new Label();
        this.lblFolioCap = new Label();
        this.txtFolio = new TextBox();
        this.lblFechaCap = new Label();
        this.txtFecha = new TextBox();
        this.lblUsuarioCap = new Label();
        this.txtUsuario = new TextBox();
        this.lblClienteCap = new Label();
        this.txtCliente = new TextBox();
        this.groupProductos = new GroupBox();
        this.lblProductoCap = new Label();
        this.cmbProducto = new ComboBox();
        this.lblCantidadCap = new Label();
        this.numCantidad = new NumericUpDown();
        this.btnAgregar = new Button();
        this.lstCarrito = new ListView();
        this.colProducto = new ColumnHeader();
        this.colCantidad = new ColumnHeader();
        this.colPrecioUnit = new ColumnHeader();
        this.colImporte = new ColumnHeader();
        this.btnQuitar = new Button();
        this.lblSubtotalCap = new Label();
        this.txtSubtotal = new TextBox();
        this.lblIvaCap = new Label();
        this.txtIva = new TextBox();
        this.lblTotalCap = new Label();
        this.txtTotal = new TextBox();
        this.btnGuardar = new Button();
        this.btnLimpiar = new Button();
        this.lblStatus = new Label();
        this.groupProductos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
        this.SuspendLayout();
        //
        // panelHeader
        //
        this.panelHeader.BackColor = Color.FromArgb(46, 125, 50);
        this.panelHeader.Dock = DockStyle.Top;
        this.panelHeader.Location = new Point(0, 0);
        this.panelHeader.Name = "panelHeader";
        this.panelHeader.Size = new Size(900, 64);
        this.panelHeader.TabIndex = 0;
        this.panelHeader.Controls.Add(this.lblTitulo);
        //
        // lblTitulo
        //
        this.lblTitulo.AutoSize = true;
        this.lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        this.lblTitulo.ForeColor = Color.White;
        this.lblTitulo.Location = new Point(20, 12);
        this.lblTitulo.Name = "lblTitulo";
        this.lblTitulo.Size = new Size(300, 32);
        this.lblTitulo.TabIndex = 0;
        this.lblTitulo.Text = "Tiendita El Buen Precio";
        //
        // lblFolioCap
        //
        this.lblFolioCap.AutoSize = true;
        this.lblFolioCap.Font = new Font("Segoe UI", 10F);
        this.lblFolioCap.Location = new Point(20, 82);
        this.lblFolioCap.Name = "lblFolioCap";
        this.lblFolioCap.Size = new Size(96, 19);
        this.lblFolioCap.TabIndex = 1;
        this.lblFolioCap.Text = "Folio de Venta:";
        //
        // txtFolio
        //
        this.txtFolio.Font = new Font("Segoe UI", 10F);
        this.txtFolio.Location = new Point(140, 79);
        this.txtFolio.Name = "txtFolio";
        this.txtFolio.ReadOnly = true;
        this.txtFolio.Size = new Size(130, 25);
        this.txtFolio.TabIndex = 2;
        this.txtFolio.TabStop = false;
        this.txtFolio.BackColor = Color.WhiteSmoke;
        //
        // lblFechaCap
        //
        this.lblFechaCap.AutoSize = true;
        this.lblFechaCap.Font = new Font("Segoe UI", 10F);
        this.lblFechaCap.Location = new Point(300, 82);
        this.lblFechaCap.Name = "lblFechaCap";
        this.lblFechaCap.Size = new Size(52, 19);
        this.lblFechaCap.TabIndex = 3;
        this.lblFechaCap.Text = "Fecha:";
        //
        // txtFecha
        //
        this.txtFecha.Font = new Font("Segoe UI", 10F);
        this.txtFecha.Location = new Point(360, 79);
        this.txtFecha.Name = "txtFecha";
        this.txtFecha.ReadOnly = true;
        this.txtFecha.Size = new Size(190, 25);
        this.txtFecha.TabIndex = 4;
        this.txtFecha.TabStop = false;
        this.txtFecha.BackColor = Color.WhiteSmoke;
        //
        // lblUsuarioCap
        //
        this.lblUsuarioCap.AutoSize = true;
        this.lblUsuarioCap.Font = new Font("Segoe UI", 10F);
        this.lblUsuarioCap.Location = new Point(20, 120);
        this.lblUsuarioCap.Name = "lblUsuarioCap";
        this.lblUsuarioCap.Size = new Size(120, 19);
        this.lblUsuarioCap.TabIndex = 5;
        this.lblUsuarioCap.Text = "Usuario de Venta:";
        //
        // txtUsuario
        //
        this.txtUsuario.Font = new Font("Segoe UI", 10F);
        this.txtUsuario.Location = new Point(150, 117);
        this.txtUsuario.Name = "txtUsuario";
        this.txtUsuario.Size = new Size(280, 25);
        this.txtUsuario.TabIndex = 6;
        //
        // lblClienteCap
        //
        this.lblClienteCap.AutoSize = true;
        this.lblClienteCap.Font = new Font("Segoe UI", 10F);
        this.lblClienteCap.Location = new Point(450, 120);
        this.lblClienteCap.Name = "lblClienteCap";
        this.lblClienteCap.Size = new Size(58, 19);
        this.lblClienteCap.TabIndex = 7;
        this.lblClienteCap.Text = "Cliente:";
        //
        // txtCliente
        //
        this.txtCliente.Font = new Font("Segoe UI", 10F);
        this.txtCliente.Location = new Point(515, 117);
        this.txtCliente.Name = "txtCliente";
        this.txtCliente.Size = new Size(280, 25);
        this.txtCliente.TabIndex = 8;
        this.txtCliente.Text = "Público en general";
        //
        // groupProductos
        //
        this.groupProductos.Font = new Font("Segoe UI", 9.5F);
        this.groupProductos.Location = new Point(20, 160);
        this.groupProductos.Name = "groupProductos";
        this.groupProductos.Size = new Size(860, 210);
        this.groupProductos.TabIndex = 9;
        this.groupProductos.TabStop = false;
        this.groupProductos.Text = "Productos de la venta";
        this.groupProductos.Controls.Add(this.lblProductoCap);
        this.groupProductos.Controls.Add(this.cmbProducto);
        this.groupProductos.Controls.Add(this.lblCantidadCap);
        this.groupProductos.Controls.Add(this.numCantidad);
        this.groupProductos.Controls.Add(this.btnAgregar);
        this.groupProductos.Controls.Add(this.lstCarrito);
        this.groupProductos.Controls.Add(this.btnQuitar);
        //
        // lblProductoCap
        //
        this.lblProductoCap.AutoSize = true;
        this.lblProductoCap.Location = new Point(15, 32);
        this.lblProductoCap.Name = "lblProductoCap";
        this.lblProductoCap.Size = new Size(68, 19);
        this.lblProductoCap.TabIndex = 0;
        this.lblProductoCap.Text = "Producto:";
        //
        // cmbProducto
        //
        this.cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
        this.cmbProducto.Font = new Font("Segoe UI", 9.5F);
        this.cmbProducto.Location = new Point(95, 29);
        this.cmbProducto.Name = "cmbProducto";
        this.cmbProducto.Size = new Size(400, 25);
        this.cmbProducto.TabIndex = 1;
        //
        // lblCantidadCap
        //
        this.lblCantidadCap.AutoSize = true;
        this.lblCantidadCap.Location = new Point(510, 32);
        this.lblCantidadCap.Name = "lblCantidadCap";
        this.lblCantidadCap.Size = new Size(68, 19);
        this.lblCantidadCap.TabIndex = 2;
        this.lblCantidadCap.Text = "Cantidad:";
        //
        // numCantidad
        //
        this.numCantidad.Font = new Font("Segoe UI", 9.5F);
        this.numCantidad.Location = new Point(585, 29);
        this.numCantidad.Maximum = new decimal(999);
        this.numCantidad.Minimum = new decimal(1);
        this.numCantidad.Name = "numCantidad";
        this.numCantidad.Size = new Size(60, 25);
        this.numCantidad.TabIndex = 3;
        this.numCantidad.Value = new decimal(1);
        //
        // btnAgregar
        //
        this.btnAgregar.BackColor = Color.FromArgb(255, 152, 0);
        this.btnAgregar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        this.btnAgregar.ForeColor = Color.White;
        this.btnAgregar.Location = new Point(665, 27);
        this.btnAgregar.Name = "btnAgregar";
        this.btnAgregar.Size = new Size(160, 30);
        this.btnAgregar.TabIndex = 4;
        this.btnAgregar.Text = "Agregar a la venta";
        this.btnAgregar.UseVisualStyleBackColor = false;
        this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
        //
        // lstCarrito
        //
        this.lstCarrito.Columns.AddRange(new ColumnHeader[] {
            this.colProducto, this.colCantidad, this.colPrecioUnit, this.colImporte});
        this.lstCarrito.View = View.Details;
        this.lstCarrito.FullRowSelect = true;
        this.lstCarrito.GridLines = true;
        this.lstCarrito.HideSelection = false;
        this.lstCarrito.Font = new Font("Segoe UI", 9.5F);
        this.lstCarrito.Location = new Point(15, 65);
        this.lstCarrito.MultiSelect = false;
        this.lstCarrito.Name = "lstCarrito";
        this.lstCarrito.Size = new Size(810, 105);
        this.lstCarrito.TabIndex = 5;
        this.lstCarrito.UseCompatibleStateImageBehavior = false;
        //
        // colProducto
        //
        this.colProducto.Text = "Producto";
        this.colProducto.Width = 380;
        //
        // colCantidad
        //
        this.colCantidad.Text = "Cantidad";
        this.colCantidad.Width = 90;
        //
        // colPrecioUnit
        //
        this.colPrecioUnit.Text = "P. Unitario";
        this.colPrecioUnit.Width = 130;
        //
        // colImporte
        //
        this.colImporte.Text = "Importe";
        this.colImporte.Width = 130;
        //
        // btnQuitar
        //
        this.btnQuitar.Font = new Font("Segoe UI", 9F);
        this.btnQuitar.Location = new Point(15, 175);
        this.btnQuitar.Name = "btnQuitar";
        this.btnQuitar.Size = new Size(180, 27);
        this.btnQuitar.TabIndex = 6;
        this.btnQuitar.Text = "Quitar producto seleccionado";
        this.btnQuitar.UseVisualStyleBackColor = true;
        this.btnQuitar.Click += new EventHandler(this.btnQuitar_Click);
        //
        // lblSubtotalCap
        //
        this.lblSubtotalCap.AutoSize = true;
        this.lblSubtotalCap.Font = new Font("Segoe UI", 10F);
        this.lblSubtotalCap.Location = new Point(560, 385);
        this.lblSubtotalCap.Name = "lblSubtotalCap";
        this.lblSubtotalCap.Size = new Size(69, 19);
        this.lblSubtotalCap.TabIndex = 10;
        this.lblSubtotalCap.Text = "Subtotal:";
        //
        // txtSubtotal
        //
        this.txtSubtotal.Font = new Font("Segoe UI", 10F);
        this.txtSubtotal.Location = new Point(660, 382);
        this.txtSubtotal.Name = "txtSubtotal";
        this.txtSubtotal.ReadOnly = true;
        this.txtSubtotal.Size = new Size(150, 25);
        this.txtSubtotal.TabIndex = 11;
        this.txtSubtotal.TabStop = false;
        this.txtSubtotal.TextAlign = HorizontalAlignment.Right;
        this.txtSubtotal.Text = "$0.00";
        this.txtSubtotal.BackColor = Color.WhiteSmoke;
        //
        // lblIvaCap
        //
        this.lblIvaCap.AutoSize = true;
        this.lblIvaCap.Font = new Font("Segoe UI", 10F);
        this.lblIvaCap.Location = new Point(560, 415);
        this.lblIvaCap.Name = "lblIvaCap";
        this.lblIvaCap.Size = new Size(80, 19);
        this.lblIvaCap.TabIndex = 12;
        this.lblIvaCap.Text = "IVA (16%):";
        //
        // txtIva
        //
        this.txtIva.Font = new Font("Segoe UI", 10F);
        this.txtIva.Location = new Point(660, 412);
        this.txtIva.Name = "txtIva";
        this.txtIva.ReadOnly = true;
        this.txtIva.Size = new Size(150, 25);
        this.txtIva.TabIndex = 13;
        this.txtIva.TabStop = false;
        this.txtIva.TextAlign = HorizontalAlignment.Right;
        this.txtIva.Text = "$0.00";
        this.txtIva.BackColor = Color.WhiteSmoke;
        //
        // lblTotalCap
        //
        this.lblTotalCap.AutoSize = true;
        this.lblTotalCap.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        this.lblTotalCap.Location = new Point(560, 448);
        this.lblTotalCap.Name = "lblTotalCap";
        this.lblTotalCap.Size = new Size(76, 25);
        this.lblTotalCap.TabIndex = 14;
        this.lblTotalCap.Text = "TOTAL:";
        //
        // txtTotal
        //
        this.txtTotal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        this.txtTotal.ForeColor = Color.FromArgb(46, 125, 50);
        this.txtTotal.Location = new Point(660, 445);
        this.txtTotal.Name = "txtTotal";
        this.txtTotal.ReadOnly = true;
        this.txtTotal.Size = new Size(150, 32);
        this.txtTotal.TabIndex = 15;
        this.txtTotal.TabStop = false;
        this.txtTotal.TextAlign = HorizontalAlignment.Right;
        this.txtTotal.Text = "$0.00";
        this.txtTotal.BackColor = Color.WhiteSmoke;
        //
        // btnGuardar
        //
        this.btnGuardar.BackColor = Color.FromArgb(46, 125, 50);
        this.btnGuardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        this.btnGuardar.ForeColor = Color.White;
        this.btnGuardar.Location = new Point(560, 500);
        this.btnGuardar.Name = "btnGuardar";
        this.btnGuardar.Size = new Size(150, 42);
        this.btnGuardar.TabIndex = 16;
        this.btnGuardar.Text = "Guardar Venta";
        this.btnGuardar.UseVisualStyleBackColor = false;
        this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
        //
        // btnLimpiar
        //
        this.btnLimpiar.BackColor = Color.FromArgb(117, 117, 117);
        this.btnLimpiar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        this.btnLimpiar.ForeColor = Color.White;
        this.btnLimpiar.Location = new Point(725, 500);
        this.btnLimpiar.Name = "btnLimpiar";
        this.btnLimpiar.Size = new Size(150, 42);
        this.btnLimpiar.TabIndex = 17;
        this.btnLimpiar.Text = "Limpiar";
        this.btnLimpiar.UseVisualStyleBackColor = false;
        this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
        //
        // lblStatus
        //
        this.lblStatus.AutoSize = true;
        this.lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
        this.lblStatus.ForeColor = Color.DimGray;
        this.lblStatus.Location = new Point(20, 555);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new Size(300, 19);
        this.lblStatus.TabIndex = 18;
        this.lblStatus.Text = "";
        //
        // Form1
        //
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(255, 248, 225);
        this.ClientSize = new Size(900, 600);
        this.Font = new Font("Segoe UI", 9.5F);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "Form1";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Punto de Venta - Tiendita El Buen Precio";
        this.Controls.Add(this.lblStatus);
        this.Controls.Add(this.btnLimpiar);
        this.Controls.Add(this.btnGuardar);
        this.Controls.Add(this.txtTotal);
        this.Controls.Add(this.lblTotalCap);
        this.Controls.Add(this.txtIva);
        this.Controls.Add(this.lblIvaCap);
        this.Controls.Add(this.txtSubtotal);
        this.Controls.Add(this.lblSubtotalCap);
        this.Controls.Add(this.groupProductos);
        this.Controls.Add(this.txtCliente);
        this.Controls.Add(this.lblClienteCap);
        this.Controls.Add(this.txtUsuario);
        this.Controls.Add(this.lblUsuarioCap);
        this.Controls.Add(this.txtFecha);
        this.Controls.Add(this.lblFechaCap);
        this.Controls.Add(this.txtFolio);
        this.Controls.Add(this.lblFolioCap);
        this.Controls.Add(this.panelHeader);
        this.groupProductos.ResumeLayout(false);
        this.groupProductos.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
}
