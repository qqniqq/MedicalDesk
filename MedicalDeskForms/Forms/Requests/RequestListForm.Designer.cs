namespace MedicalDeskForms.Forms.Requests
{
    partial class RequestListForm
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
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRequests
            // 
            this.dgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvRequests.Location = new System.Drawing.Point(729, 0);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.ReadOnly = true;
            this.dgvRequests.RowHeadersWidth = 51;
            this.dgvRequests.RowTemplate.Height = 24;
            this.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequests.Size = new System.Drawing.Size(860, 894);
            this.dgvRequests.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.Location = new System.Drawing.Point(12, 602);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(214, 61);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Создать заявку";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.Location = new System.Drawing.Point(12, 519);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(214, 61);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // RequestListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 894);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvRequests);
            this.Name = "RequestListForm";
            this.Text = "RequestListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRefresh;
    }
}