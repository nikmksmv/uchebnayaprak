﻿using System;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "user.components". При необходимости она может быть перемещена или удалена.
            this.componentsTableAdapter.Fill(this.user.components);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormUserAdd frm4 = new FormUserAdd();
            frm4.Show();
            this.Hide();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            componentsTableAdapter.Update(user);
            {
                MessageBox.Show("Изменения сохранены!");
            }
        }

        private void BtnAZ_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-MGA54G9\SQLEXPRESS; Initial Catalog = maksimov mebeli; Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select * FROM components Order By name asc", con1);
            con1.Open();
            da.Fill(ds, "maksimov mebeli");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();
            con1.Dispose();
            ds.Dispose();
        }

        private void BtnZA_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-MGA54G9\SQLEXPRESS; Initial Catalog = maksimov mebeli; Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select * FROM components Order By name desc", con1);
            con1.Open();
            da.Fill(ds, "maksimov mebeli");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();
            con1.Dispose();
            ds.Dispose();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = user.components;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"name LIKE '%{textBoxSearch.Text}%'";
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.CurrentCell = null;
                dataGridView1.Rows[i].Visible = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox2.Text))
                    {
                        dataGridView1.Rows[i].Visible = true;
                        break;
                    }
                }

            }
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            FormAutorization frm1 = new FormAutorization();
            frm1.Show();
            this.Hide();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}