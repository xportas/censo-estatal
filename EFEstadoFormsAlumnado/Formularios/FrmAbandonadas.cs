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
    public partial class FrmAbandonadas : Form
    {
        public FrmAbandonadas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarLocalidadesPorIdProvincia_Click(object sender, EventArgs e)
        {
            string error = "";
            
            lblMensaje.Text = string.Empty;
            lblNombreProvincia.Text = string.Empty;
            dgv.DataSource = null;

            var idProv = txtIdProv.Text;
            var localidades = Program.gestorDatos.GetAbandonadas(idProv, out error);

            

            if (String.IsNullOrEmpty(idProv) || idProv == "")
            {
                lblMensaje.Text = "Localidades abandonadas de todo el estado";
                lblNombreProvincia.Text = "Todo el estado";
                dgv.DataSource = localidades.Select(l => new { l.Id, l.Localidad, l.IdProv, l.Provincia })
                                            .OrderBy(l => l.Provincia)
                                            .ToList();
            }
            else if (localidades == null)
            {
                dgv.DataSource = null;
                lblNombreProvincia.Text = error;
            }
            else
            {
                lblMensaje.Text = $"Localidades abandonadas de {localidades[0].Provincia}";
                lblNombreProvincia.Text = localidades[0].Provincia;
                dgv.DataSource = localidades.Select(l => new { l.Id, Nombre = l.Localidad})
                                            .OrderBy(l=> l.Nombre)
                                            .ToList();
            }
        }

        private void FrmAbandonadas_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = string.Empty;
            lblNombreProvincia.Text = string.Empty;
            dgv.DataSource = null;
        }
    }
}
