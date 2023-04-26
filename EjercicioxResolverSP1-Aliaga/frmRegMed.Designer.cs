namespace EjercicioxResolverSP1_Aliaga
{
    partial class frmRegMed
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
            this.mrcRegistroMed = new System.Windows.Forms.GroupBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.btnRegMed = new System.Windows.Forms.Button();
            this.lblID2 = new System.Windows.Forms.Label();
            this.lblMatr = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblNomMed = new System.Windows.Forms.Label();
            this.txtNombreMed = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mrcRegistroMed.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcRegistroMed
            // 
            this.mrcRegistroMed.Controls.Add(this.cmbEspecialidad);
            this.mrcRegistroMed.Controls.Add(this.btnRegMed);
            this.mrcRegistroMed.Controls.Add(this.lblID2);
            this.mrcRegistroMed.Controls.Add(this.lblMatr);
            this.mrcRegistroMed.Controls.Add(this.txtMatricula);
            this.mrcRegistroMed.Controls.Add(this.lblNomMed);
            this.mrcRegistroMed.Controls.Add(this.txtNombreMed);
            this.mrcRegistroMed.Location = new System.Drawing.Point(30, 25);
            this.mrcRegistroMed.Name = "mrcRegistroMed";
            this.mrcRegistroMed.Size = new System.Drawing.Size(321, 183);
            this.mrcRegistroMed.TabIndex = 2;
            this.mrcRegistroMed.TabStop = false;
            this.mrcRegistroMed.Text = "Registro de nuevo médico";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(171, 97);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(100, 21);
            this.cmbEspecialidad.TabIndex = 6;
            // 
            // btnRegMed
            // 
            this.btnRegMed.Location = new System.Drawing.Point(171, 140);
            this.btnRegMed.Name = "btnRegMed";
            this.btnRegMed.Size = new System.Drawing.Size(100, 28);
            this.btnRegMed.TabIndex = 3;
            this.btnRegMed.Text = "Registrar &medico";
            this.btnRegMed.UseVisualStyleBackColor = true;
            this.btnRegMed.Click += new System.EventHandler(this.btnRegMed_Click);
            // 
            // lblID2
            // 
            this.lblID2.AutoSize = true;
            this.lblID2.Location = new System.Drawing.Point(40, 100);
            this.lblID2.Name = "lblID2";
            this.lblID2.Size = new System.Drawing.Size(107, 13);
            this.lblID2.TabIndex = 5;
            this.lblID2.Text = "ID de la Especialidad";
            // 
            // lblMatr
            // 
            this.lblMatr.AutoSize = true;
            this.lblMatr.Location = new System.Drawing.Point(95, 29);
            this.lblMatr.Name = "lblMatr";
            this.lblMatr.Size = new System.Drawing.Size(52, 13);
            this.lblMatr.TabIndex = 2;
            this.lblMatr.Text = "Matrícula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(171, 26);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 0;
            this.txtMatricula.TextChanged += new System.EventHandler(this.txtMatricula_TextChanged);
            // 
            // lblNomMed
            // 
            this.lblNomMed.AutoSize = true;
            this.lblNomMed.Location = new System.Drawing.Point(49, 64);
            this.lblNomMed.Name = "lblNomMed";
            this.lblNomMed.Size = new System.Drawing.Size(98, 13);
            this.lblNomMed.TabIndex = 3;
            this.lblNomMed.Text = "Nombre del médico";
            // 
            // txtNombreMed
            // 
            this.txtNombreMed.Location = new System.Drawing.Point(171, 61);
            this.txtNombreMed.Name = "txtNombreMed";
            this.txtNombreMed.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMed.TabIndex = 1;
            this.txtNombreMed.TextChanged += new System.EventHandler(this.txtNombreMed_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(357, 78);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 24);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Volver";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmRegMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 272);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.mrcRegistroMed);
            this.Name = "frmRegMed";
            this.Text = "Registro de médicos nuevos - Clínica La Gloriosa";
            this.Load += new System.EventHandler(this.frmRegMed_Load);
            this.mrcRegistroMed.ResumeLayout(false);
            this.mrcRegistroMed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcRegistroMed;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Button btnRegMed;
        private System.Windows.Forms.Label lblID2;
        private System.Windows.Forms.Label lblMatr;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblNomMed;
        private System.Windows.Forms.TextBox txtNombreMed;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button2;
    }
}