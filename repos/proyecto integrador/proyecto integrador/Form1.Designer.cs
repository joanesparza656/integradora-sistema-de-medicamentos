namespace proyecto_integrador
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
            SuspendLayout();
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
    }using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_integrador
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblUser;
        private TextBox txtUser;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblUser = new Label();
            txtUser = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();

            SuspendLayout();
            // lblUser
            lblUser.AutoSize = true;
            lblUser.Location = new Point(24, 20);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(70, 20);
            lblUser.Text = "Usuario:";
            // txtUser
            txtUser.Location = new Point(24, 44);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(240, 27);
            // lblPassword
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(24, 82);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 20);
            lblPassword.Text = "Contraseña:";
            // txtPassword
            txtPassword.Location = new Point(24, 106);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(240, 27);
            txtPassword.UseSystemPasswordChar = true;
            // btnLogin
            btnLogin.Location = new Point(24, 150);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(110, 32);
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // btnCancel
            btnCancel.Location = new Point(154, 150);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 32);
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;

            // FormLogin
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 204);
            Controls.Add(lblUser);
            Controls.Add(txtUser);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acceso";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
}
