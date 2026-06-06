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
            
            cmbRequestType.Items.Add(
    "Компьютер");

            cmbRequestType.Items.Add(
                "Принтер");

            cmbRequestType.Items.Add(
                "МФУ");

            cmbRequestType.Items.Add(
                "Ноутбук");

            cmbRequestType.Items.Add(
                "Интернет");

            cmbRequestType.Items.Add(
                "Сеть");

            cmbRequestType.Items.Add(
                "Программное обеспечение");

            cmbRequestType.Items.Add(
                "Телефон");

            cmbRequestType.Items.Add(
                "Другое");
            //АВТОЗАПОЛНЕНИЕ
            if (SessionManager.CurrentUser.Role == 1)
            {
                txtApplicantName.Text =
                    SessionManager.CurrentUser.FullName;

                txtApplicantPhone.Text =
                    SessionManager.CurrentUser.Phone;

                txtApplicantName.ReadOnly = true;
                txtApplicantPhone.ReadOnly = true;
            }
        }


        private void btnCreateRequest_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(
                txtDescription.Text))
            {
                MessageBox.Show(
                    "Введите описание проблемы");

                return;
            }

            if (string.IsNullOrWhiteSpace(
    txtRoom.Text))
            {
                MessageBox.Show(
                    "Введите кабинет");

                return;
            }

            if (string.IsNullOrWhiteSpace(
                txtApplicantName.Text))
            {
                MessageBox.Show(
                    "Введите заявителя");

                return;
            }

            if (string.IsNullOrWhiteSpace(
                txtApplicantPhone.Text))
            {
                MessageBox.Show(
                    "Введите телефон");

                return;
            }

            if (string.IsNullOrWhiteSpace(
                cmbRequestType.Text))
            {
                MessageBox.Show(
                    "Выберите тип обращения");

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

            request.Room =
    txtRoom.Text.Trim();

            request.ApplicantName =
                txtApplicantName.Text.Trim();

            request.ApplicantPhone =
                txtApplicantPhone.Text.Trim();

            request.RequestType =
                cmbRequestType.Text;

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


            request.TechnicianId =
                null;

            repository.Add(request);

            MessageBox.Show(
                "Заявка создана");

            Close();
        }
    }
}
