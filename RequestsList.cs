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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RepairRequests
{
    public partial class RequestsList : Form
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=RepairDB;User Id=postgres;Password=qwerty123");
        private List<Request> requests;
        public RequestsList()
        {
            InitializeComponent();
            LoadRequestsList();
        }
        public void LoadRequestsList()
        {
            requestsListView.Rows.Clear();
            requests = GetAllRequests();
            requestsListView.Columns[9].DefaultCellStyle.Format = "dd.MM.yyyy";
            foreach (var request in requests)
            {
                requestsListView.Rows.Add(
                    request.Id,
                    request.Description,
                    request.Requester_Full_Name,
                    request.Requester_Email,
                    request.Repaierer_Full_Name,
                    request.Equipment_type_title,
                    request.Severity_title,
                    request.Priority_title,
                    request.Status_title,
                    request.Request_Date
                );
            }
        }
        public List<Request> GetAllRequests()
        {
            var result = new List<Request>();
            try
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT request.id, request.description, request.requester_full_name, request.requester_email, " +
                    "employer.full_name, equipment_type.type_title, severity.severity_title, " +
                    "priority.priority_title, status.status_title, request.request_date FROM request " +
                    "INNER JOIN equipment_type ON request.equipment_type_id = equipment_type.id " +
                    "INNER JOIN severity ON request.severity_id = severity.id " +
                    "INNER JOIN status ON request.status_id = status.id " +
                    "LEFT JOIN priority ON request.priority_id = priority.id " +
                    "LEFT JOIN employer ON request.repairer_id = employer.id", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var request = new Request();
                        request.Id = reader.GetInt32(0);
                        request.Description = reader.GetString(1);
                        request.Requester_Full_Name = reader.GetString(2);
                        request.Requester_Email = reader.GetString(3);
                        request.Repaierer_Full_Name = reader.IsDBNull(4) ? "Не назначен" : reader.GetString(4);
                        request.Equipment_type_title = reader.GetString(5);
                        request.Severity_title = reader.GetString(6);
                        request.Priority_title = reader.IsDBNull(7) ? "Не назначен" : reader.GetString(7);
                        request.Status_title = reader.GetString(8);
                        request.Request_Date = reader.GetDateTime(9);
                        result.Add(request);
                    }
                }           
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return result;
        }

        private void requestsListView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedId = Convert.ToInt32(requestsListView.Rows[e.RowIndex].Cells[0].Value);

                Request selectedRequest = GetAllRequests().FirstOrDefault(r => r.Id == selectedId);

                if (selectedRequest != null)
                {
                    EditRequestForm editForm = new EditRequestForm(selectedRequest);
                    editForm.ShowDialog();

                    LoadRequestsList(); 
                }
                else
                {
                    MessageBox.Show("Не удалось найти запрос с указанным идентификатором.");
                }
            }
        }
        
    }
}
