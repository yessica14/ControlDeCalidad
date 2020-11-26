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
    public partial class ColorABMForm : Form, IColorABM
    {
        
        private ColorABMPresentador presentador;

        public ColorCalzado color { get; set; }
        public TipoOperacionForm TipoOperacion { get; set; }

        public ColorABMForm()
        {
            presentador = new ColorABMPresentador(this);
            InitializeComponent();
        }

        private void ColorABMForm_Load(object sender, EventArgs e)
        {
            switch (TipoOperacion)
            {
                case TipoOperacionForm.ALTA:
                    color = new ColorCalzado();
                    presentador.ObtenerUltimoId();
                    btnAccion.Text = "Guardar";
                    break;
                case TipoOperacionForm.MODIFICACION:
                    txtCodigo.Text = color.Codigo.ToString();
                    txtDescripcion.Text = color.Descripcion;
                    btnAccion.Text = "Modificar";
                    break;
                case TipoOperacionForm.BAJA:
                    txtCodigo.Text = color.Codigo.ToString();
                    txtDescripcion.Text = color.Descripcion;
                    txtDescripcion.Enabled = false;
                    btnAccion.Text = "Eliminar";
                    break;
            }
        }

        private void btmCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            color.Descripcion = txtDescripcion.Text;
            presentador.AgregarModificarEliminarColor(color, TipoOperacion);
        }

        public void MostrarMensaje(string mensaje, bool conError)
        {
            if (conError)
            {
                MessageBox.Show(mensaje, "ABM Colores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(mensaje, "ABM Colores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        public void MostrarUltimoId(int id)
        {
            txtCodigo.Text = id.ToString();
        }

        public void CerrarVentana()
        {
            this.Close();
        }
    }
}
