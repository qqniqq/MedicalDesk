namespace MedicalDeskForms.Forms.Equipment
{
    partial class EquipmentListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEquipment = new System.Windows.Forms.DataGridView();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnRefreshEquipment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEquipment
            // 
            this.dgvEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipment.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvEquipment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipment.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvEquipment.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEquipment.Location = new System.Drawing.Point(366, 0);
            this.dgvEquipment.Name = "dgvEquipment";
            this.dgvEquipment.ReadOnly = true;
            this.dgvEquipment.RowHeadersWidth = 51;
            this.dgvEquipment.RowTemplate.Height = 24;
            this.dgvEquipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipment.Size = new System.Drawing.Size(1318, 533);
            this.dgvEquipment.TabIndex = 0;
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddEquipment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddEquipment.Location = new System.Drawing.Point(22, 12);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(150, 65);
            this.btnAddEquipment.TabIndex = 1;
            this.btnAddEquipment.Text = "Добавить";
            this.btnAddEquipment.UseVisualStyleBackColor = false;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // btnRefreshEquipment
            // 
            this.btnRefreshEquipment.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRefreshEquipment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefreshEquipment.Location = new System.Drawing.Point(22, 83);
            this.btnRefreshEquipment.Name = "btnRefreshEquipment";
            this.btnRefreshEquipment.Size = new System.Drawing.Size(150, 65);
            this.btnRefreshEquipment.TabIndex = 2;
            this.btnRefreshEquipment.Text = "Обновить";
            this.btnRefreshEquipment.UseVisualStyleBackColor = false;
            this.btnRefreshEquipment.Click += new System.EventHandler(this.btnRefreshEquipment_Click);
            // 
            // EquipmentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1684, 533);
            this.Controls.Add(this.btnRefreshEquipment);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.dgvEquipment);
            this.Name = "EquipmentListForm";
            this.Text = "EquipmentListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEquipment;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnRefreshEquipment;
    }
}