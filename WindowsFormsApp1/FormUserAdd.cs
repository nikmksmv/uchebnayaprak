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
    public partial class FormUserAdd : Form
    {
        public FormUserAdd()
        {
            InitializeComponent();
        }

        private void FormUserAdd_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxDescription.Text != "" && textBoxQuantity.Text != "" && textBoxQuantity.Text != "")
            {
                string name = textBoxName.Text.Trim(); // название комплектации
                string description = textBoxDescription.Text.Trim(); //описание 
                string quantity = textBoxQuantity.Text.Trim(); // количество
                string arrival_date = dateTimePicker1.Value.ToString(); //дата поступление
                string use_date = dateTimePicker2.Value.ToString(); // дата использование

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MGA54G9\SQLEXPRESS; Initial Catalog = maksimov mebeli; Integrated Security=True");
                string inserquery = "INSERT INTO components (name, description, quantity, arrival_date, use_date) VALUES ('" + name + "','" + description + "','" + quantity + "','" + arrival_date + "','" + use_date + "')";
                SqlCommand cmd2 = new SqlCommand(inserquery, con);
                con.Open();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Комплектация успешна добавлена!");
                con.Close();
            }
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            FormUser frm4 = new FormUser();
            frm4.Show();
            this.Hide();
        }
    }
}
