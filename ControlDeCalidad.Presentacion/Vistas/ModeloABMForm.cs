using ControlDeCalidad.AccesoADatos.Servicios;
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
    public partial class ModeloABMForm : Form, IModeloABM
    {
        private ModeloABMPresentador presentador;
        public Modelo modelo { get; set; }
        public TipoOperacionForm TipoOperacion { get; set; }
        private ModeloServicio modeloServicio = new ModeloServicio();

        public ModeloABMForm()
        {
            presentador = new ModeloABMPresentador(this);
            InitializeComponent();
            presentador.ObtenerColores();
        }

        private void ModeloABMForm_Load(object sender, EventArgs e)
        {
            switch (TipoOperacion)
            {
                case TipoOperacionForm.ALTA:
                    modelo = new Modelo();
                    btnAccion.Text = "Guardar";
                    int sku = modeloServicio.ObtenerUltimoSku();
                    txtSku.Enabled = false;
                    txtSku.Text = sku.ToString();
                    break;
                case TipoOperacionForm.BAJA:
                    btnAccion.Text = "Eliminar";
                    txtSku.Enabled = false;
                    txtDenominacion.Enabled = false;
                    txtObjetivo.Enabled = false;
                    cbColores.Enabled = false;
                    txtSku.Text = modelo.Sku.ToString();
                    txtDenominacion.Text = modelo.Denominacion;
                    txtObjetivo.Text = modelo.Objetivo.ToString();
                    break;
                case TipoOperacionForm.MODIFICACION:
                    btnAccion.Text = "Modificar";
                    txtSku.Enabled = false;
                    txtSku.Text = modelo.Sku.ToString();
                    txtDenominacion.Text = modelo.Denominacion;
                    txtObjetivo.Text = modelo.Objetivo.ToString();
                    break;
            }
        }


        public void MostrarUltimoSku(int id)
        {
            throw new NotImplementedException();
        }

        public void MostrarColores(List<ColorCalzado> lista)
        {
            bsColores.DataSource = lista;
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtObjetivo.Text, out int number))  // pregunta si se puede convertir a int o no. tryparse trata de pasar
            {
                MessageBox.Show("Se requiere el objetivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtDenominacion.Text))
            {
                MessageBox.Show("Se requiere el denominacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            modelo.Sku = int.Parse(txtSku.Text);
            modelo.Objetivo = int.Parse(txtObjetivo.Text);
            modelo.Denominacion = txtDenominacion.Text;

            presentador.AgregarModificarEliminarModelo(modelo, TipoOperacion);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
