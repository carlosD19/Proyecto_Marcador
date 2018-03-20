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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporte));
            this.docenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.Cedula1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tardia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ausencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblReporte = new System.Windows.Forms.Label();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
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
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.Nombre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApeUno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApeDos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.docenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // docenteBindingSource
            // 
            this.docenteBindingSource.DataSource = typeof(RelojMarcadorENL.Docente);
            // 
            // dgvReportes
            // 
            this.dgvReportes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula1,
            this.Tardia,
            this.Ausencia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReportes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReportes.Location = new System.Drawing.Point(21, 269);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.Size = new System.Drawing.Size(842, 150);
            this.dgvReportes.TabIndex = 1;
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
            // dgvMarcas
            // 
            this.dgvMarcas.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMarcas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMarcas.Location = new System.Drawing.Point(21, 438);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.Size = new System.Drawing.Size(842, 156);
            this.dgvMarcas.TabIndex = 4;
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
            dataGridViewCellStyle4.Format = "t";
            this.horaEntradaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.horaEntradaDataGridViewTextBoxColumn.HeaderText = "Hora Entrada";
            this.horaEntradaDataGridViewTextBoxColumn.Name = "horaEntradaDataGridViewTextBoxColumn";
            this.horaEntradaDataGridViewTextBoxColumn.Width = 130;
            // 
            // horaSalidaDataGridViewTextBoxColumn
            // 
            this.horaSalidaDataGridViewTextBoxColumn.DataPropertyName = "HoraSalida";
            dataGridViewCellStyle5.Format = "t";
            this.horaSalidaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
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
            // dgvDocentes
            // 
            this.dgvDocentes.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre1,
            this.ApeUno,
            this.ApeDos,
            this.Sexo,
            this.Telefono,
            this.Email});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocentes.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDocentes.Location = new System.Drawing.Point(21, 31);
            this.dgvDocentes.MultiSelect = false;
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentes.Size = new System.Drawing.Size(842, 150);
            this.dgvDocentes.TabIndex = 5;
            this.dgvDocentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocentes_CellClick);
            // 
            // Nombre1
            // 
            this.Nombre1.HeaderText = "Nombre";
            this.Nombre1.Name = "Nombre1";
            this.Nombre1.ReadOnly = true;
            this.Nombre1.Width = 120;
            // 
            // ApeUno
            // 
            this.ApeUno.HeaderText = "Primer Apellido";
            this.ApeUno.Name = "ApeUno";
            this.ApeUno.ReadOnly = true;
            this.ApeUno.Width = 150;
            // 
            // ApeDos
            // 
            this.ApeDos.HeaderText = "Segundo Apellido";
            this.ApeDos.Name = "ApeDos";
            this.ApeDos.ReadOnly = true;
            this.ApeDos.Width = 150;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(885, 665);
            this.Controls.Add(this.dgvDocentes);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.lblReporte);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvReportes);
            this.Name = "FrmReporte";
            this.Text = "FrmReporte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReporte_FormClosing);
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.docenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource docenteBindingSource;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tardia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ausencia;
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
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApeUno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApeDos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}