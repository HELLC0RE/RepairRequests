namespace RepairRequests
{
    partial class RequestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.createRequest = new System.Windows.Forms.Button();
            this.fullNameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.equipmentTypeBox = new System.Windows.Forms.ComboBox();
            this.severityBox = new System.Windows.Forms.ComboBox();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заполните следующую информацию для создания заявки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ф.И.О заказчика:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Почта для связи:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тип оборудования";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Серьёзность проблемы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Описание проблемы";
            // 
            // createRequest
            // 
            this.createRequest.Location = new System.Drawing.Point(104, 397);
            this.createRequest.Name = "createRequest";
            this.createRequest.Size = new System.Drawing.Size(113, 30);
            this.createRequest.TabIndex = 6;
            this.createRequest.Text = "Создать заявку";
            this.createRequest.UseVisualStyleBackColor = true;
            this.createRequest.Click += new System.EventHandler(this.createRequest_Click);
            // 
            // fullNameText
            // 
            this.fullNameText.Location = new System.Drawing.Point(15, 55);
            this.fullNameText.Multiline = true;
            this.fullNameText.Name = "fullNameText";
            this.fullNameText.Size = new System.Drawing.Size(303, 26);
            this.fullNameText.TabIndex = 7;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(15, 116);
            this.emailText.Multiline = true;
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(303, 26);
            this.emailText.TabIndex = 8;
            // 
            // equipmentTypeBox
            // 
            this.equipmentTypeBox.FormattingEnabled = true;
            this.equipmentTypeBox.Location = new System.Drawing.Point(15, 203);
            this.equipmentTypeBox.Name = "equipmentTypeBox";
            this.equipmentTypeBox.Size = new System.Drawing.Size(121, 21);
            this.equipmentTypeBox.TabIndex = 9;
            // 
            // severityBox
            // 
            this.severityBox.FormattingEnabled = true;
            this.severityBox.Location = new System.Drawing.Point(197, 203);
            this.severityBox.Name = "severityBox";
            this.severityBox.Size = new System.Drawing.Size(121, 21);
            this.severityBox.TabIndex = 10;
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(14, 268);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(304, 110);
            this.descriptionText.TabIndex = 11;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(247, 401);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 37);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Вернуться назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.severityBox);
            this.Controls.Add(this.equipmentTypeBox);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.fullNameText);
            this.Controls.Add(this.createRequest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RequestForm";
            this.Text = "RequestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button createRequest;
        private System.Windows.Forms.TextBox fullNameText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.ComboBox equipmentTypeBox;
        private System.Windows.Forms.ComboBox severityBox;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.Button backButton;
    }
}