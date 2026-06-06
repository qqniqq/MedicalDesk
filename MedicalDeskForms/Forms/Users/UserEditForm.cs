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
using MedicalDeskLib.Validation;

namespace MedicalDeskForms.Forms.Users
{
    public partial class UserEditForm : Form
    {
        private int _userId;
        public UserEditForm(int userId)
        {
            InitializeComponent();
            cmbRole.DataSource =
                Enum.GetValues(
                    typeof(UserRole));

            _userId = userId;

            LoadUser();
        }
        private void LoadUser()
        {
            UserRepository repository =
                new UserRepository();

            User user =
                repository.GetById(
                    _userId);

            if (user == null)
            {
                MessageBox.Show(
                    "Пользователь не найден");

                Close();

                return;
            }

            txtFullName.Text =
                user.FullName;

            txtPhone.Text =
                user.Phone;

            txtLogin.Text =
                user.Login;

            cmbRole.SelectedItem =
                (UserRole)user.Role;

            chkActive.Checked =
                user.IsActive;
        }
        public UserEditForm()
        {
            InitializeComponent();
            cmbRole.DataSource =
    Enum.GetValues(typeof(UserRole));

            chkActive.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string validationResult =
    UserValidator.Validate(
        txtFullName.Text,
        txtLogin.Text,
        txtPassword.Text);

            if (validationResult != null)
            {
                MessageBox.Show(validationResult);

                return;
            }

            User user =
                new User();

            user.Id =
                _userId;

            user.FullName =
                txtFullName.Text.Trim();

            user.Phone =
                txtPhone.Text.Trim();

            user.Login =
                txtLogin.Text.Trim();

            user.Role =
                (int)cmbRole.SelectedItem;

            user.IsActive =
                chkActive.Checked;

            UserRepository repository =
                new UserRepository();

            repository.Update(user);

            if (!string.IsNullOrWhiteSpace(
                txtPassword.Text))
            {
                repository.ChangePassword(
                    _userId,
                    PasswordHasher.Hash(
                        txtPassword.Text));
            }

            MessageBox.Show(
                "Изменения сохранены");

            Close();
        }
    }
}
