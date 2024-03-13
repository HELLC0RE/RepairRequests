using Npgsql;
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
    public partial class RequestForm : Form
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=RepairDB;User Id=postgres;Password=qwerty123");

        public RequestForm()
        {
            InitializeComponent();
            FillComboBoxes();
        }
        private void FillComboBoxes()
        {
            connection.Open();

            string equipmentTypeQuery = "SELECT type_title FROM equipment_type";
            string severityQuery = "SELECT severity_title FROM severity";

            NpgsqlCommand equipmentTypeCommand = new NpgsqlCommand(equipmentTypeQuery, connection);
            NpgsqlCommand severityCommand = new NpgsqlCommand(severityQuery, connection);

            NpgsqlDataReader equipmentTypeReader = equipmentTypeCommand.ExecuteReader();
            while (equipmentTypeReader.Read())
            {
                equipmentTypeBox.Items.Add(equipmentTypeReader.GetString(0));
            }
            equipmentTypeReader.Close();

            NpgsqlDataReader severityReader = severityCommand.ExecuteReader();
            while (severityReader.Read())
            {
                severityBox.Items.Add(severityReader.GetString(0));
            }
            severityReader.Close();

            connection.Close();
        }
        private void createRequest_Click(object sender, EventArgs e)
        {
            connection.Open();
            var command = new NpgsqlCommand(@"INSERT INTO request (description, requester_full_name, requester_email, 
            equipment_type_id, severity_id, status_id, request_date) SELECT @description, @requesterFullName, @requesterEmail, 
            (SELECT id FROM equipment_type WHERE type_title = @equipmentType), 
            (SELECT id FROM severity WHERE severity_title = @severity), 
            @statusId, @requestDate", connection);

            command.Parameters.AddWithValue("@description", descriptionText.Text);
            command.Parameters.AddWithValue("@requesterFullName", fullNameText.Text);
            command.Parameters.AddWithValue("@requesterEmail", emailText.Text);
            command.Parameters.AddWithValue("@equipmentType", equipmentTypeBox.SelectedItem);
            command.Parameters.AddWithValue("@severity", severityBox.SelectedItem);
            command.Parameters.AddWithValue("@statusId", 1);
            command.Parameters.AddWithValue("@requestDate", DateTime.Now);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Заявка успешно подана!");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
