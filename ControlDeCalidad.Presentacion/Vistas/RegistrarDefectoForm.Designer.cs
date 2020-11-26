namespace ControlDeCalidad.Presentacion.Vistas
{
    partial class RegistrarDefectoForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbAprobadoDer = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoDefectoDer = new System.Windows.Forms.ComboBox();
            this.bsTipoDefectoIzquierdo = new System.Windows.Forms.BindingSource(this.components);
            this.cbDefectosDer = new System.Windows.Forms.ComboBox();
            this.bsDefectoPieIzquierdo = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoDefectoIzq = new System.Windows.Forms.ComboBox();
            this.bsTipoDefectoDerecho = new System.Windows.Forms.BindingSource(this.components);
            this.cbDefectosIzq = new System.Windows.Forms.ComboBox();
            this.bsDefectoPieDerecho = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chbAprobadoIzq = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroOp = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantPares = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtParActual = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtObjetivo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoDefectoIzquierdo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDefectoPieIzquierdo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoDefectoDerecho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDefectoPieDerecho)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbAprobadoDer);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbTipoDefectoDer);
            this.groupBox1.Controls.Add(this.cbDefectosDer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(326, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pie Derecho";
            // 
            // chbAprobadoDer
            // 
            this.chbAprobadoDer.AutoSize = true;
            this.chbAprobadoDer.Location = new System.Drawing.Point(96, 36);
            this.chbAprobadoDer.Name = "chbAprobadoDer";
            this.chbAprobadoDer.Size = new System.Drawing.Size(15, 14);
            this.chbAprobadoDer.TabIndex = 5;
            this.chbAprobadoDer.UseVisualStyleBackColor = true;
            this.chbAprobadoDer.CheckedChanged += new System.EventHandler(this.chbAprobadoDer_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Aprobado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Defecto";
            // 
            // cbTipoDefectoDer
            // 
            this.cbTipoDefectoDer.DataSource = this.bsTipoDefectoIzquierdo;
            this.cbTipoDefectoDer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDefectoDer.FormattingEnabled = true;
            this.cbTipoDefectoDer.Location = new System.Drawing.Point(96, 118);
            this.cbTipoDefectoDer.Name = "cbTipoDefectoDer";
            this.cbTipoDefectoDer.Size = new System.Drawing.Size(121, 21);
            this.cbTipoDefectoDer.TabIndex = 3;
            // 
            // cbDefectosDer
            // 
            this.cbDefectosDer.DataSource = this.bsDefectoPieIzquierdo;
            this.cbDefectosDer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDefectosDer.FormattingEnabled = true;
            this.cbDefectosDer.Location = new System.Drawing.Point(96, 71);
            this.cbDefectosDer.Name = "cbDefectosDer";
            this.cbDefectosDer.Size = new System.Drawing.Size(121, 21);
            this.cbDefectosDer.TabIndex = 1;
            // 
            // bsDefectoPieIzquierdo
            // 
            this.bsDefectoPieIzquierdo.DataSource = typeof(ControlDeCalidad.Dominio.Defecto);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Defecto";
            // 
            // cbTipoDefectoIzq
            // 
            this.cbTipoDefectoIzq.DataSource = this.bsTipoDefectoDerecho;
            this.cbTipoDefectoIzq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDefectoIzq.FormattingEnabled = true;
            this.cbTipoDefectoIzq.Location = new System.Drawing.Point(96, 113);
            this.cbTipoDefectoIzq.Name = "cbTipoDefectoIzq";
            this.cbTipoDefectoIzq.Size = new System.Drawing.Size(121, 21);
            this.cbTipoDefectoIzq.TabIndex = 3;
            // 
            // cbDefectosIzq
            // 
            this.cbDefectosIzq.DataSource = this.bsDefectoPieDerecho;
            this.cbDefectosIzq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDefectosIzq.FormattingEnabled = true;
            this.cbDefectosIzq.Location = new System.Drawing.Point(94, 66);
            this.cbDefectosIzq.Name = "cbDefectosIzq";
            this.cbDefectosIzq.Size = new System.Drawing.Size(121, 21);
            this.cbDefectosIzq.TabIndex = 1;
            // 
            // bsDefectoPieDerecho
            // 
            this.bsDefectoPieDerecho.DataSource = typeof(ControlDeCalidad.Dominio.Defecto);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.chbAprobadoIzq);
            this.groupBox2.Controls.Add(this.cbTipoDefectoIzq);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbDefectosIzq);
            this.groupBox2.Location = new System.Drawing.Point(21, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 167);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pie Izquierdo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Aprobado";
            // 
            // chbAprobadoIzq
            // 
            this.chbAprobadoIzq.AutoSize = true;
            this.chbAprobadoIzq.Location = new System.Drawing.Point(94, 35);
            this.chbAprobadoIzq.Name = "chbAprobadoIzq";
            this.chbAprobadoIzq.Size = new System.Drawing.Size(15, 14);
            this.chbAprobadoIzq.TabIndex = 6;
            this.chbAprobadoIzq.UseVisualStyleBackColor = true;
            this.chbAprobadoIzq.CheckedChanged += new System.EventHandler(this.chbAprobadoIzq_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Defecto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Defecto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nro OP";
            // 
            // txtNumeroOp
            // 
            this.txtNumeroOp.Enabled = false;
            this.txtNumeroOp.Location = new System.Drawing.Point(82, 33);
            this.txtNumeroOp.Name = "txtNumeroOp";
            this.txtNumeroOp.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroOp.TabIndex = 4;
            // 
            // txtColor
            // 
            this.txtColor.Enabled = false;
            this.txtColor.Location = new System.Drawing.Point(269, 73);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Color";
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Location = new System.Drawing.Point(82, 73);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Modelo";
            // 
            // txtCantPares
            // 
            this.txtCantPares.Enabled = false;
            this.txtCantPares.Location = new System.Drawing.Point(269, 115);
            this.txtCantPares.Name = "txtCantPares";
            this.txtCantPares.Size = new System.Drawing.Size(100, 20);
            this.txtCantPares.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "CantPares";
            // 
            // txtParActual
            // 
            this.txtParActual.Enabled = false;
            this.txtParActual.Location = new System.Drawing.Point(82, 115);
            this.txtParActual.Name = "txtParActual";
            this.txtParActual.Size = new System.Drawing.Size(100, 20);
            this.txtParActual.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Par Actual";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(199, 365);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 15;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(304, 365);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 16;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(483, 365);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtObjetivo
            // 
            this.txtObjetivo.Enabled = false;
            this.txtObjetivo.Location = new System.Drawing.Point(465, 73);
            this.txtObjetivo.Name = "txtObjetivo";
            this.txtObjetivo.Size = new System.Drawing.Size(93, 20);
            this.txtObjetivo.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(401, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Objetivo";
            // 
            // RegistrarDefectoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 428);
            this.Controls.Add(this.txtObjetivo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.txtParActual);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCantPares);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumeroOp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrarDefectoForm";
            this.Text = "Inspeccion";
            this.Load += new System.EventHandler(this.RegistrarDefectoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoDefectoIzquierdo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDefectoPieIzquierdo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoDefectoDerecho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDefectoPieDerecho)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTipoDefectoIzq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDefectosIzq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbTipoDefectoDer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDefectosDer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroOp;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantPares;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtParActual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.BindingSource bsDefectoPieDerecho;
        private System.Windows.Forms.BindingSource bsTipoDefectoDerecho;
        private System.Windows.Forms.BindingSource bsDefectoPieIzquierdo;
        private System.Windows.Forms.BindingSource bsTipoDefectoIzquierdo;
        private System.Windows.Forms.TextBox txtObjetivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chbAprobadoIzq;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chbAprobadoDer;
        private System.Windows.Forms.Label label12;
    }
}