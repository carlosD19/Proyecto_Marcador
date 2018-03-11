namespace Marcador
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.horarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarHorario = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarHorario = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarHorario = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.txtCuatro = new System.Windows.Forms.TextBox();
            this.txtTres = new System.Windows.Forms.TextBox();
            this.txtDos = new System.Windows.Forms.TextBox();
            this.txtUno = new System.Windows.Forms.TextBox();
            this.btnReportes = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docenteToolStripMenuItem,
            this.cursoToolStripMenuItem,
            this.horarioToolStripMenuItem});
            this.agregarToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(114, 21);
            this.agregarToolStripMenuItem1.Text = "Mantenimiento";
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarDocente,
            this.modificarDocente,
            this.eliminarDocente});
            this.docenteToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            this.docenteToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.docenteToolStripMenuItem.Text = "Docente";
            // 
            // agregarDocente
            // 
            this.agregarDocente.Name = "agregarDocente";
            this.agregarDocente.Size = new System.Drawing.Size(134, 22);
            this.agregarDocente.Text = "Agregar";
            // 
            // modificarDocente
            // 
            this.modificarDocente.Name = "modificarDocente";
            this.modificarDocente.Size = new System.Drawing.Size(134, 22);
            this.modificarDocente.Text = "Modificar";
            // 
            // eliminarDocente
            // 
            this.eliminarDocente.Name = "eliminarDocente";
            this.eliminarDocente.Size = new System.Drawing.Size(134, 22);
            this.eliminarDocente.Text = "Eliminar";
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCurso,
            this.modificarCurso,
            this.eliminarCurso});
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.cursoToolStripMenuItem.Text = "Curso";
            // 
            // agregarCurso
            // 
            this.agregarCurso.Name = "agregarCurso";
            this.agregarCurso.Size = new System.Drawing.Size(134, 22);
            this.agregarCurso.Text = "Agregar";
            // 
            // modificarCurso
            // 
            this.modificarCurso.Name = "modificarCurso";
            this.modificarCurso.Size = new System.Drawing.Size(134, 22);
            this.modificarCurso.Text = "Modificar";
            // 
            // eliminarCurso
            // 
            this.eliminarCurso.Name = "eliminarCurso";
            this.eliminarCurso.Size = new System.Drawing.Size(134, 22);
            this.eliminarCurso.Text = "Eliminar";
            // 
            // horarioToolStripMenuItem
            // 
            this.horarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarHorario,
            this.modificarHorario,
            this.eliminarHorario});
            this.horarioToolStripMenuItem.Name = "horarioToolStripMenuItem";
            this.horarioToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.horarioToolStripMenuItem.Text = "Horario";
            // 
            // agregarHorario
            // 
            this.agregarHorario.Name = "agregarHorario";
            this.agregarHorario.Size = new System.Drawing.Size(134, 22);
            this.agregarHorario.Text = "Agregar";
            // 
            // modificarHorario
            // 
            this.modificarHorario.Name = "modificarHorario";
            this.modificarHorario.Size = new System.Drawing.Size(134, 22);
            this.modificarHorario.Text = "Modificar";
            // 
            // eliminarHorario
            // 
            this.eliminarHorario.Name = "eliminarHorario";
            this.eliminarHorario.Size = new System.Drawing.Size(134, 22);
            this.eliminarHorario.Text = "Eliminar";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnCero);
            this.groupBox1.Controls.Add(this.btnNueve);
            this.groupBox1.Controls.Add(this.btnOcho);
            this.groupBox1.Controls.Add(this.btnSiete);
            this.groupBox1.Controls.Add(this.btnSeis);
            this.groupBox1.Controls.Add(this.btnCinco);
            this.groupBox1.Controls.Add(this.btnCuatro);
            this.groupBox1.Controls.Add(this.btnTres);
            this.groupBox1.Controls.Add(this.btnDos);
            this.groupBox1.Controls.Add(this.btnUno);
            this.groupBox1.Controls.Add(this.txtCuatro);
            this.groupBox1.Controls.Add(this.txtTres);
            this.groupBox1.Controls.Add(this.txtDos);
            this.groupBox1.Controls.Add(this.txtUno);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(335, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 343);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inicio Sesión";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(342, 78);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(30, 25);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCero
            // 
            this.btnCero.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.Location = new System.Drawing.Point(188, 290);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(38, 29);
            this.btnCero.TabIndex = 14;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueve.Location = new System.Drawing.Point(258, 242);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(38, 29);
            this.btnNueve.TabIndex = 13;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.Location = new System.Drawing.Point(188, 242);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(38, 29);
            this.btnOcho.TabIndex = 12;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiete.Location = new System.Drawing.Point(118, 242);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(38, 29);
            this.btnSiete.TabIndex = 11;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.Location = new System.Drawing.Point(258, 192);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(38, 29);
            this.btnSeis.TabIndex = 10;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.Location = new System.Drawing.Point(188, 192);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(38, 29);
            this.btnCinco.TabIndex = 9;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatro.Location = new System.Drawing.Point(118, 192);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(38, 29);
            this.btnCuatro.TabIndex = 8;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnTres
            // 
            this.btnTres.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.Location = new System.Drawing.Point(258, 142);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(38, 29);
            this.btnTres.TabIndex = 7;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnDos
            // 
            this.btnDos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.Location = new System.Drawing.Point(188, 142);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(38, 29);
            this.btnDos.TabIndex = 6;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnUno
            // 
            this.btnUno.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.Location = new System.Drawing.Point(118, 142);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(38, 29);
            this.btnUno.TabIndex = 5;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // txtCuatro
            // 
            this.txtCuatro.Enabled = false;
            this.txtCuatro.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuatro.Location = new System.Drawing.Point(290, 71);
            this.txtCuatro.Name = "txtCuatro";
            this.txtCuatro.Size = new System.Drawing.Size(35, 32);
            this.txtCuatro.TabIndex = 3;
            this.txtCuatro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTres
            // 
            this.txtTres.Enabled = false;
            this.txtTres.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTres.Location = new System.Drawing.Point(222, 71);
            this.txtTres.Name = "txtTres";
            this.txtTres.Size = new System.Drawing.Size(35, 32);
            this.txtTres.TabIndex = 2;
            this.txtTres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDos
            // 
            this.txtDos.Enabled = false;
            this.txtDos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDos.Location = new System.Drawing.Point(154, 71);
            this.txtDos.Name = "txtDos";
            this.txtDos.Size = new System.Drawing.Size(35, 32);
            this.txtDos.TabIndex = 1;
            this.txtDos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUno
            // 
            this.txtUno.Enabled = false;
            this.txtUno.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUno.Location = new System.Drawing.Point(86, 71);
            this.txtUno.Name = "txtUno";
            this.txtUno.Size = new System.Drawing.Size(35, 32);
            this.txtUno.TabIndex = 0;
            this.txtUno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUno.TextChanged += new System.EventHandler(this.txtUno_TextChanged);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReportes.Location = new System.Drawing.Point(76, 65);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(167, 162);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportes.UseVisualStyleBackColor = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(12, 407);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(42, 18);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Hora";
            // 
            // timerHora
            // 
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(815, 434);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblHora);
            this.Name = "FrmInicio";
            this.Text = "Reloj Marcador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDocente;
        private System.Windows.Forms.ToolStripMenuItem modificarDocente;
        private System.Windows.Forms.ToolStripMenuItem eliminarDocente;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCurso;
        private System.Windows.Forms.ToolStripMenuItem modificarCurso;
        private System.Windows.Forms.ToolStripMenuItem eliminarCurso;
        private System.Windows.Forms.ToolStripMenuItem horarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarHorario;
        private System.Windows.Forms.ToolStripMenuItem modificarHorario;
        private System.Windows.Forms.ToolStripMenuItem eliminarHorario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtCuatro;
        private System.Windows.Forms.TextBox txtTres;
        private System.Windows.Forms.TextBox txtDos;
        private System.Windows.Forms.TextBox txtUno;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnEliminar;
    }
}

