using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmAltaLocalidad : Form
    {
        public FrmAltaLocalidad()
        {
            InitializeComponent();
        }

        private void btnAñadirLocalidad_Click(object sender, EventArgs e)
        {
            string error = string.Empty;

            Program.gestorDatos.PostLocalidad(txtIdLocalidad.Text, txtLocalidad.Text, txtNumHab.Text, txtIdProv.Text, out error);
            if (error != string.Empty)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("La localidad se ha guardado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Tras guardar con éxito borramos los campos con datos introducidos por el usuario
                txtIdLocalidad.Text = string.Empty;
                txtIdProv.Text = string.Empty;
                txtLocalidad.Text = string.Empty;
                txtNumHab.Text = string.Empty;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtIdLocalidad.Text = string.Empty;
            txtIdProv.Text = string.Empty;
            txtLocalidad.Text = string.Empty;
            txtNumHab.Text = string.Empty;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAltaLocalidad_Load(object sender, EventArgs e)
        {
            txtIdLocalidad.Text = string.Empty;
            txtIdProv.Text = string.Empty;
            txtLocalidad.Text = string.Empty;
            txtNumHab.Text = string.Empty;
        }
    }
}
