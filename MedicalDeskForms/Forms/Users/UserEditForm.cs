using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalDeskLib.Enums;
using MedicalDeskLib.Models;
using MedicalDeskLib.Repositories;
using MedicalDeskLib.Security;

namespace MedicalDeskForms.Forms.Users
{
    public partial class UserEditForm : Form
    {
        public UserEditForm()
        {
            InitializeComponent();
            cmbRole.DataSource =
    Enum.GetValues(typeof(UserRole));

            chkActive.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.FullName =
                txtFullName.Text.Trim();

            user.Login =
                txtLogin.Text.Trim();

            user.PasswordHash =
                PasswordHasher.Hash(
                    txtPassword.Text);

            user.Role =
                (int)cmbRole.SelectedItem;

            user.CreatedAt =
                DateTime.Now;

            user.IsActive =
                chkActive.Checked;

            UserRepository repository =
                new UserRepository();

            repository.Add(user);

            MessageBox.Show(
                "Пользователь создан");

            
        }
    }
}
