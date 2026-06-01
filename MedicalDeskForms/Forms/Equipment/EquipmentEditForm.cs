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
using MedicalDeskLib.Validation;


namespace MedicalDeskForms.Forms.Equipment
{
    public partial class EquipmentEditForm : Form
    {
        public EquipmentEditForm()
        {
            InitializeComponent();

            cmbStatus.DataSource =
      Enum.GetValues(
          typeof(EquipmentStatus));


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string validationResult =
                EquipmentValidator.Validate(
                    txtName.Text,
                    txtModel.Text,
                    txtInventoryNumber.Text,
                    txtLocation.Text);

            if (validationResult != null)
            {
                MessageBox.Show(validationResult);

                return;
            }
            MedicalDeskLib.Models.Equipment equipment =
    new MedicalDeskLib.Models.Equipment();

            equipment.Name =
                txtName.Text.Trim();

            equipment.Model =
                txtModel.Text.Trim();

            equipment.InventoryNumber =
                txtInventoryNumber.Text.Trim();

            equipment.Location =
                txtLocation.Text.Trim();

            equipment.Status =
                (int)cmbStatus.SelectedItem;

            equipment.CreatedAt =
                DateTime.Now;

            EquipmentRepository repository =
                new EquipmentRepository();

            repository.Add(equipment);

            MessageBox.Show(
                "Оборудование добавлено");

            switch (cmbStatus.SelectedIndex)
            {
                case 0:
                    equipment.Status = 1;
                    break;

                case 1:
                    equipment.Status = 2;
                    break;

                case 2:
                    equipment.Status = 3;
                    break;
            }
            Close();
        }
    }
}
