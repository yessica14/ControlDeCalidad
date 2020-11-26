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

    public partial class OrdenProduccionABMForm : Form, IOrdenProduccionABM
    {
        private OrdenProduccionABMPresentador presentador;
        public TipoOperacionForm TipoOperacion { get; set; }
        public OrdenProduccion ordenProduccion { get; set; }

        public OrdenProduccionABMForm()
        {
            presentador = new OrdenProduccionABMPresentador(this);
            InitializeComponent();
        }

        private void NuevaOrdenProduccionForm_Load(object sender, EventArgs e)
        {
            bsEstados.DataSource = Enum.GetValues(typeof(EstadoOrdenProduccion));
         
            switch (TipoOperacion)
            {
                case TipoOperacionForm.ALTA:

                    cbEstados.Enabled = false;
                    btnAccion.Text = "Iniciar";
                    presentador.ObtenerLineasTrabajoNOpModelos();
                    break;
                case TipoOperacionForm.MODIFICACION:
                    cbLineaTrabajo.Enabled = false;
                    txtPares.Enabled = false;
                    cbModelos.Enabled = false;

                    var listaLineaTrab = new List<LineaTrabajo>();
                    listaLineaTrab.Add(ordenProduccion.LineaTrabajo);
                    bsLineasTrabajo.DataSource = listaLineaTrab;

                    txtNumeroOP.Text = ordenProduccion.Numero.ToString();
                    txtPares.Text = (ordenProduccion.ListaDeCalzado.Count()/2).ToString();

                    var listaModelos= new List<Modelo>();
                    listaModelos.Add(ordenProduccion.Modelo);
                    bsModelos.DataSource = listaModelos;

                    if(ordenProduccion.EstadoOrdenProduccion == EstadoOrdenProduccion.Finalizado)
                    {
                        cbEstados.Enabled = false;
                        btnAccion.Enabled = false;
                    }
                    //switch (ordenProduccion.EstadoOrdenProduccion)
                    //{
                    //    case EstadoOrdenProduccion.Inicio:
                    //        //cbEstados.Items.Remove("Inicio");
                    //        //cbEstados.Items.Remove("Continuado");
                    //        cbEstados.Items.RemoveAt(0);
                    //        cbEstados.Items.RemoveAt(2);
                    //        break;
                    //    case EstadoOrdenProduccion.Pausado:
                    //        cbEstados.Items.Remove("Inicio");
                    //        cbEstados.Items.Remove("Pausado");
                    //        cbEstados.Items.Remove("Finalizado");
                    //        break;
                    //    case EstadoOrdenProduccion.Continuado:
                    //        cbEstados.Items.Remove("Inicio");
                    //        cbEstados.Items.Remove("Continuado");
                    //        break;
                    //}

                    btnAccion.Text = "Modificar";
                    break;
                    
            }
        }

        public void MostrarLineasTrabajoNOpModelos(List<LineaTrabajo> listaLineas, int numeroOp, List<Modelo> listaModelos)
        {
            bsLineasTrabajo.DataSource = listaLineas;
            txtNumeroOP.Text = numeroOp.ToString();
            bsModelos.DataSource = listaModelos;
        }

        public void CerrarVentana()
        {
            this.Close();
        }

        public void MostrarMensaje(string texto, bool esError)
        {
            if (esError)
            {
                MessageBox.Show(texto, "ABMOP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(texto, "ABMOP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            switch (TipoOperacion)
            {
                case TipoOperacionForm.ALTA:
                    var lineaTrabajo = (bsLineasTrabajo.Current as LineaTrabajo);//solamente trae la fila seleccionada de la tabla de la vista y lo trae como objeto linea trabajo
                    var modelo = (bsModelos.Current as Modelo);
                    string cantidadPares = txtPares.Text;
                    presentador.CrearOrdenProduccionyActualizarLineaTrabajo(cantidadPares, lineaTrabajo, modelo);
                    break;
                case TipoOperacionForm.MODIFICACION:
                    var txtEstado = cbEstados.Text;
                    presentador.ActualizarEstadoOrdenProduccion(txtEstado, ordenProduccion);
                    break;

            }
        }
    }
}
