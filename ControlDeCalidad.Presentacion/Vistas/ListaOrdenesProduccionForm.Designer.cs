namespace ControlDeCalidad.Presentacion.Vistas
{
    partial class ListaOrdenesProduccionForm
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
            this.dgvOrdenesProduccion = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisorCalidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsOrdenesProduccion = new System.Windows.Forms.BindingSource(this.components);
            this.btnTrabajar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesProduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrdenesProduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrdenesProduccion
            // 
            this.dgvOrdenesProduccion.AllowUserToAddRows = false;
            this.dgvOrdenesProduccion.AllowUserToDeleteRows = false;
            this.dgvOrdenesProduccion.AutoGenerateColumns = false;
            this.dgvOrdenesProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenesProduccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.supervisorCalidadDataGridViewTextBoxColumn});
            this.dgvOrdenesProduccion.DataSource = this.bsOrdenesProduccion;
            this.dgvOrdenesProduccion.Location = new System.Drawing.Point(12, 12);
            this.dgvOrdenesProduccion.Name = "dgvOrdenesProduccion";
            this.dgvOrdenesProduccion.ReadOnly = true;
            this.dgvOrdenesProduccion.Size = new System.Drawing.Size(543, 325);
            this.dgvOrdenesProduccion.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Numero";
            this.dataGridViewTextBoxColumn1.HeaderText = "Numero";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LineaTrabajo";
            this.dataGridViewTextBoxColumn2.HeaderText = "LineaTrabajo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EstadoOrdenProduccion";
            this.dataGridViewTextBoxColumn3.HeaderText = "EstadoOrdenProduccion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // supervisorCalidadDataGridViewTextBoxColumn
            // 
            this.supervisorCalidadDataGridViewTextBoxColumn.DataPropertyName = "SupervisorCalidad";
            this.supervisorCalidadDataGridViewTextBoxColumn.HeaderText = "SupervisorCalidad";
            this.supervisorCalidadDataGridViewTextBoxColumn.Name = "supervisorCalidadDataGridViewTextBoxColumn";
            this.supervisorCalidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsOrdenesProduccion
            // 
            this.bsOrdenesProduccion.DataSource = typeof(ControlDeCalidad.Dominio.OrdenProduccion);
            // 
            // btnTrabajar
            // 
            this.btnTrabajar.Location = new System.Drawing.Point(579, 12);
            this.btnTrabajar.Name = "btnTrabajar";
            this.btnTrabajar.Size = new System.Drawing.Size(75, 23);
            this.btnTrabajar.TabIndex = 1;
            this.btnTrabajar.Text = "Trabajar";
            this.btnTrabajar.UseVisualStyleBackColor = true;
            this.btnTrabajar.Click += new System.EventHandler(this.btnTrabajar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(579, 314);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(579, 76);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Nueva OP";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(579, 142);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 44);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar Estado";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // ListaOrdenesProduccionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 349);
            this.Controls.Add(this.dgvOrdenesProduccion);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnTrabajar);
            this.Name = "ListaOrdenesProduccionForm";
            this.Text = "Listado de Ordenes Produccion";
            this.Activated += new System.EventHandler(this.ListaOrdenesProduccionForm_Activated);
            this.Load += new System.EventHandler(this.ListaOrdenesProduccionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesProduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrdenesProduccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrdenesProduccion;
        private System.Windows.Forms.Button btnTrabajar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.BindingSource bsOrdenesProduccion;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineaTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoOrdenProduccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoOrdenDeProduccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisorCalidadDataGridViewTextBoxColumn;
    }
}