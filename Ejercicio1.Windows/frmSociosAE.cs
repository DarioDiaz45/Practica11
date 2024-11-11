using Ejercicio1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1.Windows
{
    public partial class frmSociosAE : Form
    {
        public frmSociosAE()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboLocalidades(ref cboLocalidades);


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void frmSociosAE_Load(object sender, EventArgs e)
        {
        }

        public void CargarDatosComboLocalidades(ref ComboBox cbo)
        {
            var localidades = Enum.GetValues(typeof(Localidad));
            cbo.DataSource = localidades;
            cbo.SelectedIndex = 0;

        }

        private void cboLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
