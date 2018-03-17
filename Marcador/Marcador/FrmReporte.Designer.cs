namespace Marcador
{
    partial class FrmReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporte));
            this.dgDocentes = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblReporte = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoUnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.docenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgDocentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docenteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDocentes
            // 
            this.dgDocentes.AutoGenerateColumns = false;
            this.dgDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedulaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoUnoDataGridViewTextBoxColumn,
            this.apellidoDosDataGridViewTextBoxColumn,
            this.Sexo1,
            this.Sexo,
            this.emailDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.pinDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn,
            this.estadoDataGridViewCheckBoxColumn});
            this.dgDocentes.DataSource = this.docenteBindingSource;
            this.dgDocentes.Location = new System.Drawing.Point(21, 46);
            this.dgDocentes.Name = "dgDocentes";
            this.dgDocentes.Size = new System.Drawing.Size(842, 150);
            this.dgDocentes.TabIndex = 0;
            this.dgDocentes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgDocentes_CellFormatting);
            this.dgDocentes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDocentes_CellMouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ausencias y tardías",
            "Más y menos destacado",
            "Marcas de docentes"});
            this.comboBox1.Location = new System.Drawing.Point(21, 232);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 26);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblReporte
            // 
            this.lblReporte.AutoSize = true;
            this.lblReporte.BackColor = System.Drawing.Color.Transparent;
            this.lblReporte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporte.Location = new System.Drawing.Point(18, 211);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Size = new System.Drawing.Size(76, 18);
            this.lblReporte.TabIndex = 3;
            this.lblReporte.Text = "Reportes:";
            // 
            // Sexo
            // 
            this.Sexo.Frozen = true;
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Frozen = true;
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Frozen = true;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoUnoDataGridViewTextBoxColumn
            // 
            this.apellidoUnoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoUno";
            this.apellidoUnoDataGridViewTextBoxColumn.Frozen = true;
            this.apellidoUnoDataGridViewTextBoxColumn.HeaderText = "ApellidoUno";
            this.apellidoUnoDataGridViewTextBoxColumn.Name = "apellidoUnoDataGridViewTextBoxColumn";
            // 
            // apellidoDosDataGridViewTextBoxColumn
            // 
            this.apellidoDosDataGridViewTextBoxColumn.DataPropertyName = "ApellidoDos";
            this.apellidoDosDataGridViewTextBoxColumn.Frozen = true;
            this.apellidoDosDataGridViewTextBoxColumn.HeaderText = "ApellidoDos";
            this.apellidoDosDataGridViewTextBoxColumn.Name = "apellidoDosDataGridViewTextBoxColumn";
            // 
            // Sexo1
            // 
            this.Sexo1.DataPropertyName = "Sexo";
            this.Sexo1.Frozen = true;
            this.Sexo1.HeaderText = "Sexo1";
            this.Sexo1.Name = "Sexo1";
            this.Sexo1.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.Frozen = true;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Frozen = true;
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // pinDataGridViewTextBoxColumn
            // 
            this.pinDataGridViewTextBoxColumn.DataPropertyName = "Pin";
            this.pinDataGridViewTextBoxColumn.Frozen = true;
            this.pinDataGridViewTextBoxColumn.HeaderText = "Pin";
            this.pinDataGridViewTextBoxColumn.Name = "pinDataGridViewTextBoxColumn";
            this.pinDataGridViewTextBoxColumn.Visible = false;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.Frozen = true;
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            this.estadoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // docenteBindingSource
            // 
            this.docenteBindingSource.DataSource = typeof(RelojMarcadorENL.Docente);
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.lblReporte);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgDocentes);
            this.Name = "FrmReporte";
            this.Text = "FrmReporte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReporte_FormClosing);
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDocentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docenteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDocentes;
        private System.Windows.Forms.BindingSource docenteBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoUnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sexo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
    }
}