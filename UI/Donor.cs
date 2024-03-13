using BloodBankManagementSystem.BLL;
using BloodBankManagementSystem.DAL;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BloodBankManagementSystem.UI
{
    public partial class Donor : Form
    {
        public Donor()
        {
            InitializeComponent();
        }
        donorBLL d = new donorBLL();
        donorDAL dal = new donorDAL();
        donation s= new donation();
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Donor_Load(object sender, EventArgs e)
        {

            DataTable dt = dal.Select();
            dgvdetails.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            d.FirstName = textBox3.Text;
            d.LastName = textBox4.Text;
            d.Email = textBox5.Text;
            d.Gender = comboBox1.Text;
            d.Contact = textBox9.Text;
            s.City = comboBox4.Text;
            s.BloodGroup = comboBox2.Text;
            s.AddedDate = DateTime.Now;

            bool success = dal.Insert(d,s);
          

            if (success == true)
            {
                MessageBox.Show("New Donor Added Successfully.");

                DataTable dt = dal.Select();
                dgvdetails.DataSource = dt;

                Clear();
            }
            else
            {
                MessageBox.Show("Failed To Add New Donor.");
            }
        }
        public void Clear()
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox4.Text = "";
            textBox9.Text = "";
            textBox2.Text = "";

        }

        private void label6_Click(object sender, EventArgs e)
        {
            d.DonorId = int.Parse(textBox2.Text);
            d.FirstName = textBox3.Text;
            d.LastName = textBox4.Text;
            d.Email = textBox5.Text;
            d.Gender = comboBox1.Text;
            s.BloodGroup = comboBox2.Text;
            d.Contact = textBox9.Text;
            s.City = comboBox4.Text;
            
            

            bool success = dal.Update(d,s);

            if (success == true)
            {
                MessageBox.Show("Donor Updated Successfully.");

                DataTable dt = dal.Select();
                dgvdetails.DataSource = dt;

                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update donors!");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            d.DonorId = int.Parse(textBox2.Text);
            bool success = dal.Delete(d);

            if (success == true)
            {
                MessageBox.Show("Donor Deleted Successfully.");
                DataTable dt = dal.Select();
                dgvdetails.DataSource = dt;

                Clear();
            }
            else
            {
                MessageBox.Show("Failed to make changes");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keywords = textBox1.Text;
            if(keywords!= null)
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

       
        private void dgvdetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            textBox2.Text = dgvdetails.Rows[RowIndex].Cells[0].Value.ToString();
            textBox3.Text = dgvdetails.Rows[RowIndex].Cells[1].Value.ToString();
            textBox4.Text = dgvdetails.Rows[RowIndex].Cells[2].Value.ToString();
            textBox5.Text = dgvdetails.Rows[RowIndex].Cells[3].Value.ToString();
            textBox9.Text = dgvdetails.Rows[RowIndex].Cells[4].Value.ToString();
            comboBox1.Text = dgvdetails.Rows[RowIndex].Cells[5].Value.ToString();
            comboBox4.Text = dgvdetails.Rows[RowIndex].Cells[6].Value.ToString();
            comboBox2.Text = dgvdetails.Rows[RowIndex].Cells[7].Value.ToString();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            BloodStock bloodStock = new BloodStock();
            bloodStock.Show();
        }
    }
}
