using MedicalDeskForms.Forms.Equipment;
using MedicalDeskForms.Forms.Requests;
using MedicalDeskForms.Forms.Users;
using MedicalDeskLib.Enums;
using MedicalDeskLib.Repositories;
using MedicalDeskLib.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MedicalDeskForms.Forms.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            lblCurrentUser.Text =
                SessionManager.CurrentUser.FullName;

            ConfigureAccess();
        }

        private void ConfigureAccess()
        {
            UserRole role =
                (UserRole)SessionManager
                .CurrentUser
                .Role;

            switch (role)
            {
                case UserRole.Administrator:

                    btnUsers.Visible = true;
                    btnReports.Visible = true;
                    btnEquipment.Visible = true;
                    btnSettings.Visible = true;

                    break;

                case UserRole.Technician:

                    btnUsers.Visible = false;
                    btnSettings.Visible = false;

                    break;

                case UserRole.User:

                    btnUsers.Visible = false;
                    btnEquipment.Visible = false;
                    btnReports.Visible = false;
                    btnSettings.Visible = false;

                    break;
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UserListForm form =
    new UserListForm();

            form.ShowDialog();
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            EquipmentListForm form =
                new EquipmentListForm();

            form.ShowDialog();
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            RequestListForm form =
    new RequestListForm();

            form.ShowDialog();
        }
    }

}
