namespace Ejercicio0002.Windows
{
    partial class frmDetalles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtpFechaIngre = new DateTimePicker();
            lblFechaIngres = new Label();
            chkActivo = new CheckBox();
            btnOK = new Button();
            txtPrecioProducto = new TextBox();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            lblPrecio = new Label();
            grbProductos = new GroupBox();
            txtStock = new TextBox();
            lblStock = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            grbProductos.SuspendLayout();
            SuspendLayout();
            // 
            // dtpFechaIngre
            // 
            dtpFechaIngre.Enabled = false;
            dtpFechaIngre.Format = DateTimePickerFormat.Short;
            dtpFechaIngre.Location = new Point(127, 192);
            dtpFechaIngre.Name = "dtpFechaIngre";
            dtpFechaIngre.Size = new Size(81, 23);
            dtpFechaIngre.TabIndex = 17;
            // 
            // lblFechaIngres
            // 
            lblFechaIngres.AutoSize = true;
            lblFechaIngres.Location = new Point(0, 192);
            lblFechaIngres.Name = "lblFechaIngres";
            lblFechaIngres.Size = new Size(83, 15);
            lblFechaIngres.TabIndex = 16;
            lblFechaIngres.Text = "Fecha Ingreso:";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Enabled = false;
            chkActivo.Location = new Point(324, 22);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 11;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(184, 232);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 67);
            btnOK.TabIndex = 15;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Enabled = false;
            txtPrecioProducto.Location = new Point(127, 95);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(142, 23);
            txtPrecioProducto.TabIndex = 13;
            // 
            // txtCantidad
            // 
            txtCantidad.Enabled = false;
            txtCantidad.Location = new Point(127, 123);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(142, 23);
            txtCantidad.TabIndex = 2;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(0, 126);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(0, 98);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 12;
            lblPrecio.Text = "Precio:";
            // 
            // grbProductos
            // 
            grbProductos.Controls.Add(dtpFechaIngre);
            grbProductos.Controls.Add(txtStock);
            grbProductos.Controls.Add(lblFechaIngres);
            grbProductos.Controls.Add(lblStock);
            grbProductos.Controls.Add(txtCantidad);
            grbProductos.Controls.Add(txtDescripcion);
            grbProductos.Controls.Add(lblDescripcion);
            grbProductos.Controls.Add(txtCodigo);
            grbProductos.Controls.Add(lblCantidad);
            grbProductos.Controls.Add(lblCodigo);
            grbProductos.Controls.Add(lblPrecio);
            grbProductos.Controls.Add(txtPrecioProducto);
            grbProductos.Location = new Point(4, 4);
            grbProductos.Name = "grbProductos";
            grbProductos.Size = new Size(296, 233);
            grbProductos.TabIndex = 9;
            grbProductos.TabStop = false;
            grbProductos.Text = "Producto";
            // 
            // txtStock
            // 
            txtStock.Enabled = false;
            txtStock.Location = new Point(127, 152);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(142, 23);
            txtStock.TabIndex = 15;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(0, 156);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(39, 15);
            lblStock.TabIndex = 14;
            lblStock.Text = "Stock:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(127, 65);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(142, 23);
            txtDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(0, 68);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(124, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion Producto:";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(127, 34);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(142, 23);
            txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(0, 34);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(101, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo Producto:";
            // 
            // frmDetalles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 311);
            Controls.Add(chkActivo);
            Controls.Add(btnOK);
            Controls.Add(grbProductos);
            Name = "frmDetalles";
            Text = "frmDetalles";
            Load += frmDetalles_Load;
            grbProductos.ResumeLayout(false);
            grbProductos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFechaIngre;
        private Label lblFechaIngres;
        private CheckBox chkActivo;
        private Button btnOK;
        private TextBox txtPrecioProducto;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private Label lblPrecio;
        private GroupBox grbProductos;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private TextBox txtStock;
        private Label lblStock;
    }
}