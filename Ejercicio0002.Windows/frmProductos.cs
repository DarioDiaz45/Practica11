using Ejercicio01.Entidades;
using Ejercicio02.Datos;
using Ejercicio2.Entidades;

namespace Ejercicio0002.Windows
{
    public partial class frmProductos : Form
    {
        private RepositorioDeProductos? repo;
        private List<Producto>? listaProductos;
        private int cantidadProductos;
        public frmProductos()
        {
            InitializeComponent();
            repo = new RepositorioDeProductos();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmProductosAE frm = new frmProductosAE(repo!) { Text = "Nuevo Producto" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            Producto productoIngresado = frm.GetProducto();
            if (productoIngresado is null)
            {
                return;
            }
            repo!.Agregar(productoIngresado);
            var r = ConstruirFila(dgvProductos);
            SetearFila(r, productoIngresado);
            AgregarFila(r, dgvProductos);
            cantidadProductos = repo!.GetCantidad();
            MostrarTotales();
            MessageBox.Show("Producto Agregado!!", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            repo!.GuardarDatos();
            Application.Exit();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            listaProductos = repo!.GetProductos();
            CargarDatosComboCantidad(ref tcboCantidad);
            RecargarGrilla();

        }

        private void RecargarGrilla()
        {
            cantidadProductos = repo!.GetCantidad();
            MostrarDatosEnGrilla();
            MostrarTotales();
        }

        private void CargarDatosComboCantidad(ref ToolStripComboBox tcboCantidad)
        {

            tcboCantidad.Items.Clear();
            tcboCantidad.Items.Add("Todos");
            tcboCantidad.Items.Add("Menor que 10");
            tcboCantidad.Items.Add("Entre 10 y 20");
            tcboCantidad.Items.Add("Mayor que 20");
            tcboCantidad.SelectedIndex = 0;


            tcboCantidad.SelectedIndexChanged += tcboCantidad_SelectedIndexChanged!;
        }
        private void tcboCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listaProductos == null) return;


            if (tcboCantidad.SelectedItem == null) return;

            string filtroSeleccionado = tcboCantidad.SelectedItem.ToString()!;
            List<Producto> productosFiltrados;


            if (filtroSeleccionado == "Todos")
            {
                productosFiltrados = listaProductos;
            }
            else if (filtroSeleccionado == "Menor que 10")
            {
                productosFiltrados = listaProductos.Where(p => p.Cantidad < 10).ToList();
            }
            else if (filtroSeleccionado == "Entre 10 y 20")
            {
                productosFiltrados = listaProductos.Where(p => p.Cantidad >= 10 && p.Cantidad <= 20).ToList();
            }
            else
            {
                productosFiltrados = listaProductos.Where(p => p.Cantidad > 20).ToList();
            }


            dgvProductos.Rows.Clear();
            foreach (var producto in productosFiltrados)
            {
                DataGridViewRow r = ConstruirFila(dgvProductos);
                SetearFila(r, producto);
                AgregarFila(r, dgvProductos);
            }


            txtCantidad.Text = productosFiltrados.Count.ToString();

            tsbFiltrar.Enabled = false;


        }

        private void MostrarTotales()
        {
            txtCantidad.Text = cantidadProductos.ToString();
        }

        private void MostrarDatosEnGrilla()
        {
            dgvProductos.Rows.Clear();
            foreach (var producto in listaProductos!)
            {
                DataGridViewRow r = ConstruirFila(dgvProductos);
                SetearFila(r, producto);
                AgregarFila(r, dgvProductos);
            }
        }

        private void SetearFila(DataGridViewRow r, Producto producto)
        {
            r.Cells[colCodigo.Index].Value = producto.Codigo;
            r.Cells[colDescripcion.Index].Value = producto.Descripcion;
            r.Cells[colCantidad.Index].Value = producto.Cantidad;
            r.Cells[colPrecioUnitario.Index].Value = producto.PrecioUnitario;
            r.Cells[colActivo.Index].Value = producto.Activo;
            r.Tag = producto;
        }

        private void AgregarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Add(r);
        }

        private DataGridViewRow ConstruirFila(DataGridView dgv)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgv);
            return r;

        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                return;
            }
            var rSeleccionada = dgvProductos.SelectedRows[0];
            Producto productoBorrar = (Producto)rSeleccionada.Tag!;
            DialogResult dr = MessageBox.Show($"¿Desea borrar al producto {productoBorrar.Descripcion} de la lista?",
                "Comfirmar Borrado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            repo!.Borrar(productoBorrar);
            QuitarFila(rSeleccionada, dgvProductos);
            cantidadProductos = repo!.GetCantidad();
            MostrarTotales();
            MessageBox.Show("Registro Eliminado!!", "Mensaje",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void QuitarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Remove(r);
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0) return;
            var rSeleccionada = dgvProductos.SelectedRows[0];
            Producto p = (Producto)rSeleccionada.Tag!;
            frmProductosAE frm = new frmProductosAE(repo!) { Text = "Editar Producto" };
            frm.SetProducto(p);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            p = frm.GetProducto();
            SetearFila(rSeleccionada, p);
            MessageBox.Show("Registro Editado!!", "Mensaje",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);


        }

        private void tsbDetalles_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                return;

            }
            var r = dgvProductos.SelectedRows[0];
            Producto p = (Producto)r.Tag!;
            frmDetalles frm = new frmDetalles() { Text = "Detalles del Producto" };
            frm.SetProducto(p);
            frm.ShowDialog(this);




        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            listaProductos = repo!.GetProductos();
            RecargarGrilla();
            tsbFiltrar.Enabled = true;

        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            string DescripcionString = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre de productos","Busca de productos", "0");
            if (string.IsNullOrEmpty(DescripcionString))
            {
                return;
            }
           
        }

    }
}
