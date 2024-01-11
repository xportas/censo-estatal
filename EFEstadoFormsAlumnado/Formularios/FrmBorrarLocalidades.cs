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
    public partial class FrmBorrarLocalidades : Form
    {
        public FrmBorrarLocalidades()
        {
            InitializeComponent();
        }

        private void btnBorrarLocalidades_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = string.Empty;
            string message;
            DialogResult resultado = 
                MessageBox.Show("¿Seguro que quieres eliminar la localidad?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Llamada al método que elimina todas las localidades por su idProvincia y que empiezan por txtComienzaPor.Text
                dgv.DataSource = null;
                Program.gestorDatos.DeleteLocalidades(txtIdProv.Text, txtComienzaPor.Text, out message);
                lblMensaje.Text = message;
            }
        }

        private void btnMostrarLocalidades_Click(object sender, EventArgs e)
        {
            string error = "";
            dgv.DataSource = null;
            lblMensaje.Text = string.Empty;

            var localidades = Program.gestorDatos.GetLocalidadesPorTrozoNombre(txtIdProv.Text, txtComienzaPor.Text, out error);
            
            // Validamos que existe Provincia con ID txtIdProv
            if (localidades == null)
            {
                lblMensaje.Text = error;
                return;
            }
            
            dgv.DataSource = localidades.Select
                (l => new { l.Id, l.Nombre, NumHab = l.NumHab == 0 || l.NumHab == null ? "Abandonada" : l.NumHab.ToString()})
                .ToList();
            
                lblMensaje.Text = $"Localidades de {localidades[0].Provincia.Nombre} que comienzan por {txtComienzaPor.Text}";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmBorrarLocalidades_Load(object sender, EventArgs e)
        {
            // Método para cuando se carga el formulario en pantalla
            dgv.DataSource = null;
            txtComienzaPor.Text = string.Empty;
            txtIdProv.Text = string.Empty;
            lblMensaje.Text = string.Empty;
        }
    }
}
