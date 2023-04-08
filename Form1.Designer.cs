namespace CubiculosBiblioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnDesocupar = new System.Windows.Forms.Button();
            this.btnOcupar = new System.Windows.Forms.Button();
            this.btnDato = new System.Windows.Forms.Button();
            this.chbCubiculo3 = new System.Windows.Forms.CheckBox();
            this.chbCubiculo2 = new System.Windows.Forms.CheckBox();
            this.chbCubiculo1 = new System.Windows.Forms.CheckBox();
            this.lblCubiculo1 = new System.Windows.Forms.Label();
            this.lblCubiculo2 = new System.Windows.Forms.Label();
            this.lblCubiculo3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 15);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(67, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(122, 23);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // btnDesocupar
            // 
            this.btnDesocupar.Enabled = false;
            this.btnDesocupar.Location = new System.Drawing.Point(276, 6);
            this.btnDesocupar.Name = "btnDesocupar";
            this.btnDesocupar.Size = new System.Drawing.Size(75, 23);
            this.btnDesocupar.TabIndex = 7;
            this.btnDesocupar.Text = "Desocupar";
            this.btnDesocupar.UseVisualStyleBackColor = true;
            this.btnDesocupar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnOcupar
            // 
            this.btnOcupar.Enabled = false;
            this.btnOcupar.Location = new System.Drawing.Point(195, 6);
            this.btnOcupar.Name = "btnOcupar";
            this.btnOcupar.Size = new System.Drawing.Size(75, 23);
            this.btnOcupar.TabIndex = 8;
            this.btnOcupar.Text = "Ocupar";
            this.btnOcupar.UseVisualStyleBackColor = true;
            this.btnOcupar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnDato
            // 
            this.btnDato.Location = new System.Drawing.Point(357, 6);
            this.btnDato.Name = "btnDato";
            this.btnDato.Size = new System.Drawing.Size(75, 23);
            this.btnDato.TabIndex = 14;
            this.btnDato.Text = "Registro";
            this.btnDato.UseVisualStyleBackColor = true;
            this.btnDato.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // chbCubiculo3
            // 
            this.chbCubiculo3.AutoSize = true;
            this.chbCubiculo3.Location = new System.Drawing.Point(12, 99);
            this.chbCubiculo3.Name = "chbCubiculo3";
            this.chbCubiculo3.Size = new System.Drawing.Size(83, 19);
            this.chbCubiculo3.TabIndex = 2;
            this.chbCubiculo3.Text = "Cubiculo 3";
            this.chbCubiculo3.UseVisualStyleBackColor = true;
            this.chbCubiculo3.CheckedChanged += new System.EventHandler(this.chbCubiculo3_CheckedChanged);
            // 
            // chbCubiculo2
            // 
            this.chbCubiculo2.AutoSize = true;
            this.chbCubiculo2.Location = new System.Drawing.Point(12, 74);
            this.chbCubiculo2.Name = "chbCubiculo2";
            this.chbCubiculo2.Size = new System.Drawing.Size(83, 19);
            this.chbCubiculo2.TabIndex = 1;
            this.chbCubiculo2.Text = "Cubiculo 2";
            this.chbCubiculo2.UseVisualStyleBackColor = true;
            this.chbCubiculo2.CheckedChanged += new System.EventHandler(this.chbCubiculo2_CheckedChanged);
            // 
            // chbCubiculo1
            // 
            this.chbCubiculo1.AutoSize = true;
            this.chbCubiculo1.Location = new System.Drawing.Point(12, 49);
            this.chbCubiculo1.Name = "chbCubiculo1";
            this.chbCubiculo1.Size = new System.Drawing.Size(83, 19);
            this.chbCubiculo1.TabIndex = 0;
            this.chbCubiculo1.Text = "Cubiculo 1";
            this.chbCubiculo1.UseVisualStyleBackColor = true;
            this.chbCubiculo1.CheckedChanged += new System.EventHandler(this.chbCubiculo1_CheckedChanged);
            // 
            // lblCubiculo1
            // 
            this.lblCubiculo1.AutoSize = true;
            this.lblCubiculo1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblCubiculo1.Location = new System.Drawing.Point(101, 50);
            this.lblCubiculo1.Name = "lblCubiculo1";
            this.lblCubiculo1.Size = new System.Drawing.Size(63, 15);
            this.lblCubiculo1.TabIndex = 15;
            this.lblCubiculo1.Text = "Disponible";
            this.lblCubiculo1.Click += new System.EventHandler(this.lblCubiculo1_Click);
            // 
            // lblCubiculo2
            // 
            this.lblCubiculo2.AutoSize = true;
            this.lblCubiculo2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblCubiculo2.Location = new System.Drawing.Point(101, 74);
            this.lblCubiculo2.Name = "lblCubiculo2";
            this.lblCubiculo2.Size = new System.Drawing.Size(63, 15);
            this.lblCubiculo2.TabIndex = 16;
            this.lblCubiculo2.Text = "Disponible";
            this.lblCubiculo2.Click += new System.EventHandler(this.lblCubiculo2_Click);
            // 
            // lblCubiculo3
            // 
            this.lblCubiculo3.AutoSize = true;
            this.lblCubiculo3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblCubiculo3.Location = new System.Drawing.Point(101, 99);
            this.lblCubiculo3.Name = "lblCubiculo3";
            this.lblCubiculo3.Size = new System.Drawing.Size(63, 15);
            this.lblCubiculo3.TabIndex = 17;
            this.lblCubiculo3.Text = "Disponible";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 128);
            this.Controls.Add(this.lblCubiculo3);
            this.Controls.Add(this.lblCubiculo2);
            this.Controls.Add(this.lblCubiculo1);
            this.Controls.Add(this.chbCubiculo3);
            this.Controls.Add(this.chbCubiculo2);
            this.Controls.Add(this.btnDato);
            this.Controls.Add(this.chbCubiculo1);
            this.Controls.Add(this.btnOcupar);
            this.Controls.Add(this.btnDesocupar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Button btnDesocupar;
        private Button btnOcupar;
        private Button btnDato;
        private CheckBox chbCubiculo2;
        private CheckBox chbCubiculo1;
        private CheckBox chbCubiculo3;
        private Label lblCubiculo1;
        private Label lblCubiculo2;
        private Label lblCubiculo3;
    }
}