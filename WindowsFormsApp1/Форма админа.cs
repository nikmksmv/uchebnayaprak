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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maksimov_mebeliDataSet2.components". При необходимости она может быть перемещена или удалена.
            this.componentsTableAdapter3.Fill(this.maksimov_mebeliDataSet2.components);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maksimov_mebeliDataSet1.components". При необходимости она может быть перемещена или удалена.
            this.componentsTableAdapter2.Fill(this.maksimov_mebeliDataSet1.components);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "combobox1DataSet.components". При необходимости она может быть перемещена или удалена.
            this.componentsTableAdapter.Fill(this.combobox1DataSet.components);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "complectDataSet.components". При необходимости она может быть перемещена или удалена.
            this.componentsTableAdapter1.Fill(this.complectDataSet.components);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet1.furniture". При необходимости она может быть перемещена или удалена.
            this.furnitureTableAdapter1.Fill(this.mebelDataSet1.furniture);
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            FormAutorization frm1 = new FormAutorization();
            frm1.Show();
            this.Hide();//код для кнопки "назад"
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row); //код для удаление записей с DataGridView
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            furnitureTableAdapter1.Update(mebelDataSet1);
            {
                MessageBox.Show("Изменения сохранены!"); //код для обновление записей
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = mebelDataSet1.furniture;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"name LIKE '%{textBoxSearch.Text}%'"; //динамический поиск
        }

        private void BtnAZ_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-MGA54G9\SQLEXPRESS; Initial Catalog = maksimov mebeli; Integrated Security=True"); //соединение
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select * FROM furniture Order By name asc", con1);
            con1.Open();
            da.Fill(ds, "maksimov mebeli");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();
            con1.Dispose();
            ds.Dispose(); //сортировка
        }

        private void BtnZA_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-MGA54G9\SQLEXPRESS; Initial Catalog = maksimov mebeli; Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select * FROM furniture Order By name desc", con1);
            con1.Open();
            da.Fill(ds, "maksimov mebeli");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();
            con1.Dispose();
            ds.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                string name = textBox2.Text.Trim(); // название мебели
                string description = textBox3.Text.Trim(); //описание мебели
                string price = textBox4.Text.Trim(); //цена мебели
                string component_id1 = comboBox1.SelectedIndex.ToString(); //вид комплектации
                string component_id2 = comboBox2.SelectedIndex.ToString();
                string component_id3 = comboBox3.SelectedIndex.ToString();

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MGA54G9\SQLEXPRESS; Initial Catalog = maksimov mebeli; Integrated Security=True");
                string inserquery = "INSERT INTO furniture (name, description, price, component_id1, component_id2, component_id3) VALUES ('" + name + "','" + description + "','" + price + "','" + component_id1 + "','" + component_id2 + "','" + component_id3 + "')";
                SqlCommand cmd2 = new SqlCommand(inserquery, con);
                con.Open();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Мебель успешна добавлена!");
                con.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.Remove(row); //код для удаление записей с DataGridView2
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            componentsTableAdapter1.Update(complectDataSet);
            {
                MessageBox.Show("Изменения сохранены!"); //код для обновление записей
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = complectDataSet.components;
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = $"name LIKE '%{textBox1.Text}%'"; //динамический поиск
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            if (textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "")
            {
                string name = textBox8.Text.Trim(); // название комплектации
                string description = textBox9.Text.Trim(); //описание комплектации
                string quantity = textBox10.Text.Trim(); //количество

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MGA54G9\SQLEXPRESS; Initial Catalog = maksimov mebeli; Integrated Security=True");
                string inserquery = "INSERT INTO components (name, description, quantity) VALUES ('" + name + "','" + description + "','" + quantity + "')";
                SqlCommand cmd2 = new SqlCommand(inserquery, con);
                con.Open();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Комплектация успешна добавлена!");
                con.Close();
            }
        }
    }
}
