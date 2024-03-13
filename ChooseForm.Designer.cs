namespace RepairRequests
{
    partial class ChooseForm
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
            this.createRequest = new System.Windows.Forms.Button();
            this.openRequestList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createRequest
            // 
            this.createRequest.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createRequest.Location = new System.Drawing.Point(12, 86);
            this.createRequest.Name = "createRequest";
            this.createRequest.Size = new System.Drawing.Size(217, 34);
            this.createRequest.TabIndex = 0;
            this.createRequest.Text = "Создать заявку";
            this.createRequest.UseVisualStyleBackColor = true;
            this.createRequest.Click += new System.EventHandler(this.createRequest_Click);
            // 
            // openRequestList
            // 
            this.openRequestList.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openRequestList.Location = new System.Drawing.Point(12, 12);
            this.openRequestList.Name = "openRequestList";
            this.openRequestList.Size = new System.Drawing.Size(217, 38);
            this.openRequestList.TabIndex = 1;
            this.openRequestList.Text = "Открыть список заявок";
            this.openRequestList.UseVisualStyleBackColor = true;
            this.openRequestList.Click += new System.EventHandler(this.openRequestList_Click);
            // 
            // ChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 136);
            this.Controls.Add(this.openRequestList);
            this.Controls.Add(this.createRequest);
            this.Name = "ChooseForm";
            this.Text = "ChooseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createRequest;
        private System.Windows.Forms.Button openRequestList;
    }
}