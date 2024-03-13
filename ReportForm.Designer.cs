namespace RepairRequests
{
    partial class ReportForm
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
            this.createReport = new System.Windows.Forms.Button();
            this.workText = new System.Windows.Forms.TextBox();
            this.resourcesText = new System.Windows.Forms.TextBox();
            this.caseText = new System.Windows.Forms.TextBox();
            this.infoText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createReport
            // 
            this.createReport.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createReport.Location = new System.Drawing.Point(81, 438);
            this.createReport.Name = "createReport";
            this.createReport.Size = new System.Drawing.Size(151, 32);
            this.createReport.TabIndex = 0;
            this.createReport.Text = "Создать отчёт";
            this.createReport.UseVisualStyleBackColor = true;
            this.createReport.Click += new System.EventHandler(this.createReport_Click);
            // 
            // workText
            // 
            this.workText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workText.Location = new System.Drawing.Point(33, 73);
            this.workText.Multiline = true;
            this.workText.Name = "workText";
            this.workText.Size = new System.Drawing.Size(259, 62);
            this.workText.TabIndex = 1;
            // 
            // resourcesText
            // 
            this.resourcesText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resourcesText.Location = new System.Drawing.Point(33, 166);
            this.resourcesText.Multiline = true;
            this.resourcesText.Name = "resourcesText";
            this.resourcesText.Size = new System.Drawing.Size(259, 62);
            this.resourcesText.TabIndex = 2;
            // 
            // caseText
            // 
            this.caseText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.caseText.Location = new System.Drawing.Point(33, 255);
            this.caseText.Multiline = true;
            this.caseText.Name = "caseText";
            this.caseText.Size = new System.Drawing.Size(259, 62);
            this.caseText.TabIndex = 3;
            // 
            // infoText
            // 
            this.infoText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoText.Location = new System.Drawing.Point(33, 344);
            this.infoText.Multiline = true;
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(259, 60);
            this.infoText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Создание отчёта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Описание работы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Причина неисправности";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(29, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Затраченные ресурсы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(29, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дополнительная информация";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 491);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.caseText);
            this.Controls.Add(this.resourcesText);
            this.Controls.Add(this.workText);
            this.Controls.Add(this.createReport);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createReport;
        private System.Windows.Forms.TextBox workText;
        private System.Windows.Forms.TextBox resourcesText;
        private System.Windows.Forms.TextBox caseText;
        private System.Windows.Forms.TextBox infoText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}