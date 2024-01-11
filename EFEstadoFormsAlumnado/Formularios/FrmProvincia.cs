using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using Entidades;

namespace Formularios
{
    public partial class FrmProvincia : Form
    {

        public FrmProvincia()
        {
            InitializeComponent();
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Mostrar en combo los nombres de las provincias ordenadas alfabéticamente. Al elegir una se verán sus datos en las etiquetas correspondientes
        private void FrmProvincia_Load(object sender, EventArgs e)
        {
            cboProvincias.Items.Clear();
            cboProvincias.Items.AddRange(Program.gestorDatos.GetProvinciaList().ToArray());
            cboProvincias.DisplayMember = "Nombre";
            dgv.DataSource = null;
        }

        // Método se crea pulsando 2click en cbo en el formulario
        private void cboProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblLocalidadMayor.Text = "";
            lblIdProvincia.Text = "";
            lblHabitantesProvincia.Text = "";
            lblMensaje.Text = "";

            var prov = (Provincia)cboProvincias.SelectedItem;
            if (prov == null)
            {
                lblMensaje.Text = "Se ha producido un error al recuperar la Provincia de la BD";
                return;
            }

            lblIdProvincia.Text = prov.Id;

            //Comprobamos que provincia tiene localidades
            if (prov.Localidades.Count == 0)
            {
                lblMensaje.Text = $"No hay localidades en {prov.Nombre}";
                lblLocalidadMayor.Text = "No hay ninguna";
                lblHabitantesProvincia.Text = "Abandonada";
                return;
            }

            //Si tiene habitantes sacamos el total
            int? habitantesTotales = prov.Localidades.Sum(loc => loc.NumHab);
            if (habitantesTotales > 0 || habitantesTotales != null)
            {
                lblHabitantesProvincia.Text = habitantesTotales.ToString();
            }

            //Obtenemos localidad más poblada
            var habsLocMayor = prov.Localidades.Max(loc => loc.NumHab);
            if (habsLocMayor == 0)
            {
                lblLocalidadMayor.Text = "No hay ninguna habitada";
            }
            else
            {
                lblLocalidadMayor.Text = (prov.Localidades.SingleOrDefault(loc => loc.NumHab == habsLocMayor)).Nombre;
            }
            

            //Mostramos mensaje de cuántas localidades hay (Count)
            lblMensaje.Text = $"Hay {prov.Localidades.Count.ToString()} localidades en {prov.Nombre}";
            
            dgv.DataSource = prov.Localidades
                            .OrderByDescending(l => l.NumHab)
                            .Select(l => new { l.Id, l.Nombre, Habitantes = l.NumHab == 0 || l.NumHab == null ? "Abandonada" : l.NumHab.ToString() })
                            .ToList(); // dataGridView.DataSource solo admite listas, no colecciones
        }
    }
}
