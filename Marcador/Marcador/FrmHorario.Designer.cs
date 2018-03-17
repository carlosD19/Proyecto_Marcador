namespace Marcador
{
    partial class FrmHorario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHorario));
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.dtDia = new System.Windows.Forms.DateTimePicker();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.lblError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaIniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.horarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Día:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Hora de Fin:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Hora de Inicio:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(43, 55);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(198, 26);
            this.txtCodigo.TabIndex = 22;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCod_Changed);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(148, 304);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 26);
            this.btnAceptar.TabIndex = 23;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvHorarios
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHorarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHorarios.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.diaDataGridViewTextBoxColumn,
            this.horaIniDataGridViewTextBoxColumn,
            this.horaFinDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn});
            this.dgvHorarios.DataSource = this.horarioBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHorarios.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHorarios.Location = new System.Drawing.Point(276, 55);
            this.dgvHorarios.MultiSelect = false;
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.Size = new System.Drawing.Size(563, 220);
            this.dgvHorarios.TabIndex = 24;
            this.dgvHorarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHorarios_CellMouseClick);
            // 
            // dtDia
            // 
            this.dtDia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDia.Location = new System.Drawing.Point(43, 128);
            this.dtDia.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtDia.Name = "dtDia";
            this.dtDia.Size = new System.Drawing.Size(198, 26);
            this.dtDia.TabIndex = 25;
            this.dtDia.Value = new System.DateTime(2018, 3, 8, 0, 0, 0, 0);
            // 
            // dtFin
            // 
            this.dtFin.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtFin.Location = new System.Drawing.Point(43, 249);
            this.dtFin.Name = "dtFin";
            this.dtFin.ShowUpDown = true;
            this.dtFin.Size = new System.Drawing.Size(198, 26);
            this.dtFin.TabIndex = 28;
            this.dtFin.Value = new System.DateTime(2018, 3, 8, 11, 30, 0, 0);
            // 
            // dtInicio
            // 
            this.dtInicio.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtInicio.Location = new System.Drawing.Point(43, 183);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.ShowUpDown = true;
            this.dtInicio.Size = new System.Drawing.Size(198, 26);
            this.dtInicio.TabIndex = 29;
            this.dtInicio.Value = new System.DateTime(2018, 3, 8, 8, 0, 0, 0);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(3, 355);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Horarios Registrados.";
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaDataGridViewTextBoxColumn
            // 
            this.diaDataGridViewTextBoxColumn.DataPropertyName = "Dia";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "dddd";
            dataGridViewCellStyle4.NullValue = null;
            this.diaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.diaDataGridViewTextBoxColumn.HeaderText = "Día";
            this.diaDataGridViewTextBoxColumn.Name = "diaDataGridViewTextBoxColumn";
            this.diaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaIniDataGridViewTextBoxColumn
            // 
            this.horaIniDataGridViewTextBoxColumn.DataPropertyName = "HoraIni";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "t";
            dataGridViewCellStyle5.NullValue = null;
            this.horaIniDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.horaIniDataGridViewTextBoxColumn.HeaderText = "Hora Inicio";
            this.horaIniDataGridViewTextBoxColumn.Name = "horaIniDataGridViewTextBoxColumn";
            this.horaIniDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaIniDataGridViewTextBoxColumn.Width = 130;
            // 
            // horaFinDataGridViewTextBoxColumn
            // 
            this.horaFinDataGridViewTextBoxColumn.DataPropertyName = "HoraFin";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Format = "t";
            dataGridViewCellStyle6.NullValue = null;
            this.horaFinDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.horaFinDataGridViewTextBoxColumn.HeaderText = "Hora Fin";
            this.horaFinDataGridViewTextBoxColumn.Name = "horaFinDataGridViewTextBoxColumn";
            this.horaFinDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaFinDataGridViewTextBoxColumn.Width = 130;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.NullValue = false;
            this.activoDataGridViewCheckBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activoDataGridViewCheckBoxColumn.Width = 60;
            // 
            // horarioBindingSource
            // 
            this.horarioBindingSource.DataSource = typeof(RelojMarcadorENL.Horario);
            // 
            // FrmHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(867, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.dtDia);
            this.Controls.Add(this.dgvHorarios);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "FrmHorario";
            this.Text = "FrmHorario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHorario_FormClosing);
            this.Load += new System.EventHandler(this.FrmHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.BindingSource horarioBindingSource;
        private System.Windows.Forms.DateTimePicker dtDia;
        internal System.Windows.Forms.DateTimePicker dtFin;
        internal System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaIniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label1;
    }
}