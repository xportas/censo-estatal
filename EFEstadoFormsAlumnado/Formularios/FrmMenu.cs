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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void provinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmProvincia().Show();
        }

        private void abandonadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAbandonadas().Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void borrarLocalidadesDeProvinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBorrarLocalidades().Show();
        }

        private void altaDelocalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAltaLocalidad().Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultas().Show();
        }
    }
}
