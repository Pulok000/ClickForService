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
    public partial class AdminMyProfile : Form
    {
        public AdminMyProfile()
        {
            InitializeComponent();
        }

        private void AdminMyProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AdminMyProfile_Load(object sender, EventArgs e)
        {

            SqlConnection connectionn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);
            connectionn.Open();

            string sql = "SELECT *FROM Registrations WHERE userName= '" + Login.UserName + "'";

            
            SqlCommand command = new SqlCommand(sql, connectionn);
           

            SqlDataReader reader12 = command.ExecuteReader();
            //connectionn.Close();

            if (reader12.Read())
            {
                 Nametextbox.Text = Convert.ToString(reader12["fullName"]);
                 UNtextbox.Text = Convert.ToString(reader12["userName"]);
                 PasswordtextBox.Text = Convert.ToString(reader12["password"]);
                 NidregistertextBox.Text = Convert.ToString(reader12["NID"]);
                 EmailregistertextBox.Text = Convert.ToString(reader12["emailId"]);
                 MobilenumbertextBox.Text = Convert.ToString(reader12["mobileNumber"]);
                 DOBBOX.Text = Convert.ToString(reader12["dateofbirth"]);
                 textBoxgender.Text = Convert.ToString(reader12["gender"]);
                 textBoxdivision.Text = Convert.ToString(reader12["Division"]);
                 textBox4.Text = Convert.ToString(reader12["City"]);
                 AddresText.Text = Convert.ToString(reader12["Address"]);
                 textBox5.Text = Convert.ToString(reader12["category"]);
                 textBox6.Text = Convert.ToString(reader12["Profession"]);
                 textBox7.Text = Convert.ToString(reader12["bloodGroup"]);

                 connectionn.Close();


            }
            connectionn.Close();


            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);
            connection.Open();

            string sql1 = "SELECT *FROM userpermissions WHERE userName= '" + Login.UserName + "'";

            SqlCommand command1 = new SqlCommand(sql1, connection);


            SqlDataReader reader = command1.ExecuteReader();

            
   
            if (reader.Read())
            {
                textBox8.Text = Convert.ToString(reader["Designation"]);

                connection.Close();


            }
            else 
            {
                connection.Close();
             }
            connection.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
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

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
