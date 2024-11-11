namespace Ejercicio1.Windows
{
    partial class frmSociosAE
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
            lblDNI = new Label();
            txtDNI = new TextBox();
            groupBox1 = new GroupBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtTercerNom = new TextBox();
            lblTercerNom = new Label();
            txtSegundoNom = new TextBox();
            lblSegundoNom = new Label();
            txtPrimerNom = new TextBox();
            lblPrimerNom = new Label();
            lblFecNacimiento = new Label();
            dtpFechaNac = new DateTimePicker();
            groupBox2 = new GroupBox();
            rbtMasculino = new RadioButton();
            rbtFemenino = new RadioButton();
            lblLocalidad = new Label();
            cboLocalidades = new ComboBox();
            btnOk = new Button();
            btnCancelar = new Button();
            chkActivo = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(21, 30);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(30, 15);
            lblDNI.TabIndex = 0;
            lblDNI.Text = "DNI:";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(54, 27);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(lblApellido);
            groupBox1.Controls.Add(txtTercerNom);
            groupBox1.Controls.Add(lblTercerNom);
            groupBox1.Controls.Add(txtSegundoNom);
            groupBox1.Controls.Add(lblSegundoNom);
            groupBox1.Controls.Add(txtPrimerNom);
            groupBox1.Controls.Add(lblPrimerNom);
            groupBox1.Location = new Point(21, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 187);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Socio";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(113, 117);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(191, 23);
            txtApellido.TabIndex = 7;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(16, 120);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(59, 15);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellidos:";
            // 
            // txtTercerNom
            // 
            txtTercerNom.Location = new Point(113, 88);
            txtTercerNom.Name = "txtTercerNom";
            txtTercerNom.Size = new Size(191, 23);
            txtTercerNom.TabIndex = 5;
            // 
            // lblTercerNom
            // 
            lblTercerNom.AutoSize = true;
            lblTercerNom.Location = new Point(7, 91);
            lblTercerNom.Name = "lblTercerNom";
            lblTercerNom.Size = new Size(88, 15);
            lblTercerNom.TabIndex = 4;
            lblTercerNom.Text = "Tercer Nombre:";
            // 
            // txtSegundoNom
            // 
            txtSegundoNom.Location = new Point(113, 59);
            txtSegundoNom.Name = "txtSegundoNom";
            txtSegundoNom.Size = new Size(191, 23);
            txtSegundoNom.TabIndex = 3;
            // 
            // lblSegundoNom
            // 
            lblSegundoNom.AutoSize = true;
            lblSegundoNom.Location = new Point(6, 62);
            lblSegundoNom.Name = "lblSegundoNom";
            lblSegundoNom.Size = new Size(104, 15);
            lblSegundoNom.TabIndex = 2;
            lblSegundoNom.Text = "Segundo Nombre:";
            // 
            // txtPrimerNom
            // 
            txtPrimerNom.Location = new Point(113, 27);
            txtPrimerNom.MaxLength = 20;
            txtPrimerNom.Name = "txtPrimerNom";
            txtPrimerNom.Size = new Size(191, 23);
            txtPrimerNom.TabIndex = 1;
            // 
            // lblPrimerNom
            // 
            lblPrimerNom.AutoSize = true;
            lblPrimerNom.Location = new Point(6, 30);
            lblPrimerNom.Name = "lblPrimerNom";
            lblPrimerNom.Size = new Size(92, 15);
            lblPrimerNom.TabIndex = 0;
            lblPrimerNom.Text = "Primer Nombre:";
            // 
            // lblFecNacimiento
            // 
            lblFecNacimiento.AutoSize = true;
            lblFecNacimiento.Location = new Point(203, 30);
            lblFecNacimiento.Name = "lblFecNacimiento";
            lblFecNacimiento.Size = new Size(96, 15);
            lblFecNacimiento.TabIndex = 3;
            lblFecNacimiento.Text = "Fec. Nacimiento:";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(305, 27);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(83, 23);
            dtpFechaNac.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtMasculino);
            groupBox2.Controls.Add(rbtFemenino);
            groupBox2.Location = new Point(378, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(186, 87);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Genero";
            // 
            // rbtMasculino
            // 
            rbtMasculino.AutoSize = true;
            rbtMasculino.Location = new Point(9, 57);
            rbtMasculino.Name = "rbtMasculino";
            rbtMasculino.Size = new Size(80, 19);
            rbtMasculino.TabIndex = 1;
            rbtMasculino.Text = "Masculino";
            rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtFemenino
            // 
            rbtFemenino.AutoSize = true;
            rbtFemenino.Checked = true;
            rbtFemenino.Location = new Point(9, 30);
            rbtFemenino.Name = "rbtFemenino";
            rbtFemenino.Size = new Size(78, 19);
            rbtFemenino.TabIndex = 0;
            rbtFemenino.TabStop = true;
            rbtFemenino.Text = "Femenino";
            rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.Location = new Point(26, 283);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(58, 15);
            lblLocalidad.TabIndex = 6;
            lblLocalidad.Text = "Localidad";
            // 
            // cboLocalidades
            // 
            cboLocalidades.FormattingEnabled = true;
            cboLocalidades.Location = new Point(90, 280);
            cboLocalidades.Name = "cboLocalidades";
            cboLocalidades.Size = new Size(244, 23);
            cboLocalidades.TabIndex = 7;
            cboLocalidades.SelectedIndexChanged += cboLocalidades_SelectedIndexChanged;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(39, 324);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 66);
            btnOk.TabIndex = 8;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(167, 324);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 66);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(387, 238);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 9;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // frmSociosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 395);
            ControlBox = false;
            Controls.Add(chkActivo);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(cboLocalidades);
            Controls.Add(lblLocalidad);
            Controls.Add(groupBox2);
            Controls.Add(dtpFechaNac);
            Controls.Add(lblFecNacimiento);
            Controls.Add(groupBox1);
            Controls.Add(txtDNI);
            Controls.Add(lblDNI);
            MaximumSize = new Size(616, 434);
            MinimumSize = new Size(616, 434);
            Name = "frmSociosAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSociosAE";
            Load += frmSociosAE_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDNI;
        private TextBox txtDNI;
        private GroupBox groupBox1;
        private TextBox txtTercerNom;
        private Label lblTercerNom;
        private TextBox txtSegundoNom;
        private Label lblSegundoNom;
        private TextBox txtPrimerNom;
        private Label lblPrimerNom;
        private TextBox txtApellido;
        private Label lblApellido;
        private Label lblFecNacimiento;
        private DateTimePicker dtpFechaNac;
        private GroupBox groupBox2;
        private RadioButton rbtMasculino;
        private RadioButton rbtFemenino;
        private Label lblLocalidad;
        private ComboBox cboLocalidades;
        private Button btnOk;
        private Button btnCancelar;
        private CheckBox chkActivo;
    }
}