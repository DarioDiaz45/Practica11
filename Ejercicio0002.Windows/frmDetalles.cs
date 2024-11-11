using Ejercicio01.Entidades;
using Ejercicio2.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio0002.Windows
{
    public partial class frmDetalles : Form
    {
        private Producto? producto;
        public frmDetalles()
        {
            InitializeComponent();
        }

        public void SetProducto(Producto? p)
        {
            producto = p;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void frmDetalles_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = producto!.Codigo.ToString();
            txtCodigo.Enabled = false;
            txtCantidad.Text = producto.Cantidad.ToString();
            txtDescripcion.Text = producto.Descripcion!.ToString();
            txtPrecioProducto.Text = producto.PrecioUnitario.ToString();

            chkActivo.Checked = producto.Activo;
        }
    }
}
