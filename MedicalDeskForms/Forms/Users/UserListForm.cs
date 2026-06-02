using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalDeskLib.Repositories;
using MedicalDeskLib.Security;

namespace MedicalDeskForms.Forms.Users
{
    public partial class UserListForm : Form
    {
        public UserListForm()
        {
            InitializeComponent();

            LoadUsers();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserEditForm form =
    new UserEditForm();

            form.ShowDialog();
        }
        private void LoadUsers()
        {
            UserRepository repository =
    new UserRepository();

            dgvUsers.DataSource =

            repository.GetGridData();
            
            dgvUsers.Columns["Id"].HeaderText =
    "ID";

            dgvUsers.Columns["FullName"].HeaderText =
                "ФИО";
            dgvUsers.Columns["Phone"].HeaderText =
                "Телефон";
            dgvUsers.Columns["Login"].HeaderText =
                "Логин";

            dgvUsers.Columns["Role"].HeaderText =
                "Роль";

            dgvUsers.Columns["IsActive"].HeaderText =
                "Активен";

            dgvUsers.Columns["CreatedAt"].HeaderText =
                "Дата создания";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnBlockUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
                return;

            int userId =
                Convert.ToInt32(
                    dgvUsers
                    .SelectedRows[0]
                    .Cells["Id"]
                    .Value);

            bool isActive =
                Convert.ToBoolean(
                    dgvUsers
                    .SelectedRows[0]
                    .Cells["IsActive"]
                    .Value);

            UserRepository repository =
                new UserRepository();

            repository.SetActive(
                userId,
                !isActive);

            LoadUsers();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
                return;

            int userId =
                Convert.ToInt32(
                    dgvUsers
                    .SelectedRows[0]
                    .Cells["Id"]
                    .Value);

            UserRepository repository =
                new UserRepository();

            repository.ResetPassword(
                userId,
                PasswordHasher.Hash("123456"));

            MessageBox.Show(
                "Пароль сброшен на 123456");
        }
    }
}
