namespace Ejercicio0002.Windows
{
    partial class frmProductosAE
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
            components = new System.ComponentModel.Container();
            grbProductos = new GroupBox();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            lblCantidad = new Label();
            grbStock = new GroupBox();
            rbtNo = new RadioButton();
            rbtSi = new RadioButton();
            lblPrecio = new Label();
            txtPrecioProducto = new TextBox();
            btnOK = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            chkActivo = new CheckBox();
            label1 = new Label();
            dtpFechaIngre = new DateTimePicker();
            txtCantidad = new TextBox();
            grbProductos.SuspendLayout();
            grbStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // grbProductos
            // 
            grbProductos.Controls.Add(txtDescripcion);
            grbProductos.Controls.Add(lblDescripcion);
            grbProductos.Controls.Add(txtCodigo);
            grbProductos.Controls.Add(lblCodigo);
            grbProductos.Location = new Point(12, 12);
            grbProductos.Name = "grbProductos";
            grbProductos.Size = new Size(296, 160);
            grbProductos.TabIndex = 0;
            grbProductos.TabStop = false;
            grbProductos.Text = "Producto";
            // 
            // txtDescripcion
            // 
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
            lblDescripcion.Size = new Size(121, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion Producto";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(127, 34);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(142, 23);
            txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(8, 37);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(101, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo Producto:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(0, 98);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "Cantidad";
            // 
            // grbStock
            // 
            grbStock.Controls.Add(txtCantidad);
            grbStock.Controls.Add(rbtNo);
            grbStock.Controls.Add(rbtSi);
            grbStock.Controls.Add(lblCantidad);
            grbStock.Location = new Point(334, 22);
            grbStock.Name = "grbStock";
            grbStock.Size = new Size(198, 150);
            grbStock.TabIndex = 3;
            grbStock.TabStop = false;
            grbStock.Text = "En Stock";
            // 
            // rbtNo
            // 
            rbtNo.AutoSize = true;
            rbtNo.Location = new Point(6, 51);
            rbtNo.Name = "rbtNo";
            rbtNo.Size = new Size(41, 19);
            rbtNo.TabIndex = 1;
            rbtNo.Text = "No";
            rbtNo.UseVisualStyleBackColor = true;
            // 
            // rbtSi
            // 
            rbtSi.AutoSize = true;
            rbtSi.Checked = true;
            rbtSi.Location = new Point(6, 25);
            rbtSi.Name = "rbtSi";
            rbtSi.Size = new Size(34, 19);
            rbtSi.TabIndex = 0;
            rbtSi.TabStop = true;
            rbtSi.Text = "Si";
            rbtSi.UseVisualStyleBackColor = true;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(20, 185);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio:";
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(69, 182);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(100, 23);
            txtPrecioProducto.TabIndex = 5;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(94, 255);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 67);
            btnOK.TabIndex = 6;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(395, 255);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 67);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += Cancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(20, 220);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 4;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(334, 185);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 7;
            label1.Text = "Fecha Ingreso";
            // 
            // dtpFechaIngre
            // 
            dtpFechaIngre.Format = DateTimePickerFormat.Short;
            dtpFechaIngre.Location = new Point(420, 182);
            dtpFechaIngre.Name = "dtpFechaIngre";
            dtpFechaIngre.Size = new Size(83, 23);
            dtpFechaIngre.TabIndex = 8;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(61, 95);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(117, 23);
            txtCantidad.TabIndex = 2;
            // 
            // frmProductosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 351);
            Controls.Add(dtpFechaIngre);
            Controls.Add(label1);
            Controls.Add(chkActivo);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtPrecioProducto);
            Controls.Add(grbStock);
            Controls.Add(lblPrecio);
            Controls.Add(grbProductos);
            Name = "frmProductosAE";
            Text = "ProductosAE";
            Load += frmProductosAE_Load;
            grbProductos.ResumeLayout(false);
            grbProductos.PerformLayout();
            grbStock.ResumeLayout(false);
            grbStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbProductos;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private Label lblCantidad;
        private GroupBox grbStock;
        private RadioButton rbtNo;
        private RadioButton rbtSi;
        private Label lblPrecio;
        private TextBox txtPrecioProducto;
        private Button btnOK;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private CheckBox chkActivo;
        private Label label1;
        private DateTimePicker dtpFechaIngre;
        private TextBox txtCantidad;
    }
}