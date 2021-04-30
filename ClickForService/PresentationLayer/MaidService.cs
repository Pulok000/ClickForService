using ClickForService.BusinessLogicLayer;
using ClickForService.DatabaseConnectionLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickForService.PresentationLayer
{
    public partial class MaidService : Form
    {
        public MaidService()
        {
            InitializeComponent();
        }

        private void MaidService_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT *FROM Registrations WHERE userName='" + Login.UserName + "'";
            AccessProperty ap = new AccessProperty();
            DataAcess da = new DataAcess();
            SqlDataReader reader = da.GetData(sql);
            //while (reader.Read())
            //{


            //}
            da.ConnectionClose();

        } 
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            HouseHoldService hs = new HouseHoldService();
            this.Hide();
            hs.Show();
        }

        private void MaidService_Load(object sender, EventArgs e)
        {
            string sql = "SELECT *FROM Registrations WHERE userName='" + Login.UserName + "'";
            AccessProperty ap = new AccessProperty();
            DataAcess da = new DataAcess();
            SqlDataReader reader = da.GetData(sql);
            while (reader.Read())
            {
                textBox1.Text = Convert.ToString(reader["City"]);

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
