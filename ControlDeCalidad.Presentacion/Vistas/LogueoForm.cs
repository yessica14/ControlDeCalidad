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
    public partial class LogueoForm : Form, ILogueoForm
    {
        private LogueoFormPresentador presentador;
       

        public LogueoForm()
        {
            presentador = new LogueoFormPresentador(this);
            InitializeComponent();
        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            presentador.ComprobarLogueo(textUsuario.Text, textContrasena.Text);
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void MostrarMensaje(string mensaje, bool conError)
        {
            if (conError)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(mensaje, "Logueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            
        }
    }
}
