namespace ProyectoLogin
{
    partial class FrmCatClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCatClientes));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtmNuevo = new System.Windows.Forms.ToolStripButton();
            this.BtmGuardar = new System.Windows.Forms.ToolStripButton();
            this.BtmEliminar = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctid = new System.Windows.Forms.TextBox();
            this.ctNombre = new System.Windows.Forms.TextBox();
            this.ctEdad = new System.Windows.Forms.TextBox();
            this.ctEmail = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtmNuevo,
            this.BtmGuardar,
            this.BtmEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtmNuevo
            // 
            this.BtmNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtmNuevo.Image")));
            this.BtmNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtmNuevo.Name = "BtmNuevo";
            this.BtmNuevo.Size = new System.Drawing.Size(92, 29);
            this.BtmNuevo.Text = "Nuevo";
            // 
            // BtmGuardar
            // 
            this.BtmGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtmGuardar.Image")));
            this.BtmGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtmGuardar.Name = "BtmGuardar";
            this.BtmGuardar.Size = new System.Drawing.Size(103, 29);
            this.BtmGuardar.Text = "Guardar";
            // 
            // BtmEliminar
            // 
            this.BtmEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtmEliminar.Image")));
            this.BtmEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtmEliminar.Name = "BtmEliminar";
            this.BtmEliminar.Size = new System.Drawing.Size(102, 29);
            this.BtmEliminar.Text = "Eliminar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(747, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-4, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // ctid
            // 
            this.ctid.Location = new System.Drawing.Point(71, 60);
            this.ctid.Name = "ctid";
            this.ctid.Size = new System.Drawing.Size(100, 26);
            this.ctid.TabIndex = 7;
            this.ctid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ctNombre
            // 
            this.ctNombre.Location = new System.Drawing.Point(71, 92);
            this.ctNombre.Name = "ctNombre";
            this.ctNombre.Size = new System.Drawing.Size(235, 26);
            this.ctNombre.TabIndex = 8;
            // 
            // ctEdad
            // 
            this.ctEdad.Location = new System.Drawing.Point(71, 138);
            this.ctEdad.Name = "ctEdad";
            this.ctEdad.Size = new System.Drawing.Size(100, 26);
            this.ctEdad.TabIndex = 9;
            // 
            // ctEmail
            // 
            this.ctEmail.Location = new System.Drawing.Point(71, 170);
            this.ctEmail.Name = "ctEmail";
            this.ctEmail.Size = new System.Drawing.Size(235, 26);
            this.ctEmail.TabIndex = 10;
            // 
            // FrmCatClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctEmail);
            this.Controls.Add(this.ctEdad);
            this.Controls.Add(this.ctNombre);
            this.Controls.Add(this.ctid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCatClientes";
            this.Text = "Catalogos de clientes";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtmNuevo;
        private System.Windows.Forms.ToolStripButton BtmGuardar;
        private System.Windows.Forms.ToolStripButton BtmEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ctid;
        private System.Windows.Forms.TextBox ctNombre;
        private System.Windows.Forms.TextBox ctEdad;
        private System.Windows.Forms.TextBox ctEmail;
    }
}