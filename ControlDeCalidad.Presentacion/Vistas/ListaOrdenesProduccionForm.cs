using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlDeCalidad.Dominio;
using ControlDeCalidad.Presentacion.Interfaces;
using ControlDeCalidad.Presentacion.Presentadores;

namespace ControlDeCalidad.Presentacion.Vistas
{
    public partial class ListaOrdenesProduccionForm : Form, IListaOrdenesProduccion
    {
        private ListaOrdenesProduccionPresentador presentador;
        public ListaOrdenesProduccionForm()
        {
            presentador = new ListaOrdenesProduccionPresentador(this);
           
            InitializeComponent();
        }

        private void ListaOrdenesProduccionForm_Load(object sender, EventArgs e)
        {
            presentador.ObtenerOrdenesDeProduccionYHabilitarBotones();

        }

        public void MostrarOrdenesDeProduccionYHabilitarBotones(List<OrdenProduccion> lista, bool condicionTrabajar, bool condicionNuevaOP, bool condicionModificar)
        {
            bsOrdenesProduccion.DataSource = null;
            bsOrdenesProduccion.DataSource = lista;

            btnTrabajar.Visible = condicionTrabajar;
            btnCrear.Visible = condicionNuevaOP;
            btnModificar.Visible = condicionModificar;

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            
            var formOrdenProduccion = new OrdenProduccionABMForm();
            formOrdenProduccion.TipoOperacion = TipoOperacionForm.ALTA;
            formOrdenProduccion.ShowDialog(this);

        }

        private void ListaOrdenesProduccionForm_Activated(object sender, EventArgs e)
        {
            presentador.ObtenerOrdenesDeProduccionYHabilitarBotones();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var _OP = (bsOrdenesProduccion.Current as OrdenProduccion); // captura el objeto en la fila seleccionada de la grilla
            var vista = new OrdenProduccionABMForm();
            vista.TipoOperacion = TipoOperacionForm.MODIFICACION;
            vista.ordenProduccion= _OP;
            vista.ShowDialog(this);//hacer visible vista
         
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            var ordenProduccion = (bsOrdenesProduccion.Current as OrdenProduccion);//solamente trae la fila seleccionada de la tabla de la vista y lo trae como objeto linea trabajo
            presentador.ActualizarOrdenProduccion(ordenProduccion);
        }

        public void MostrarMensaje(string texto, bool esError)
        {
            if (esError)
            {
               MessageBox.Show(texto, "ListaOp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(texto, "ListaOp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                presentador.ObtenerOrdenesDeProduccionYHabilitarBotones();
            }
            
        }
    }
}
