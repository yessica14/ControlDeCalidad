namespace ControlDeCalidad.Presentacion.Vistas
{
    partial class OrdenProduccionABMForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroOP = new System.Windows.Forms.TextBox();
            this.txtPares = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAccion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLineaTrabajo = new System.Windows.Forms.ComboBox();
            this.bsLineasTrabajo = new System.Windows.Forms.BindingSource(this.components);
            this.cbModelos = new System.Windows.Forms.ComboBox();
            this.bsModelos = new System.Windows.Forms.BindingSource(this.components);
            this.cbEstados = new System.Windows.Forms.ComboBox();
            this.bsEstados = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsLineasTrabajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero OP";
            // 
            // txtNumeroOP
            // 
            this.txtNumeroOP.Enabled = false;
            this.txtNumeroOP.Location = new System.Drawing.Point(347, 30);
            this.txtNumeroOP.Name = "txtNumeroOP";
            this.txtNumeroOP.Size = new System.Drawing.Size(79, 20);
            this.txtNumeroOP.TabIndex = 2;
            // 
            // txtPares
            // 
            this.txtPares.Location = new System.Drawing.Point(102, 76);
            this.txtPares.Name = "txtPares";
            this.txtPares.Size = new System.Drawing.Size(133, 20);
            this.txtPares.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad Pares";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Modelo";
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(102, 220);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(71, 23);
            this.btnAccion.TabIndex = 9;
            this.btnAccion.Text = "Accion";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(224, 220);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(71, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Linea Trabajo";
            // 
            // cbLineaTrabajo
            // 
            this.cbLineaTrabajo.DataSource = this.bsLineasTrabajo;
            this.cbLineaTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLineaTrabajo.FormattingEnabled = true;
            this.cbLineaTrabajo.Location = new System.Drawing.Point(102, 30);
            this.cbLineaTrabajo.Name = "cbLineaTrabajo";
            this.cbLineaTrabajo.Size = new System.Drawing.Size(133, 21);
            this.cbLineaTrabajo.TabIndex = 13;
            // 
            // cbModelos
            // 
            this.cbModelos.DataSource = this.bsModelos;
            this.cbModelos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelos.FormattingEnabled = true;
            this.cbModelos.Location = new System.Drawing.Point(102, 124);
            this.cbModelos.Name = "cbModelos";
            this.cbModelos.Size = new System.Drawing.Size(322, 21);
            this.cbModelos.TabIndex = 14;
            // 
            // cbEstados
            // 
            this.cbEstados.DataSource = this.bsEstados;
            this.cbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstados.FormattingEnabled = true;
            this.cbEstados.Location = new System.Drawing.Point(102, 173);
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Size = new System.Drawing.Size(133, 21);
            this.cbEstados.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Estado";
            // 
            // OrdenProduccionABMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 281);
            this.Controls.Add(this.cbEstados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbModelos);
            this.Controls.Add(this.cbLineaTrabajo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeroOP);
            this.Controls.Add(this.label1);
            this.Name = "OrdenProduccionABMForm";
            this.Text = "Alta/ Modificacion Orden Produccion";
            this.Load += new System.EventHandler(this.NuevaOrdenProduccionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsLineasTrabajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroOP;
        private System.Windows.Forms.TextBox txtPares;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbLineaTrabajo;
        private System.Windows.Forms.BindingSource bsLineasTrabajo;
        private System.Windows.Forms.ComboBox cbModelos;
        private System.Windows.Forms.BindingSource bsModelos;
        private System.Windows.Forms.ComboBox cbEstados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsEstados;
    }
}