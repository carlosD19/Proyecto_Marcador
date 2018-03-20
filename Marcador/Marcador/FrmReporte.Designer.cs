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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporte));
            this.dgDocentes = new System.Windows.Forms.DataGridView();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblReporte = new System.Windows.Forms.Label();
            this.Cedula1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tardia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ausencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedDocenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ausenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tardiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salidaAnticipadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docenteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDocentes
            // 
            this.dgDocentes.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDocentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDocentes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgDocentes.Location = new System.Drawing.Point(21, 46);
            this.dgDocentes.Name = "dgDocentes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDocentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgDocentes.Size = new System.Drawing.Size(842, 150);
            this.dgDocentes.TabIndex = 0;
            this.dgDocentes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgDocentes_CellFormatting);
            this.dgDocentes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDocentes_CellMouseClick);
            // 
            // dgvReportes
            // 
            this.dgvReportes.AllowUserToAddRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula1,
            this.Tardia,
            this.Ausencia});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReportes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReportes.Location = new System.Drawing.Point(21, 269);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.Size = new System.Drawing.Size(842, 150);
            this.dgvReportes.TabIndex = 1;
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
            // Cedula1
            // 
            this.Cedula1.HeaderText = "Cedula";
            this.Cedula1.Name = "Cedula1";
            this.Cedula1.ReadOnly = true;
            this.Cedula1.Width = 299;
            // 
            // Tardia
            // 
            this.Tardia.HeaderText = "Tardia";
            this.Tardia.Name = "Tardia";
            this.Tardia.ReadOnly = true;
            this.Tardia.Width = 250;
            // 
            // Ausencia
            // 
            this.Ausencia.HeaderText = "Ausencia";
            this.Ausencia.Name = "Ausencia";
            this.Ausencia.ReadOnly = true;
            this.Ausencia.Width = 250;
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedDocenteDataGridViewTextBoxColumn,
            this.ausenciaDataGridViewTextBoxColumn,
            this.tardiaDataGridViewTextBoxColumn,
            this.salidaAnticipadaDataGridViewTextBoxColumn,
            this.horaEntradaDataGridViewTextBoxColumn,
            this.horaSalidaDataGridViewTextBoxColumn,
            this.descripcionEDataGridViewTextBoxColumn,
            this.descripcionSDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn});
            this.dgvMarcas.DataSource = this.reporteBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMarcas.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMarcas.Location = new System.Drawing.Point(21, 438);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.Size = new System.Drawing.Size(842, 156);
            this.dgvMarcas.TabIndex = 4;
            // 
            // Sexo
            // 
            this.Sexo.Frozen = true;
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // cedDocenteDataGridViewTextBoxColumn
            // 
            this.cedDocenteDataGridViewTextBoxColumn.DataPropertyName = "CedDocente";
            this.cedDocenteDataGridViewTextBoxColumn.HeaderText = "Cédula Docente";
            this.cedDocenteDataGridViewTextBoxColumn.Name = "cedDocenteDataGridViewTextBoxColumn";
            this.cedDocenteDataGridViewTextBoxColumn.Width = 139;
            // 
            // ausenciaDataGridViewTextBoxColumn
            // 
            this.ausenciaDataGridViewTextBoxColumn.DataPropertyName = "Ausencia";
            this.ausenciaDataGridViewTextBoxColumn.HeaderText = "Ausencia";
            this.ausenciaDataGridViewTextBoxColumn.Name = "ausenciaDataGridViewTextBoxColumn";
            this.ausenciaDataGridViewTextBoxColumn.Visible = false;
            // 
            // tardiaDataGridViewTextBoxColumn
            // 
            this.tardiaDataGridViewTextBoxColumn.DataPropertyName = "Tardia";
            this.tardiaDataGridViewTextBoxColumn.HeaderText = "Tardia";
            this.tardiaDataGridViewTextBoxColumn.Name = "tardiaDataGridViewTextBoxColumn";
            this.tardiaDataGridViewTextBoxColumn.Visible = false;
            // 
            // salidaAnticipadaDataGridViewTextBoxColumn
            // 
            this.salidaAnticipadaDataGridViewTextBoxColumn.DataPropertyName = "SalidaAnticipada";
            this.salidaAnticipadaDataGridViewTextBoxColumn.HeaderText = "SalidaAnticipada";
            this.salidaAnticipadaDataGridViewTextBoxColumn.Name = "salidaAnticipadaDataGridViewTextBoxColumn";
            this.salidaAnticipadaDataGridViewTextBoxColumn.Visible = false;
            // 
            // horaEntradaDataGridViewTextBoxColumn
            // 
            this.horaEntradaDataGridViewTextBoxColumn.DataPropertyName = "HoraEntrada";
            dataGridViewCellStyle7.Format = "t";
            this.horaEntradaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.horaEntradaDataGridViewTextBoxColumn.HeaderText = "Hora Entrada";
            this.horaEntradaDataGridViewTextBoxColumn.Name = "horaEntradaDataGridViewTextBoxColumn";
            this.horaEntradaDataGridViewTextBoxColumn.Width = 130;
            // 
            // horaSalidaDataGridViewTextBoxColumn
            // 
            this.horaSalidaDataGridViewTextBoxColumn.DataPropertyName = "HoraSalida";
            dataGridViewCellStyle8.Format = "t";
            this.horaSalidaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.horaSalidaDataGridViewTextBoxColumn.HeaderText = "Hora Salida";
            this.horaSalidaDataGridViewTextBoxColumn.Name = "horaSalidaDataGridViewTextBoxColumn";
            this.horaSalidaDataGridViewTextBoxColumn.Width = 130;
            // 
            // descripcionEDataGridViewTextBoxColumn
            // 
            this.descripcionEDataGridViewTextBoxColumn.DataPropertyName = "DescripcionE";
            this.descripcionEDataGridViewTextBoxColumn.HeaderText = "Descripcion Entrada";
            this.descripcionEDataGridViewTextBoxColumn.Name = "descripcionEDataGridViewTextBoxColumn";
            this.descripcionEDataGridViewTextBoxColumn.Width = 200;
            // 
            // descripcionSDataGridViewTextBoxColumn
            // 
            this.descripcionSDataGridViewTextBoxColumn.DataPropertyName = "DescripcionS";
            this.descripcionSDataGridViewTextBoxColumn.HeaderText = "Descripcion Salida";
            this.descripcionSDataGridViewTextBoxColumn.Name = "descripcionSDataGridViewTextBoxColumn";
            this.descripcionSDataGridViewTextBoxColumn.Width = 200;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.Visible = false;
            // 
            // reporteBindingSource
            // 
            this.reporteBindingSource.DataSource = typeof(RelojMarcadorENL.Reporte);
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
            this.nombreDataGridViewTextBoxColumn.Width = 105;
            // 
            // apellidoUnoDataGridViewTextBoxColumn
            // 
            this.apellidoUnoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoUno";
            this.apellidoUnoDataGridViewTextBoxColumn.Frozen = true;
            this.apellidoUnoDataGridViewTextBoxColumn.HeaderText = "Primer Apellido";
            this.apellidoUnoDataGridViewTextBoxColumn.Name = "apellidoUnoDataGridViewTextBoxColumn";
            this.apellidoUnoDataGridViewTextBoxColumn.Width = 120;
            // 
            // apellidoDosDataGridViewTextBoxColumn
            // 
            this.apellidoDosDataGridViewTextBoxColumn.DataPropertyName = "ApellidoDos";
            this.apellidoDosDataGridViewTextBoxColumn.Frozen = true;
            this.apellidoDosDataGridViewTextBoxColumn.HeaderText = "Segundo Apellido";
            this.apellidoDosDataGridViewTextBoxColumn.Name = "apellidoDosDataGridViewTextBoxColumn";
            this.apellidoDosDataGridViewTextBoxColumn.Width = 120;
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
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Frozen = true;
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.Width = 105;
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
            this.activoDataGridViewCheckBoxColumn.Visible = false;
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
            this.ClientSize = new System.Drawing.Size(885, 665);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.lblReporte);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvReportes);
            this.Controls.Add(this.dgDocentes);
            this.Name = "FrmReporte";
            this.Text = "FrmReporte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReporte_FormClosing);
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDocentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docenteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDocentes;
        private System.Windows.Forms.BindingSource docenteBindingSource;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tardia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ausencia;
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
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedDocenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ausenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tardiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salidaAnticipadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reporteBindingSource;
    }
}