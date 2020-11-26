using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeCalidad.Presentacion.Vistas
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ListaColoresForm();
            form.ShowDialog(this);
        }

        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ListaModelosForm();
            form.ShowDialog(this);
        }

        private void crearProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ListaOrdenesProduccionForm();
            form.ShowDialog(this);
        }

        private void registrarDefectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new RegistrarDefectoForm();
            form.ShowDialog(this);
        }
    }
}
