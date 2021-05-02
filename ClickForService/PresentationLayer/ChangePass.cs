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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void ChangePass_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ChangePass_Load(object sender, EventArgs e)
        {
            DataAcess da = new DataAcess();

            string sql = "SELECT *FROM Registrations WHERE userName= '" + Login.UserName + "'";

            SqlDataReader reader = da.GetData(sql);

            if (reader.Read())
            {
                NameregistertextBox.Text = Convert.ToString(reader["fullName"]);
                UsernameregistertextBox.Text = Convert.ToString(reader["userName"]);

                da.ConnectionClose();


            }
            da.ConnectionClose();
        }

        private void Registerformbutton_Click(object sender, EventArgs e)
        {
            if (PasswordregistertextBox.Text == "")
            {
                MessageBox.Show("Please Enter Password");
            }

            else if (ConfirmpasswordregistertextBox.Text == "")
            {
                MessageBox.Show("Please Re-Type Password");
            }



            else
            {
                //Print print = new Print(this);
                //print.Show();
                //this.Hide();

                //Database
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
                connection.Open();


                string sql = "UPDATE Registrations SET password='" + PasswordregistertextBox.Text + "' WHERE userName='" + Login.UserName + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    string sql1 = "UPDATE userpermissions SET password='" + PasswordregistertextBox.Text + "' WHERE userName='" + Login.UserName + "'";
                    SqlCommand command1 = new SqlCommand(sql1, connection);
                    int result1 = command1.ExecuteNonQuery();
                    if (result1 > 0)
                    {
                        MessageBox.Show("Password Changed");
                        connection.Close();
                    }
                    connection.Close();

                }
                else
                {
                    MessageBox.Show("Error in Changing Password....!!!");
                    connection.Close();
                }


            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard= new Dashboard();
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
