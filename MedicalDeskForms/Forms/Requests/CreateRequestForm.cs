using MedicalDeskLib.Repositories;
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
using MedicalDeskLib.Security;
using MedicalDeskLib.Services;

namespace MedicalDeskForms.Forms.Requests
{
    public partial class CreateRequestForm : Form
    {
        public CreateRequestForm()
        {
            InitializeComponent();
            LoadEquipment();
        }
        private void LoadEquipment()
        {
            EquipmentRepository repository =
                new EquipmentRepository();

            cmbEquipment.DataSource =
                repository.GetAllSimple();

            cmbEquipment.DisplayMember =
                "Name";

            cmbEquipment.ValueMember =
                "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbEquipment.SelectedValue == null)
            {
                MessageBox.Show(
                    "Выберите оборудование");

                return;
            }

            if (string.IsNullOrWhiteSpace(
                txtDescription.Text))
            {
                MessageBox.Show(
                    "Введите описание проблемы");

                return;
            }

            RequestRepository repository =
                new RequestRepository();

            int nextId =
                repository.GetNextId();

            Request request =
                new Request();

            request.RequestNumber =
                RequestNumberGenerator
                .Generate(nextId);

            request.Description =
                txtDescription.Text.Trim();

            request.Status =
                (int)RequestStatus.New;

            request.CreatedAt =
                DateTime.Now;

            request.UserId =
                SessionManager
                .CurrentUser
                .Id;

            request.EquipmentId =
                Convert.ToInt32(
                    cmbEquipment.SelectedValue);

            request.TechnicianId =
                null;

            repository.Add(request);

            MessageBox.Show(
                "Заявка создана");

            Close();
        }
    }
}
