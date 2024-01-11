
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
    public partial class FrmConsultas : Form
    {
        public FrmConsultas()
        {
            InitializeComponent();
        }

       private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLocalidadesHabitadasPequeñas_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
            dgv.DataSource = null; //borra origen de datos y por tanto toda la info del dgv
            //dgv.Rows.Clear(); mantiene el origen de datos pero borra las filas

            int? minNum;
            dgv.DataSource = Program.gestorDatos.GetLocalidadesPequenhasOrdenadas(out minNum).Select(t => new { t.Nombre, NombreProvincia = t.Provincia.Nombre }).ToList();

            lblMensaje.Text = $"Las localidades más pequeñas tienen {minNum} habitantes, ordenadas por provincia y nombre";
        }

        private void btnProvinciasPorHabitantes_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
            dgv.DataSource = null;

            lblMensaje.Text = "Provincias ordenadas por habitantes - nombre con sus localidades y habitantes";
            dgv.DataSource = Program.gestorDatos.GetOrderedProvinciasPerHabs().Select(p => new { p.Nombre, p.Id, Localidades = p.Localidades.Count(), Abandonadas = p.Localidades.Where(l => l.NumHab == 0).Count() , Habitantes = p.Localidades.Sum(l => l.NumHab) }).ToList();
        }
    }
}
