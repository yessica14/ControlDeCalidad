using System;

using ControlDeCalidad.Presentacion.Vistas;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlDeCalidad.Dominio;
using ControlDeCalidad.Presentacion.Presentadores;
using ControlDeCalidad.Presentacion.Interfaces;

namespace ControlDeCalidad.Presentacion.Vistas
{
    public partial class RegistrarDefectoForm : Form, IRegistrarDefecto
    {
        private RegistrarDefectoPresentador presentador;
        private OrdenProduccion _ordenProduccion = new OrdenProduccion();
        private int _indice;
        public RegistrarDefectoForm()
        {
            presentador = new RegistrarDefectoPresentador(this);
            InitializeComponent();
        }

        private void RegistrarDefectoForm_Load(object sender, EventArgs e)
        {
            presentador.ObtenerDefectos();
            bsTipoDefectoDerecho.DataSource = Enum.GetValues(typeof(TipoDefecto));
            bsTipoDefectoIzquierdo.DataSource = Enum.GetValues(typeof(TipoDefecto));
            presentador.ObtenerOrdenProduccion();
            

        }

        public void MostrarOrdenProduccion(OrdenProduccion ordenProduccion, int indice, Hallazgo calzadoIzquierdo, Hallazgo calzadoDerecho, int parActual)
        {
            txtNumeroOp.Text = ordenProduccion.Numero.ToString();
            txtModelo.Text = ordenProduccion.Modelo.Denominacion;
            txtColor.Text = ordenProduccion.Modelo.ColorDeModelo.Descripcion;
            txtCantPares.Text = (ordenProduccion.ListaDeCalzado.Count / 2).ToString();
            txtObjetivo.Text = ordenProduccion.Modelo.Objetivo.ToString();
            txtParActual.Text = parActual.ToString();
            _ordenProduccion = ordenProduccion;
            _indice = indice;


        }

        public void MostrarDefectosDelPieDerecho(List<Defecto> lista)
        {
            bsDefectoPieDerecho.DataSource = lista;
            bsDefectoPieIzquierdo.DataSource = lista;
        }

        public void MostrarMensaje(string mensaje, bool esError)
        {
            if (esError)
            {
                MessageBox.Show(mensaje, "Registra Defecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                MessageBox.Show(mensaje, "Registra Defecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void CerrarVentana()
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void chbAprobadoIzq_CheckedChanged(object sender, EventArgs e)
        {
            if(chbAprobadoIzq.Checked == true)
            {
                cbDefectosIzq.Enabled = false;
                cbTipoDefectoIzq.Enabled = false;
            } 
            else
            {
                cbDefectosIzq.Enabled = true;
                cbTipoDefectoIzq.Enabled = true;
            }
            
        }

        private void chbAprobadoDer_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAprobadoDer.Checked == true)
            {
                cbDefectosDer.Enabled = false;
                cbTipoDefectoDer.Enabled = false;
            }
            else
            {
                cbDefectosDer.Enabled = true;
                cbTipoDefectoDer.Enabled = true;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            var AprobadoIzq = chbAprobadoIzq.Checked;
            var DefectosIzq = (bsDefectoPieDerecho.Current as Defecto);              //  cbDefectosIzq;
            var TipoDefectoIzq = cbTipoDefectoIzq.Text;

            var AprobadoDer = chbAprobadoDer.Checked;
            var DefectosDer = (bsDefectoPieIzquierdo.Current as Defecto);
            var TipoDeDectoDer = cbTipoDefectoDer.Text;

            presentador.RegistrarAprobadosODefectos(_ordenProduccion, AprobadoIzq, DefectosIzq, TipoDefectoIzq, AprobadoDer, DefectosDer, TipoDeDectoDer, _indice);

        }

        public void RecargarVentana()
        {
            presentador.ObtenerDefectos();
            bsTipoDefectoDerecho.DataSource = Enum.GetValues(typeof(TipoDefecto));
            bsTipoDefectoIzquierdo.DataSource = Enum.GetValues(typeof(TipoDefecto));
            presentador.ObtenerOrdenProduccion();

        }
    }
}
