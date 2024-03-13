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

namespace BloodBankManagementSystem.UI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public static string registereduser;
        SqlConnection connection = new SqlConnection("Data Source=HELLO\\SQLEXPRESS;Initial Catalog=BloodBankManagementSystem;Integrated Security=True;Encrypt=True; TrustServerCertificate=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text!="" && textBox2.Text!="" && textBox3.Text != "")
                {
                    int v = check(textBox1.Text);
                    if (v != 1)
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("insert into tbl_register values(@fullname,@email,@contact,@city,@username,@password,@confirm_password)",connection);
                        cmd.Parameters.AddWithValue("@fullname", textBox6.Text);
                        cmd.Parameters.AddWithValue("@email", textBox1.Text);
                        cmd.Parameters.AddWithValue("@contact", textBox5.Text);
                        cmd.Parameters.AddWithValue("@city", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@username", textBox2.Text);
                        cmd.Parameters.AddWithValue("@password", textBox3.Text);
                        cmd.Parameters.AddWithValue("@confirm_password", textBox7.Text);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Registration Successful!");
                        registereduser = textBox2.Text;
                        this.Hide();
                        textBox6.Text = "";
                        textBox1.Text = "";
                        textBox5.Text = "";
                        comboBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox7.Text = "";
                    }
                    else
                    {
                    MessageBox.Show("Email is already registered.");
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
                connection.Close() ;
            }
            Home home = new Home();
            home.Show();
        }
        int check(string email)
        {
            connection.Open();
            string query = "select count(*) from tbl_register where email='" + email + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            int v=(int)cmd.ExecuteScalar();
            connection.Close();
            return v;   
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox3.UseSystemPasswordChar = false;
                textBox7.UseSystemPasswordChar =false;
            }
            else
            {
                textBox3.UseSystemPasswordChar= true;
                textBox7.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
