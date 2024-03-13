using BloodBankManagementSystem.DAL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BloodBankManagementSystem.UI
{
    public partial class BloodStock : Form
    {
        public BloodStock()
        {
            InitializeComponent();
        }
        donorDAL dal = new donorDAL();
        SqlConnection connection = new SqlConnection("Data Source=HELLO\\SQLEXPRESS;Initial Catalog=BloodBankManagementSystem;Integrated Security=True;Encrypt=True; TrustServerCertificate=True");
        private void label6_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
        }

        private void BloodStock_Load(object sender, EventArgs e)
        {
            allDonorCount();
        }
        public void allDonorCount()
        {
            label26.Text = dal.countDonors("O+");
            label11.Text = dal.countDonors("O-");
            label20.Text = dal.countDonors("A+");
            label23.Text = dal.countDonors("A-");
            label35.Text = dal.countDonors("B+");
            label41.Text = dal.countDonors("B-");
            label32.Text = dal.countDonors("AB+");
            label38.Text = dal.countDonors("AB-");
        }

        private void BloodStock_Activated(object sender, EventArgs e)
        {
            allDonorCount();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBox1.Text!="" && comboBox2.Text!= "" && comboBox3.Text!= "")
                {
                    int v = check(comboBox1.Text);
                    if (v != 1)
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("insert into BloodBankStock values(@City,@BloodGroup,@BloodComponent)", connection);
                        cmd.Parameters.AddWithValue("@City", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@BloodGroup", comboBox2.Text);
                        cmd.Parameters.AddWithValue("@BloodComponent", comboBox3.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Search Successful!");
                        this.Hide();
                        connection.Close();
                        comboBox1.Text = "";
                        comboBox2.Text = "";
                        comboBox3.Text = "";
                    }

                    else
                    {
                        MessageBox.Show("Blood Group doesn't match.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Attempt!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
            
        
        int check(string City)
        {
            connection.Open();
            string query = "select count(*) from BloodBankStock where City='" + City + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            int v = (int)cmd.ExecuteScalar();
            connection.Close();
            return v;
        }

    }
}
