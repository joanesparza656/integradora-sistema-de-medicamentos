namespace SistemaMedicamentos
{
    partial class Catalogo
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
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtArea = new TextBox();
            cmbCategoria = new ComboBox();
            cmbPrioridad = new ComboBox();
            numCantidad = new NumericUpDown();
            btnAgregar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(15, 44);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(150, 31);
            txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(15, 102);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 1;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(15, 156);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(150, 31);
            txtArea.TabIndex = 2;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(419, 44);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(182, 33);
            cmbCategoria.TabIndex = 4;
            // 
            // cmbPrioridad
            // 
            cmbPrioridad.FormattingEnabled = true;
            cmbPrioridad.Location = new Point(193, 44);
            cmbPrioridad.Name = "cmbPrioridad";
            cmbPrioridad.Size = new Size(182, 33);
            cmbPrioridad.TabIndex = 5;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(618, 44);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(170, 31);
            numCantidad.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(15, 245);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 68);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(193, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(580, 255);
            dataGridView1.TabIndex = 8;
            // 
            // Catalogo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregar);
            Controls.Add(numCantidad);
            Controls.Add(cmbPrioridad);
            Controls.Add(cmbCategoria);
            Controls.Add(txtArea);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Name = "Catalogo";
            Text = "Catalogo";
            Load += Catalogo_Load;
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtArea;
        private ComboBox cmbCategoria;
        private ComboBox cmbPrioridad;
        private NumericUpDown numCantidad;
        private Button btnAgregar;
        private DataGridView dataGridView1;
    }
}