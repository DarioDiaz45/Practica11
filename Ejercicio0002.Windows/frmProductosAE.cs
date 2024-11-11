using Ejercicio02.Datos;
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
    public partial class frmProductosAE : Form
    {

        private Guid guid;
        private Producto? producto;
        private RepositorioDeProductos? _repo;
        public frmProductosAE(RepositorioDeProductos repo)
        {
            InitializeComponent();
            guid = Guid.NewGuid();
            _repo = repo;
        }


        private void Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (producto is null)
                {
            
                    
                    producto = new Producto();
                    
                    producto!.Codigo = guid;
                    producto.Descripcion = txtDescripcion.Text;
                    producto.PrecioUnitario = int.Parse(txtPrecioProducto.Text);
                    producto.Cantidad = int.Parse(txtCantidad.Text);
                    
                    
                    DialogResult = DialogResult.OK;
                }
                

            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                valido = false;
                errorProvider1.SetError(txtDescripcion, "La descripcion del producto es requerida");

            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                valido = false;
                errorProvider1.SetError(txtDescripcion, "El codigo del producto es requerido");
            }
            if (_repo!.GetProductos().Any(p => p.Descripcion == txtDescripcion.Text))
            {
                valido = false;
                errorProvider1.SetError(txtDescripcion, " Codigo no valido!!");

            }         
            return valido;




        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (producto is not null)
            {
                txtCodigo.Text = producto.Codigo.ToString();
                txtCodigo.Enabled = false;
                txtCantidad.Text = producto.Cantidad.ToString();
                txtDescripcion.Text = producto.Descripcion!.ToString();
                txtPrecioProducto.Text = producto.PrecioUnitario.ToString();

                chkActivo.Checked = producto.Activo;
            }
        }

        private void frmProductosAE_Load(object sender, EventArgs e)
        {
            chkActivo.Checked = true;
        }

        public Producto GetProducto()
        {
            return producto!;
        }

        internal void SetProducto(Producto? p)
        {
            producto = p;
        }
    }
}
