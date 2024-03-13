using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.UI
{
    public partial class Request : Form
    {
        public Request()
        {
            InitializeComponent();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Request_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bloodBankManagementSystemDataSet2.RequestTable' table. You can move, or remove it, as needed.
            this.requestTableTableAdapter.Fill(this.bloodBankManagementSystemDataSet2.RequestTable);

        }

        private void iNSERTToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.requestTableTableAdapter.INSERT(this.bloodBankManagementSystemDataSet2.RequestTable);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.requestTableTableAdapter.FillBy(this.bloodBankManagementSystemDataSet2.RequestTable);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             

        }
    }
}
