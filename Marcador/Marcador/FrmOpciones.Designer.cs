namespace Marcador
{
    partial class FrmOpciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpciones));
            this.rbPrimero = new System.Windows.Forms.RadioButton();
            this.rbSegundo = new System.Windows.Forms.RadioButton();
            this.rbTercero = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbPrimero
            // 
            this.rbPrimero.AutoSize = true;
            this.rbPrimero.BackColor = System.Drawing.Color.Transparent;
            this.rbPrimero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrimero.Location = new System.Drawing.Point(108, 43);
            this.rbPrimero.Name = "rbPrimero";
            this.rbPrimero.Size = new System.Drawing.Size(68, 22);
            this.rbPrimero.TabIndex = 0;
            this.rbPrimero.TabStop = true;
            this.rbPrimero.Text = "Curso";
            this.rbPrimero.UseVisualStyleBackColor = false;
            // 
            // rbSegundo
            // 
            this.rbSegundo.AutoSize = true;
            this.rbSegundo.BackColor = System.Drawing.Color.Transparent;
            this.rbSegundo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSegundo.Location = new System.Drawing.Point(108, 76);
            this.rbSegundo.Name = "rbSegundo";
            this.rbSegundo.Size = new System.Drawing.Size(144, 22);
            this.rbSegundo.TabIndex = 1;
            this.rbSegundo.TabStop = true;
            this.rbSegundo.Text = "Consulta y Curso";
            this.rbSegundo.UseVisualStyleBackColor = false;
            // 
            // rbTercero
            // 
            this.rbTercero.AutoSize = true;
            this.rbTercero.BackColor = System.Drawing.Color.Transparent;
            this.rbTercero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTercero.Location = new System.Drawing.Point(108, 109);
            this.rbTercero.Name = "rbTercero";
            this.rbTercero.Size = new System.Drawing.Size(140, 22);
            this.rbTercero.TabIndex = 2;
            this.rbTercero.TabStop = true;
            this.rbTercero.Text = "Reunión y Curso";
            this.rbTercero.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(141, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(356, 218);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbTercero);
            this.Controls.Add(this.rbSegundo);
            this.Controls.Add(this.rbPrimero);
            this.Name = "FrmOpciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmOpciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPrimero;
        private System.Windows.Forms.RadioButton rbSegundo;
        private System.Windows.Forms.RadioButton rbTercero;
        private System.Windows.Forms.Button button1;
    }
}