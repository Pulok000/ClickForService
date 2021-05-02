using ClickForService.DatabaseConnectionLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickForService.PresentationLayer
{
    public partial class AdminList : Form
    {
        public AdminList()
        {
            InitializeComponent();
        }

        private void AdminList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashboardforAdmin dashboardforAdmin = new DashboardforAdmin();
            this.Hide();


            DialogResult d;

            d = MessageBox.Show("Do you want to Go Back?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                dashboardforAdmin.Show();
            }
            else if (d == DialogResult.No)
            {
                this.Show();
            }
            else
                Close();
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);

            connection.Open();
            string PF = "Click For Service Staff";

            string sql1 = "SELECT *FROM Registrations WHERE userName= '" + textBox1.Text + "' AND category='" + PF + "' ";
            SqlCommand command = new SqlCommand(sql1, connection);
            SqlDataReader reader = command.ExecuteReader();


            textBox1.Text = "";

            if (reader.Read())
            {
                textBox2.Text = Convert.ToString(reader["fullName"]);
                textBox3.Text = Convert.ToString(reader["userName"]);
                textBox4.Text = Convert.ToString(reader["NID"]);
                textBox5.Text = Convert.ToString(reader["mobileNumber"]);
                textBox6.Text = Convert.ToString(reader["Address"]);
                textBox8.Text = Convert.ToString(reader["Division"]);
                textBox7.Text = Convert.ToString(reader["City"]);
                textBox9.Text = Convert.ToString(reader["Profession"]);


                connection.Close();

            }
            else
            {

                MessageBox.Show("Sorry! There is No User Found");
                connection.Close();
            }

        }

        private void AdminList_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);
            connection.Open();

            string sql = "SELECT *FROM Registrations WHERE category='" + "Click For Service Staff" + "'";

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();


            List<Adminlists> EL = new List<Adminlists>();
            while (reader.Read())
            {
                Adminlists sL = new Adminlists();
                sL.FullName = Convert.ToString(reader["fullName"]);
                sL.UN = Convert.ToString(reader["userName"]);
                sL.NID = Convert.ToString(reader["NID"]);
                sL.MobileNumber = Convert.ToString(reader["mobileNumber"]);
                sL.Address = Convert.ToString(reader["Address"]);
                sL.Division = Convert.ToString(reader["Division"]);
                sL.City = Convert.ToString(reader["City"]);
                // sL.Designation = Convert.ToString(reader["Designation"]);      
                EL.Add(sL);

            }

            dataGridView1.DataSource = EL;
            connection.Close();




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            //textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);
            connection.Open();

            string sql = "SELECT *FROM userPermissions WHERE userName='" + textBox3.Text + "'";

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                textBox9.Text = Convert.ToString(reader["Designation"]);
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 
