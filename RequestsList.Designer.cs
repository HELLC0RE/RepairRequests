namespace RepairRequests
{
    partial class RequestsList
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
            this.requestsListView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requester_Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requester_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repairer_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipment_Type_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Severity_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Request_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.requestsListView)).BeginInit();
            this.SuspendLayout();
            // 
            // requestsListView
            // 
            this.requestsListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestsListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Description,
            this.Requester_Full_Name,
            this.Requester_Email,
            this.Repairer_Id,
            this.Equipment_Type_Id,
            this.Severity_Id,
            this.Priority_Id,
            this.Status_Id,
            this.Request_Date});
            this.requestsListView.Location = new System.Drawing.Point(12, 24);
            this.requestsListView.Name = "requestsListView";
            this.requestsListView.Size = new System.Drawing.Size(776, 414);
            this.requestsListView.TabIndex = 0;
            this.requestsListView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requestsListView_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Идентификатор";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Description
            // 
            this.Description.HeaderText = "Описание";
            this.Description.Name = "Description";
            // 
            // Requester_Full_Name
            // 
            this.Requester_Full_Name.HeaderText = "Ф.И.О. Заявителя";
            this.Requester_Full_Name.Name = "Requester_Full_Name";
            // 
            // Requester_Email
            // 
            this.Requester_Email.HeaderText = "Почта заявителя";
            this.Requester_Email.Name = "Requester_Email";
            // 
            // Repairer_Id
            // 
            this.Repairer_Id.HeaderText = "Ф.И.О. Исполнителя";
            this.Repairer_Id.Name = "Repairer_Id";
            this.Repairer_Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Equipment_Type_Id
            // 
            this.Equipment_Type_Id.HeaderText = "Тип оборудования";
            this.Equipment_Type_Id.Name = "Equipment_Type_Id";
            // 
            // Severity_Id
            // 
            this.Severity_Id.HeaderText = "Серьёзность проблемы";
            this.Severity_Id.Name = "Severity_Id";
            // 
            // Priority_Id
            // 
            this.Priority_Id.HeaderText = "Приоритет заявки";
            this.Priority_Id.Name = "Priority_Id";
            this.Priority_Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Status_Id
            // 
            this.Status_Id.HeaderText = "Статус заявки";
            this.Status_Id.Name = "Status_Id";
            // 
            // Request_Date
            // 
            this.Request_Date.HeaderText = "Дата подачи заявки";
            this.Request_Date.Name = "Request_Date";
            // 
            // RequestsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.requestsListView);
            this.Name = "RequestsList";
            this.Text = "RequestsList";
            ((System.ComponentModel.ISupportInitialize)(this.requestsListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView requestsListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requester_Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requester_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repairer_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipment_Type_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Severity_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Request_Date;
    }
}