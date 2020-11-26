using ControlDeCalidad.Presentacion.Interfaces;
using ControlDeCalidad.Presentacion.Presentadores;
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
    public partial class ListaLineaTrabajoForm : Form, IListaLineaTrabajo
    {
        private ListaLineaTrabajoPresentador presentador;

        public ListaLineaTrabajoForm()
        {
            presentador = new ListaLineaTrabajoPresentador(this);
            InitializeComponent();
        }

        private void ListaLineaTrabajoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
