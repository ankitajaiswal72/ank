
using BloodBankManagementSystem.BLL;
using BloodBankManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace BloodBankManagementSystem.UI
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        private void label3_Click_1(object sender, EventArgs e)
        {
            u.FullName = textBox3.Text;
            u.Email = textBox4.Text;
            u.Password = textBox6.Text;
            u.Username = textBox5.Text;
            u.Contact = textBox7.Text;
            u.City = comboBox4.Text;
            u.AddedDate = DateTime.Now;

            bool success = dal.Insert(u);

            if (success == true)
            {
                MessageBox.Show("New User Added Successfully.");

                DataTable dt = dal.Select();
                dgvdetails.DataSource = dt;

                Clear();
            }
            else
            {
                MessageBox.Show("Failed To Add New User.");
            }
        }
        public void Clear()
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox4.Text = "";
            textBox2.Text = "";       

        }

        private void label5_Click(object sender, EventArgs e)
        {
            u.UserId = int.Parse(textBox2.Text);

            bool success = dal.Delete(u);

            if (success == true)
            {
                MessageBox.Show("User Deleted Successfully.");

                DataTable dt = dal.Select();
                dgvdetails.DataSource = dt;

                Clear();
            }
        }

       

        private void Users_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvdetails.DataSource = dt;
        }

       
        private void label4_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            u.UserId = int.Parse(textBox2.Text);
            u.FullName = textBox3.Text;
            u.Email = textBox4.Text;
            u.Password = textBox6.Text;
            u.Username = textBox5.Text;
            u.Contact = textBox7.Text;
            u.City = comboBox4.Text;
            u.AddedDate = DateTime.Now;

            bool success = dal.Update(u);

            if (success == true)
            {
                MessageBox.Show("User Updated Successfully.");

                DataTable dt = dal.Select();
                dgvdetails.DataSource = dt;

                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update user!");
            }
        }

       
        private void Users_Load_1(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String keywords = textBox1.Text;
            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvdetails.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvdetails.DataSource = dt;
            }
        }

       

       

        private void dgvdetails_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            textBox2.Text = dgvdetails.Rows[RowIndex].Cells[0].Value.ToString();
            textBox5.Text = dgvdetails.Rows[RowIndex].Cells[1].Value.ToString();
            textBox4.Text = dgvdetails.Rows[RowIndex].Cells[2].Value.ToString();
            textBox6.Text = dgvdetails.Rows[RowIndex].Cells[3].Value.ToString();
            textBox3.Text = dgvdetails.Rows[RowIndex].Cells[4].Value.ToString();
            textBox7.Text = dgvdetails.Rows[RowIndex].Cells[5].Value.ToString();
            comboBox4.Text = dgvdetails.Rows[RowIndex].Cells[6].Value.ToString();
        }

        private void pictureBox_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            BloodStock bloodStock = new BloodStock();
            bloodStock.Show();
        }
    }
}