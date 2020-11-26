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
    public partial class ListaColoresForm : Form, IListaColores
    {
        private ListaColoresPresentador presentador;

        public ListaColoresForm()
        {
            presentador = new ListaColoresPresentador(this);
            InitializeComponent();
        }

        private void ListaColoresForm_Load(object sender, EventArgs e)
        {
            presentador.ObtenerListadoColores();
        }

        private void ListaColoresForm_Activated(object sender, EventArgs e)
        {
            presentador.ObtenerListadoColores();
        }

        public void MostrarListaDeColores(List<ColorCalzado> lista)
        {
            bsColoresCalzado.DataSource = lista;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formABM = new ColorABMForm()
            {
                TipoOperacion = TipoOperacionForm.ALTA
            };
            formABM.ShowDialog(this);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var colorCalzado = (bsColoresCalzado.Current as ColorCalzado);
            ColorABMForm formABM = new ColorABMForm()
            {
                color = colorCalzado,
                TipoOperacion = TipoOperacionForm.MODIFICACION
            };
            formABM.ShowDialog(this);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var colorCalzado = (bsColoresCalzado.Current as ColorCalzado);
            var formABM = new ColorABMForm()
            {
                color = colorCalzado,
                TipoOperacion = TipoOperacionForm.BAJA
            };
            formABM.ShowDialog(this);
        }
    }
}
