using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CatalogoFaltantesApp
{
using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace CatalogoFaltantesApp
{
    public partial class FormLogin : Form
    {
        private Label lblUser;
        private Label lblPassword;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Button btnCancel;

        public FormLogin()
        {
            InitializeComponent();
            BuildControls();
        }

        private void BuildControls()
        {
            // Si el diseñador ya tuviera controles, evitar duplicados
            if (Controls.ContainsKey("txtUser"))
                return;

            lblUser = new Label { Text = "Usuario:", Location = new Point(16, 16), AutoSize = true, Name = "lblUser" };
            lblPassword = new Label { Text = "Contraseña:", Location = new Point(16, 54), AutoSize = true, Name = "lblPassword" };

            txtUser = new TextBox { Location = new Point(100, 13), Size = new Size(220, 23), Name = "txtUser", TabIndex = 0 };
            txtPassword = new TextBox { Location = new Point(100, 51), Size = new Size(220, 23), Name = "txtPassword", UseSystemPasswordChar = true, TabIndex = 1 };

            btnLogin = new Button { Text = "Entrar", Location = new Point(100, 95), Size = new Size(75, 27), Name = "btnLogin", TabIndex = 2 };
            btnRegister = new Button { Text = "Registrarse", Location = new Point(181, 95), Size = new Size(95, 27), Name = "btnRegister", TabIndex = 3 };
            btnCancel = new Button { Text = "Salir", Location = new Point(282, 95), Size = new Size(58, 27), Name = "btnCancel", TabIndex = 4 };

            btnLogin.Click += BtnLogin_Click;
            btnRegister.Click += BtnRegister_Click;
            btnCancel.Click += BtnCancel_Click;
            Load += FormLogin_Load;

            AcceptButton = btnLogin;
            CancelButton = btnCancel;

            Controls.AddRange(new Control[] { lblUser, lblPassword, txtUser, txtPassword, btnLogin, btnRegister, btnCancel });

            ClientSize = new Size(360, 140);
            FormBorderStyle = FormBorderStyle.FixedDialog;
    }
}
