namespace Practica_3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Cliente = new TextBox();
            TxtPelicula = new TextBox();
            textSala = new TextBox();
            textCantidad = new TextBox();
            BtnGuardar = new Button();
            BtnMostrar = new Button();
            BtnEliminar = new Button();
            dgvBoletos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBoletos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 49);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 106);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 1;
            label2.Text = "Pelicula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 173);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 2;
            label3.Text = "Sala";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 238);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 3;
            label4.Text = "Cantidad";
            // 
            // Cliente
            // 
            Cliente.Location = new Point(117, 43);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(150, 31);
            Cliente.TabIndex = 4;
            // 
            // TxtPelicula
            // 
            TxtPelicula.Location = new Point(117, 103);
            TxtPelicula.Name = "TxtPelicula";
            TxtPelicula.Size = new Size(150, 31);
            TxtPelicula.TabIndex = 5;
            // 
            // textSala
            // 
            textSala.Location = new Point(117, 170);
            textSala.Name = "textSala";
            textSala.Size = new Size(150, 31);
            textSala.TabIndex = 6;
            // 
            // textCantidad
            // 
            textCantidad.Location = new Point(117, 232);
            textCantidad.Name = "textCantidad";
            textCantidad.Size = new Size(150, 31);
            textCantidad.TabIndex = 7;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(93, 295);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(125, 51);
            BtnGuardar.TabIndex = 8;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnMostrar
            // 
            BtnMostrar.Location = new Point(260, 295);
            BtnMostrar.Name = "BtnMostrar";
            BtnMostrar.Size = new Size(117, 51);
            BtnMostrar.TabIndex = 9;
            BtnMostrar.Text = "Mostrar";
            BtnMostrar.UseVisualStyleBackColor = true;
            BtnMostrar.Click += BtnMostrar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(407, 295);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(132, 51);
            BtnEliminar.TabIndex = 10;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // dgvBoletos
            // 
            dgvBoletos.BackgroundColor = SystemColors.ActiveCaption;
            dgvBoletos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBoletos.Location = new Point(296, 38);
            dgvBoletos.Name = "dgvBoletos";
            dgvBoletos.RowHeadersWidth = 62;
            dgvBoletos.Size = new Size(680, 225);
            dgvBoletos.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 544);
            Controls.Add(dgvBoletos);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnMostrar);
            Controls.Add(BtnGuardar);
            Controls.Add(textCantidad);
            Controls.Add(textSala);
            Controls.Add(TxtPelicula);
            Controls.Add(Cliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvBoletos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Cliente;
        private TextBox TxtPelicula;
        private TextBox textSala;
        private TextBox textCantidad;
        private Button BtnGuardar;
        private Button BtnMostrar;
        private Button BtnEliminar;
        private DataGridView dgvBoletos;
    }
}
