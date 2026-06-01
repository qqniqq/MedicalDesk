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
using MedicalDeskForms.Forms.Equipment;

namespace MedicalDeskForms.Forms.Equipment
{
    public partial class EquipmentListForm : Form
    {
        public EquipmentListForm()
        {
            InitializeComponent();
            LoadEquipment();
        }
        private void LoadEquipment()
        {
            EquipmentRepository repository =
                new EquipmentRepository();

            dgvEquipment.DataSource =
                repository.GetAll();

        }

        private void btnRefreshEquipment_Click(object sender, EventArgs e)
        {
            LoadEquipment();
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            EquipmentEditForm form =
                   new EquipmentEditForm();

            form.ShowDialog();

            LoadEquipment();
        }
    }

}
