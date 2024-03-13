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
    public partial class AuthForm : Form
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=RepairDB;User Id=postgres;Password=qwerty123");

        public AuthForm()
        {
            InitializeComponent();

        }
           
    private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(loginBox.Text) && !string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                connection.Open();
                var command = new NpgsqlCommand($@"
                SELECT r.role_title
                FROM users u
                JOIN roles r ON u.role_id = r.id
                WHERE u.login = @login AND u.password = @password
                ", connection);

                command.Parameters.AddWithValue("@login", loginBox.Text);
                command.Parameters.AddWithValue("@password", passwordBox.Text); var role = command.ExecuteScalar();
                connection.Close();
                if (role != null)
                {
                    string roleString = role.ToString();
                    if (roleString == "Администратор")
                    {
                        RequestsList requestsList = new RequestsList();
                        requestsList.ShowDialog();
                    }
                    else if (roleString == "Менеджер")
                    {
                        ChooseForm chooseForm = new ChooseForm();
                        chooseForm.Closed += (s, args) => Close();
                        chooseForm.Show();
                        Hide();
                    }
                    else if (roleString == "Клиент")
                    {
                        RequestForm requestForm = new RequestForm();
                        requestForm.Closed += (s, args) => Close();
                        requestForm.Show();
                        Hide();
                    }
                    else if (roleString == "Сотрудник")
                    {
                         connection.Open();
                         ChooseName chooseName = new ChooseName();
                         chooseName.Closed += (s, args) => Close();
                         chooseName.Show();
                         Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неизвестная роль пользователя: " + roleString, "Ошибка");
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка");
            }
        }
    }
}
