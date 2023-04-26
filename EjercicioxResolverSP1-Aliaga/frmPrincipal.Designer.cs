namespace EjercicioxResolverSP1_Aliaga
{
    partial class frmPrincipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSeleccione = new System.Windows.Forms.Label();
            this.btnRegEsp = new System.Windows.Forms.Button();
            this.btnRegMed = new System.Windows.Forms.Button();
            this.btnConsultarMed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Seagull", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(52, 63);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(673, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bienvenido al menú principal de \"Clínica La Gloriosa\"";
            // 
            // lblSeleccione
            // 
            this.lblSeleccione.AutoSize = true;
            this.lblSeleccione.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccione.Location = new System.Drawing.Point(249, 151);
            this.lblSeleccione.Name = "lblSeleccione";
            this.lblSeleccione.Size = new System.Drawing.Size(231, 17);
            this.lblSeleccione.TabIndex = 1;
            this.lblSeleccione.Text = "Seleccione que operación realizará";
            // 
            // btnRegEsp
            // 
            this.btnRegEsp.Location = new System.Drawing.Point(141, 261);
            this.btnRegEsp.Name = "btnRegEsp";
            this.btnRegEsp.Size = new System.Drawing.Size(119, 37);
            this.btnRegEsp.TabIndex = 2;
            this.btnRegEsp.Text = "Registrar nueva especialidad";
            this.btnRegEsp.UseVisualStyleBackColor = true;
            this.btnRegEsp.Click += new System.EventHandler(this.btnRegEsp_Click);
            // 
            // btnRegMed
            // 
            this.btnRegMed.Location = new System.Drawing.Point(314, 261);
            this.btnRegMed.Name = "btnRegMed";
            this.btnRegMed.Size = new System.Drawing.Size(119, 37);
            this.btnRegMed.TabIndex = 3;
            this.btnRegMed.Text = "Registrar nuevo médico";
            this.btnRegMed.UseVisualStyleBackColor = true;
            this.btnRegMed.Click += new System.EventHandler(this.btnRegMed_Click);
            // 
            // btnConsultarMed
            // 
            this.btnConsultarMed.Location = new System.Drawing.Point(485, 261);
            this.btnConsultarMed.Name = "btnConsultarMed";
            this.btnConsultarMed.Size = new System.Drawing.Size(119, 37);
            this.btnConsultarMed.TabIndex = 4;
            this.btnConsultarMed.Text = "Consultar médicos por especialidad";
            this.btnConsultarMed.UseVisualStyleBackColor = true;
            this.btnConsultarMed.Click += new System.EventHandler(this.btnConsultarMed_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 368);
            this.Controls.Add(this.btnConsultarMed);
            this.Controls.Add(this.btnRegMed);
            this.Controls.Add(this.btnRegEsp);
            this.Controls.Add(this.lblSeleccione);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmPrincipal";
            this.Text = "¡Bienvenido/a! - Clínica La Gloriosa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSeleccione;
        private System.Windows.Forms.Button btnRegEsp;
        private System.Windows.Forms.Button btnRegMed;
        private System.Windows.Forms.Button btnConsultarMed;
    }
}