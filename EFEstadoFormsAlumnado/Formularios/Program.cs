
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    static class Program
    {
        public static GestorDatos gestorDatos;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String error = "";
            gestorDatos = new GestorDatos(out error);
            if (!String.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMenu());
        }
    }
}
