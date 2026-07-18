namespace ProyectoLogin
{
    partial class ConexionForm
    {
        private void InitializeComponent()
        {
            this.btnConectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            this.btnConectar.Location = new System.Drawing.Point(100, 100);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(100, 30);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // ConexionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.btnConectar);
            this.Name = "ConexionForm";
            this.Text = "Conexión";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnConectar;
    }
}