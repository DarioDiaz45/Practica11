namespace Ejercicio0002.Windows
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            tlsProductos = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbDetalles = new ToolStripButton();
            tsbFiltrar = new ToolStripDropDownButton();
            cantidadToolStripMenuItem = new ToolStripMenuItem();
            tcboCantidad = new ToolStripComboBox();
            precioToolStripMenuItem = new ToolStripMenuItem();
            tcboPrecio = new ToolStripComboBox();
            descripcionToolStripMenuItem = new ToolStripMenuItem();
            tcboDescripcion = new ToolStripComboBox();
            tsbBuscar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            panel1 = new Panel();
            txtCantidad = new TextBox();
            lblCantidadProduc = new Label();
            pnlGrilla = new Panel();
            dgvProductos = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecioUnitario = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewTextBoxColumn();
            tlsProductos.SuspendLayout();
            panel1.SuspendLayout();
            pnlGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // tlsProductos
            // 
            tlsProductos.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbDetalles, tsbFiltrar, tsbBuscar, tsbActualizar, toolStripSeparator2, tsbSalir });
            tlsProductos.Location = new Point(0, 0);
            tlsProductos.Name = "tlsProductos";
            tlsProductos.Size = new Size(713, 72);
            tlsProductos.TabIndex = 0;
            tlsProductos.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = Properties.Resources.add_file_48px;
            tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(52, 69);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = Properties.Resources.delete_file_48px;
            tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(52, 69);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = Properties.Resources.edit_file_48px;
            tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(52, 69);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += tsbEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 72);
            // 
            // tsbDetalles
            // 
            tsbDetalles.Image = Properties.Resources.More_Details;
            tsbDetalles.ImageScaling = ToolStripItemImageScaling.None;
            tsbDetalles.ImageTransparentColor = Color.Magenta;
            tsbDetalles.Name = "tsbDetalles";
            tsbDetalles.Size = new Size(52, 69);
            tsbDetalles.Text = "Detalles";
            tsbDetalles.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbDetalles.Click += tsbDetalles_Click;
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.DropDownItems.AddRange(new ToolStripItem[] { cantidadToolStripMenuItem, precioToolStripMenuItem, descripcionToolStripMenuItem });
            tsbFiltrar.Image = (Image)resources.GetObject("tsbFiltrar.Image");
            tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(63, 69);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextDirection = ToolStripTextDirection.Horizontal;
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbFiltrar.ToolTipText = "toolstripbutton\r\n";
            // 
            // cantidadToolStripMenuItem
            // 
            cantidadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tcboCantidad });
            cantidadToolStripMenuItem.Name = "cantidadToolStripMenuItem";
            cantidadToolStripMenuItem.Size = new Size(180, 22);
            cantidadToolStripMenuItem.Text = "Cantidad";
            // 
            // tcboCantidad
            // 
            tcboCantidad.Name = "tcboCantidad";
            tcboCantidad.Size = new Size(121, 23);
            // 
            // precioToolStripMenuItem
            // 
            precioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tcboPrecio });
            precioToolStripMenuItem.Name = "precioToolStripMenuItem";
            precioToolStripMenuItem.Size = new Size(180, 22);
            precioToolStripMenuItem.Text = "Precio";
            // 
            // tcboPrecio
            // 
            tcboPrecio.Name = "tcboPrecio";
            tcboPrecio.Size = new Size(121, 23);
            // 
            // descripcionToolStripMenuItem
            // 
            descripcionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tcboDescripcion });
            descripcionToolStripMenuItem.Name = "descripcionToolStripMenuItem";
            descripcionToolStripMenuItem.Size = new Size(180, 22);
            descripcionToolStripMenuItem.Text = "Descripcion";
            // 
            // tcboDescripcion
            // 
            tcboDescripcion.Name = "tcboDescripcion";
            tcboDescripcion.Size = new Size(121, 23);
            // 
            // tsbBuscar
            // 
            tsbBuscar.Image = Properties.Resources.View1;
            tsbBuscar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBuscar.ImageTransparentColor = Color.Magenta;
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(52, 69);
            tsbBuscar.Text = "Buscar";
            tsbBuscar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = Properties.Resources.Refresh;
            tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 69);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbActualizar.Click += tsbActualizar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 72);
            // 
            // tsbSalir
            // 
            tsbSalir.Image = Properties.Resources.Export;
            tsbSalir.ImageScaling = ToolStripItemImageScaling.None;
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(52, 69);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += tsbSalir_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(lblCantidadProduc);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 331);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 72);
            panel1.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(130, 26);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(99, 23);
            txtCantidad.TabIndex = 1;
            // 
            // lblCantidadProduc
            // 
            lblCantidadProduc.AutoSize = true;
            lblCantidadProduc.Location = new Point(3, 29);
            lblCantidadProduc.Name = "lblCantidadProduc";
            lblCantidadProduc.Size = new Size(112, 15);
            lblCantidadProduc.TabIndex = 0;
            lblCantidadProduc.Text = "Cantidad Productos";
            // 
            // pnlGrilla
            // 
            pnlGrilla.Controls.Add(dgvProductos);
            pnlGrilla.Dock = DockStyle.Fill;
            pnlGrilla.Location = new Point(0, 72);
            pnlGrilla.Name = "pnlGrilla";
            pnlGrilla.Size = new Size(713, 259);
            pnlGrilla.TabIndex = 2;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colDescripcion, colCantidad, colPrecioUnitario, colActivo });
            dgvProductos.Dock = DockStyle.Fill;
            dgvProductos.Location = new Point(0, 0);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(713, 259);
            dgvProductos.TabIndex = 0;
            // 
            // colCodigo
            // 
            colCodigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCodigo.HeaderText = "Codigo";
            colCodigo.Name = "colCodigo";
            // 
            // colDescripcion
            // 
            colDescripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDescripcion.HeaderText = "Descripcion";
            colDescripcion.Name = "colDescripcion";
            // 
            // colCantidad
            // 
            colCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            colCantidad.Width = 80;
            // 
            // colPrecioUnitario
            // 
            colPrecioUnitario.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colPrecioUnitario.HeaderText = "Precio Unitario";
            colPrecioUnitario.Name = "colPrecioUnitario";
            colPrecioUnitario.Width = 101;
            // 
            // colActivo
            // 
            colActivo.HeaderText = "Prod.Activo";
            colActivo.Name = "colActivo";
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 403);
            Controls.Add(pnlGrilla);
            Controls.Add(panel1);
            Controls.Add(tlsProductos);
            Name = "frmProductos";
            Text = "Productos";
            Load += Productos_Load;
            tlsProductos.ResumeLayout(false);
            tlsProductos.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tlsProductos;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbBuscar;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbSalir;
        private Panel panel1;
        private TextBox txtCantidad;
        private Label lblCantidadProduc;
        private Panel pnlGrilla;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecioUnitario;
        private DataGridViewTextBoxColumn colActivo;
        private ToolStripButton tsbDetalles;
        private ToolStripDropDownButton tsbFiltrar;
        private ToolStripMenuItem cantidadToolStripMenuItem;
        private ToolStripComboBox tcboCantidad;
        private ToolStripMenuItem precioToolStripMenuItem;
        private ToolStripComboBox tcboPrecio;
        private ToolStripMenuItem descripcionToolStripMenuItem;
        private ToolStripComboBox tcboDescripcion;
    }
}