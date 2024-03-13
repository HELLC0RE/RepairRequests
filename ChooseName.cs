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
    public partial class ChooseName : Form
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=RepairDB;User Id=postgres;Password=qwerty123");
        public ChooseName()
        {
            InitializeComponent();
            FillEmployerComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedFullName = comboBox1.SelectedItem.ToString();
                RepairerForm repairerForm = new RepairerForm(selectedFullName);
                repairerForm.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Выберите сотрудника из списка", "Ошибка");
            }
        }
        private void FillEmployerComboBox()
        {
            try
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT full_name FROM Employer WHERE role_id = 4", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string fullName = reader.GetString(0);
                        comboBox1.Items.Add(fullName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных из базы данных: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
