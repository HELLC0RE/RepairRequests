using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairRequests
{
    public partial class ReportForm : Form
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=RepairDB;User Id=postgres;Password=qwerty123");
        private int requestId;
        private int repairerId;
        public ReportForm(int requestId, int repairerId)
        {
            InitializeComponent();
            this.requestId = requestId;
            this.repairerId = repairerId;
        }

        private void createReport_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(workText.Text) ||
                string.IsNullOrWhiteSpace(resourcesText.Text) ||
                string.IsNullOrWhiteSpace(caseText.Text) ||
                string.IsNullOrWhiteSpace(infoText.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля перед созданием отчета.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string workDescription = workText.Text;
            string resourcesUsed = resourcesText.Text;
            string faultCase = caseText.Text;
            string additionalInfo = infoText.Text;
            DateTime completionDate = DateTime.Now.Date;

            try
            {

                connection.Open();


                using (var command = new NpgsqlCommand("INSERT INTO repairreport (request_id, repairer_id, completion_date, work_description, resources_used, fault_cause, additional_info) " +
                                                       "VALUES (@requestId, @repairerId, @completionDate, @workDescription, @resourcesUsed, @faultCause, @additionalInfo)", connection))
                {

                    command.Parameters.AddWithValue("@requestId", requestId);
                    command.Parameters.AddWithValue("@repairerId", repairerId);
                    command.Parameters.AddWithValue("@completionDate", completionDate);
                    command.Parameters.AddWithValue("@workDescription", workDescription);
                    command.Parameters.AddWithValue("@resourcesUsed", resourcesUsed);
                    command.Parameters.AddWithValue("@faultCause", faultCase);
                    command.Parameters.AddWithValue("@additionalInfo", additionalInfo);


                    command.ExecuteNonQuery();
                }


                MessageBox.Show("Отчет успешно создан и сохранен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);


                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка при создании отчета: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

    }
}
