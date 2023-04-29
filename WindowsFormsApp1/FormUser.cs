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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maksimov_mebeliDataSet4.components". При необходимости она может быть перемещена или удалена.
            this.componentsTableAdapter.Fill(this.maksimov_mebeliDataSet4.components);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maksimov_mebeliDataSet3.furniture". При необходимости она может быть перемещена или удалена.
            this.furnitureTableAdapter.Fill(this.maksimov_mebeliDataSet3.furniture);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manufactureDataSet.manufacture". При необходимости она может быть перемещена или удалена.
            this.manufactureTableAdapter.Fill(this.manufactureDataSet.manufacture);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stockDataSet.stocks". При необходимости она может быть перемещена или удалена.
            this.stocksTableAdapter.Fill(this.stockDataSet.stocks);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                string component_id = comboBox2.SelectedIndex.ToString(); ; // id комплектующего
                string adress = textBox2.Text.Trim(); // адрес склада
                string quantity = textBox3.Text.Trim(); //количество комплектующих
                string arrival_date = dateTimePicker1.Value.ToString(); //дата поступления

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MGA54G9\SQLEXPRESS; Initial Catalog = maksimov mebeli; Integrated Security=True");
                string inserquery = "INSERT INTO stocks (component_id, adress, quantity, arrival_date) VALUES ('" + component_id + "','" + adress + "','" + quantity + "','" + arrival_date + "')";
                SqlCommand cmd2 = new SqlCommand(inserquery, con);
                con.Open();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Успешно прошло!");
                con.Close(); //код добавление информаци про склад
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row); //код для удаление
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            stocksTableAdapter.Update(stockDataSet);
            {
                MessageBox.Show("Изменения сохранены!"); //код для обновление
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = stockDataSet.stocks;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"adress LIKE '%{textBoxSearch.Text}%'"; //код для динамического кода
        }


        private void BtnForward_Click(object sender, EventArgs e)
        {
            FormAutorization frm1 = new FormAutorization();
            frm1.Show();
            this.Hide(); //код для кнопки "Назад"
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.Remove(row); //удаление
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manufactureTableAdapter.Update(manufactureDataSet);
            {
                MessageBox.Show("Изменения сохранены!"); //обновление
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = manufactureDataSet.manufacture;
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = $"id_furniture = '{textBox5.Text}'"; //динамический поиск
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {
                string id_furniture = comboBox1.SelectedIndex.ToString(); // мебел
                string quantity = textBox8.Text.Trim(); // количество
                string date_of_manufacture = dateTimePicker1.Value.ToString(); //дата изготовление

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MGA54G9\SQLEXPRESS; Initial Catalog = maksimov mebeli; Integrated Security=True");
                string inserquery = "INSERT INTO manufacture (id_furniture, quantity, date_of_manufacture) VALUES ('" + id_furniture + "','" + quantity + "','" + date_of_manufacture + "')";
                SqlCommand cmd2 = new SqlCommand(inserquery, con);
                con.Open();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Успешно прошло!");
                con.Close(); //добавление новых записей
            }
        }
    }
}
