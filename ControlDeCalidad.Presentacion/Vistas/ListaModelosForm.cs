using ControlDeCalidad.Dominio;
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
    public partial class ListaModelosForm : Form, IListaModelos
    {
        private ListaModelosPresentador presentador;
        public ListaModelosForm()
        {
            presentador = new ListaModelosPresentador(this);
            InitializeComponent();
        }

        private void ListaModelosForm_Load(object sender, EventArgs e)
        {   
            presentador.ObtenerListaModelos();
        }

        public void MostrarTodosLosModelos(List<Modelo> lista)
        {
            bsModelos.DataSource = null;
            bsModelos.DataSource = lista;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ModeloABMForm formABM = new ModeloABMForm();
            formABM.TipoOperacion = TipoOperacionForm.ALTA;
            formABM.ShowDialog(this);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var _modelo = (bsModelos.Current as Modelo); // captura el objeto en la fila seleccionada de la grilla
            ModeloABMForm vista = new ModeloABMForm();
            vista.TipoOperacion = TipoOperacionForm.MODIFICACION;
            vista.modelo = _modelo;

            vista.ShowDialog(this);//hacer visible vista

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var _modelo= (bsModelos.Current as Modelo);
            ModeloABMForm vista = new ModeloABMForm()
            {
                modelo = _modelo,
                TipoOperacion = TipoOperacionForm.BAJA
            };
            vista.ShowDialog(this);
        }

        private void ListaModelosForm_Activated(object sender, EventArgs e)
        {
            presentador.ObtenerListaModelos();
        }
    }
}
