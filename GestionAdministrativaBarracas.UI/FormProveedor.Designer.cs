namespace GestionAdministrativaBarracas.UI
{
    partial class FormProveedor
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
            this.lNombre = new System.Windows.Forms.Label();
            this.lCUIT = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCUIT = new System.Windows.Forms.TextBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(27, 45);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(47, 13);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre:";
            // 
            // lCUIT
            // 
            this.lCUIT.AutoSize = true;
            this.lCUIT.Location = new System.Drawing.Point(27, 71);
            this.lCUIT.Name = "lCUIT";
            this.lCUIT.Size = new System.Drawing.Size(35, 13);
            this.lCUIT.TabIndex = 1;
            this.lCUIT.Text = "CUIT:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(82, 42);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // tbCUIT
            // 
            this.tbCUIT.Location = new System.Drawing.Point(82, 68);
            this.tbCUIT.Name = "tbCUIT";
            this.tbCUIT.Size = new System.Drawing.Size(100, 20);
            this.tbCUIT.TabIndex = 3;
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(82, 94);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 4;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // FormProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 257);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.tbCUIT);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lCUIT);
            this.Controls.Add(this.lNombre);
            this.Name = "FormProveedor";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.Proveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lCUIT;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCUIT;
        private System.Windows.Forms.Button bGuardar;
    }
}