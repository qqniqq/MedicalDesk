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
                repository.GetAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }
    }
}
