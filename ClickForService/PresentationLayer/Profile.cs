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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["userconnection"].ConnectionString);
            connection.Open();

            string sql = "SELECT *FROM Users WHERE ID=" + Convert.ToInt32(idtextbox.Text);
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                nametextBox.Text = Convert.ToString(reader["Name"]);
                usertextBox.Text = Convert.ToString(reader["Username"]);
                passwordtextBox.Text = Convert.ToString(reader["Password"]);
                string gender;
                gender = Convert.ToString(reader["Gender"]);
                if (gender == "Male")
                {
                    radioButton1.Checked = true;
                }
                else { radioButton2.Checked = true; }


                emailtextBox.Text = Convert.ToString(reader["Email"]);
                dateTimePicker1.Text = reader["DateOfB"].ToString();
                comboBox1.Text = Convert.ToString(reader["BloodGroup"]);

            }
        }

        private void buttonSPI_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();


            DialogResult d;

            d = MessageBox.Show("Do you want to Go Back?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                dashboard.Show();
            }
            else if (d == DialogResult.No)
            {
                this.Show();
            }
            else
                Close();
        }
    }
}
