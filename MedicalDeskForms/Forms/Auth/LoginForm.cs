using MedicalDeskForms.Forms.Main;
using MedicalDeskLib.Models;
using MedicalDeskLib.Security;
using MedicalDeskLib.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalDeskForms.Forms.Auth
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AuthService authService =
      new AuthService();

            User user =
                authService.Login(
                    txtLogin.Text.Trim(),
                    txtPassword.Text);

            if (user == null)
            {
                lblError.Text =
                    "Неверный логин или пароль";

                lblError.Visible = true;

                return;
            }

            SessionManager.CurrentUser = user;

            MainForm mainForm =
                new MainForm();

            mainForm.Show();

            this.Hide();
        }
    }
}
