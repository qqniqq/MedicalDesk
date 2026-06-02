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

namespace MedicalDeskForms.Forms.Requests
{
    public partial class RequestListForm : Form
    {
        public RequestListForm()
        {
            InitializeComponent();

            LoadRequests();

        }
        private void LoadRequests()
        {
            RequestRepository repository =
                new RequestRepository();

            dgvRequests.DataSource =
                repository.GetGridData();
            dgvRequests.Columns[
    "RequestNumber"].HeaderText =
    "Номер";

            dgvRequests.Columns[
                "Description"].HeaderText =
                "Описание";

            dgvRequests.Columns[
                "Status"].HeaderText =
                "Статус";

            dgvRequests.Columns[
                "CreatedAt"].HeaderText =
                "Дата создания";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateRequestForm form =
    new CreateRequestForm();

            form.ShowDialog();

            LoadRequests();
        }
    }
}
