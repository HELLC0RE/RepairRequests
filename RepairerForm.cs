using Npgsql;
using RepairRequests.DescriptionClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairRequests
{
    public partial class RepairerForm : Form
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=RepairDB;User Id=postgres;Password=qwerty123");
        private List<Request> requests;
        private string fullName;
        public RepairerForm(string fullName)
        {
            InitializeComponent();
            this.fullName = fullName;
            LoadRequestsList();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string partName = txtPartName.Text;
            int quantity = Convert.ToInt32(txtQuantity.Text);
            decimal cost = Convert.ToDecimal(txtCost.Text);

            if (string.IsNullOrWhiteSpace(partName) || quantity <= 0 || cost <= 0)
            {
                MessageBox.Show("Пожалуйста, заполните все поля корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int requestId = -1; 

            if (requestsList.SelectedRows.Count > 0)
            {
                requestId = Convert.ToInt32(requestsList.SelectedRows[0].Cells[0].Value);
            }

            try
            {
                connection.Open();

                using (var command = new NpgsqlCommand("INSERT INTO sparepartrequest (request_id, part_name, quantity, cost) VALUES (@requestId, @partName, @quantity, @cost)", connection))
                {
                    command.Parameters.AddWithValue("@requestId", requestId);
                    command.Parameters.AddWithValue("@partName", partName);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@cost", cost);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Информация о запчасти успешно добавлена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении информации о запчасти: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadRequestsList()
        {
            try
            {
                connection.Open();
                string query = "SELECT request.id, request.description, request.requester_full_name, request.requester_email, " +
                    "employer.full_name, equipment_type.type_title, severity.severity_title, " +
                    "priority.priority_title, status.status_title, request.request_date FROM request " +
                    "INNER JOIN equipment_type ON request.equipment_type_id = equipment_type.id " +
                    "INNER JOIN severity ON request.severity_id = severity.id " +
                    "INNER JOIN status ON request.status_id = status.id " +
                    "LEFT JOIN priority ON request.priority_id = priority.id " +
                    "LEFT JOIN employer ON request.repairer_id = employer.id WHERE employer.full_name = @fullName " +
                    "AND (status.status_title = 'Новая' OR status.status_title = 'В обработке')";

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@fullName", fullName);

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                requestsList.DataSource = dataSet.Tables[0]; 

                requestsList.Columns[9].DefaultCellStyle.Format = "dd.MM.yyyy";

                requestsList.Columns[0].HeaderText = "ID";
                requestsList.Columns[1].HeaderText = "Описание";
                requestsList.Columns[2].HeaderText = "Имя заявителя";
                requestsList.Columns[3].HeaderText = "Email заявителя";
                requestsList.Columns[4].HeaderText = "Исполнитель";
                requestsList.Columns[5].HeaderText = "Тип оборудования";
                requestsList.Columns[6].HeaderText = "Серьёзность поломки";
                requestsList.Columns[7].HeaderText = "Приоритет";
                requestsList.Columns[8].HeaderText = "Статус";
                requestsList.Columns[9].HeaderText = "Дата запроса";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (requestsList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите заявку для создания отчёта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int requestId = Convert.ToInt32(requestsList.SelectedRows[0].Cells["ID"].Value);
            int repairerId = GetRepairerIdByFullName(fullName); // Получение ID сотрудника по его имени

            using (ReportForm reportForm = new ReportForm(requestId, repairerId))
            {
                if (reportForm.ShowDialog() == DialogResult.OK)
                {
                    UpdateRequestStatusToCompleted(requestId);
                    LoadRequestsList();
                }
            }
        }
        private void UpdateRequestStatusToCompleted(int requestId)
        {
            try
            {
                connection.Open();
                using (var command = new NpgsqlCommand("UPDATE request SET status_id = @completedStatusId WHERE id = @requestId", connection))
                {
                    command.Parameters.AddWithValue("@completedStatusId", 3);
                    command.Parameters.AddWithValue("@requestId", requestId);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении статуса заявки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        private int GetRepairerIdByFullName(string fullName)
        {
            int repairerId = -1; // Значение по умолчанию, если не удастся найти сотрудника
            try
            {
                using (var command = new NpgsqlCommand("SELECT id FROM employer WHERE full_name = @fullName", connection))
                {
                    command.Parameters.AddWithValue("@fullName", fullName);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        repairerId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении ID сотрудника: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return repairerId;
        }
    }
}
