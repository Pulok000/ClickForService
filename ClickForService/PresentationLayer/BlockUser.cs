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
    public partial class BlockUser : Form
    {
        public BlockUser()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmpasswordregistertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordregistertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameregistertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameregistertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registerformbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            connection.Open();
            
            string sql = "UPDATE userpermissions SET Block='" + "yes" + "'WHERE userName='" + UsernameregistertextBox.Text + "'";

            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
               
               MessageBox.Show("User Blocked...!!!");
                    

                connection.Close();


            }
            else
            {
                MessageBox.Show("Error while Blocking User");
                connection.Close();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Nameregisterlabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);

            connection.Open();

            string sql1 = "SELECT *FROM userpermissions WHERE userName= '" + textBox1.Text + "'";
            SqlCommand command = new SqlCommand(sql1, connection);
            SqlDataReader reader = command.ExecuteReader();


            textBox1.Text = "";

            if (reader.Read())
            {
                MessageBox.Show("User Found");
                UsernameregistertextBox.Text = Convert.ToString(reader["userName"]);
                
                connection.Close();

            }
            else
            {

                MessageBox.Show("Sorry! There is No User Found");
                connection.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            connection.Open();

            string sql = "UPDATE userpermissions SET Block='" + "yes" + "'WHERE userName='" + UsernameregistertextBox.Text + "'";

            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            if (result > 0)
            {

                MessageBox.Show("User Unblocked...!!!");


                connection.Close();


            }
            else
            {
                MessageBox.Show("Error while Unblocking User");
                connection.Close();
            }

        }

        private void BlockUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
