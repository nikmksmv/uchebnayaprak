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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maksimov_mebeliDataSet.components". При необходимости она может быть перемещена или удалена.
            this.componentsTableAdapter.Fill(this.maksimov_mebeliDataSet.components);

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxDescription.Text != "" && textBoxQuantity.Text != "" && textBoxPrice.Text != "")
            {
                string name = textBoxName.Text.Trim(); // название мебели
                string description = textBoxDescription.Text.Trim(); //описание мебели
                string price = textBoxPrice.Text.Trim(); //цена мебели
                string quantity = textBoxQuantity.Text.Trim(); // количество
                string arrival_date = dateTimePicker1.Value.ToString(); //дата поступление
                string manufature_date = dateTimePicker2.Value.ToString(); // дата мануфактуры
                string component_id1 = textBoxID1.Text.Trim(); //вид комплектации
                string component_id2 = textBoxID2.Text.Trim();
                string component_id3 = textBoxID3.Text.Trim();

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MGA54G9\SQLEXPRESS; Initial Catalog = maksimov mebeli; Integrated Security=True");
                string inserquery = "INSERT INTO furniture (name, description, price, quantity, arrival_date, manufacture_date, component_id1, component_id2, component_id3) VALUES ('" + name + "','" + description + "','" + quantity + "','" + price + "','" + arrival_date + "','" + manufature_date + "','" + component_id1 + "','" + component_id2 + "','" + component_id3 + "')";
                SqlCommand cmd2 = new SqlCommand(inserquery, con);
                con.Open();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Мебель успешна добавлена!");
                con.Close();
            }

        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            FormAdmin frm2 = new FormAdmin();
            frm2.Show();
            this.Hide();
        }
    }
}
