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

            string sql = "SELECT *FROM Registrations WHERE category='" + "Service Giver" + "'";
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

                string sql1 = "SELECT *FROM userpermissions WHERE uniqueCode='" + "AD" + "'";
                SqlCommand command1 = new SqlCommand(sql1, connection);

                SqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    sL.Designation= Convert.ToString(reader1["Designation"]);
                }
                EL.Add(sL);

            }

            dataGridView1.DataSource = EL;
            connection.Close();

        }
    }

}
 
