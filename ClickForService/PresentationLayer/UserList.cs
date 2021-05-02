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
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void UserList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserList_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);
            connection.Open();

            string sql = "SELECT *FROM Registrations WHERE category='" + "Service Taker" + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<userlistpro> EL = new List<userlistpro>();
            while (reader.Read())
            {
                userlistpro el = new userlistpro();
                el.FullName = Convert.ToString(reader["fullName"]);
                el.UN = Convert.ToString(reader["userName"]);
                el.NID = Convert.ToString(reader["NID"]);
                el.MobileNumber = Convert.ToString(reader["mobileNumber"]);
                el.Address = Convert.ToString(reader["Address"]);
                el.Division = Convert.ToString(reader["Division"]);

                el.City = Convert.ToString(reader["City"]);




                EL.Add(el);

            }

            dataGridView1.DataSource = EL;
            connection.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox3.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox4.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox5.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox6.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox8.Text= dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox7.Text=dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);

            connection.Open();
            string PF = "Service Taker";

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
                

                connection.Close();

            }
            else
            {

                MessageBox.Show("Sorry! There is No User Found");
                connection.Close();
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
