using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
            textBoxPass.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "usersDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.usersDataSet.users);

        }

        private void Btn_Log_Click(object sender, EventArgs e)
        {
            SqlConnection MaksimovConnectionString = new SqlConnection(@"Data Source=DESKTOP-MGA54G9\SQLEXPRESS; Initial Catalog = maksimov mebeli; Integrated Security=True");
            string query = "Select * FROM users WHERE login='" + comboBoxLogin.Text + "'and password='" + textBoxPass.Text + "'";
            MaksimovConnectionString.Open(); // соединение с базой данных sql

            SqlCommand cmd = new SqlCommand(query, MaksimovConnectionString);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    object Login = rdr.GetValue(0); //логин
                    object Password = rdr.GetValue(1); //пароль

                    string login = Login.ToString();
                    string password = Password.ToString();
                    if (login == "admin")
                    {
                        FormAdmin frm2 = new FormAdmin();
                        frm2.Show();
                        this.Hide(); // открыть форму админа
                    }
                    else if (login == "user ")
                    { 
                        FormUser frm3 = new FormUser();
                        frm3.Show();
                        this.Hide(); // открыть форму пользователя
                    }
                }
            }
            else
            {
                MessageBox.Show("Не правильный пароль", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormUser frm3 = new FormUser();
            frm3.Show();
            this.Hide();
        }
    }
}
