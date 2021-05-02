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
    public partial class UserProfileInAdmin : Form
    {
        public UserProfileInAdmin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (Nametextbox.Text == "")
            {
                MessageBox.Show("If you don't change the Name, Then keep the previous name in this Box");
            }

            else if (NidregistertextBox.Text == "")
            {
                MessageBox.Show("If you don't change the NID Number, Then keep the previous NID in this Box");
            }

            else if (EmailregistertextBox.Text == "")
            {
                MessageBox.Show("If you don't change the E-mail, Then keep the previous E-mail in this Box");
            }

            else if (MobilenumbertextBox.Text == "")
            {
                MessageBox.Show("User Password Can't be Empty");
            }


            else if (DateofbirthregisterdateTimePicker.Text == "")
            {
                MessageBox.Show("Confirm Password Can't be Empty");
            }

            else if (DivisionregistercomboBox.Text == "")
            {
                MessageBox.Show("Please Select Gender");
            }

            else if (CityregistercomboBox.Text == "")
            {
                MessageBox.Show("Please Select Blood Group");
            }



            else
            {
                //Print print = new Print(this);
                //print.Show();
                //this.Hide();

                //Database
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
                connection.Open();
                string Gender = "";
                if(radioButtonMale.Checked)
                { Gender = "Male"; }
                else { Gender = "Female"; }

                string sql = "UPDATE Registrations SET fullName='" + Nametextbox.Text + "',password='"+PasswordtextBox.Text+"',NID='"+NidregistertextBox.Text+"',gender='"+Gender+"',Profession='"+ ProfessionregistercomboBox.Text+ "',bloodGroup='"+ BloodgroupregistercomboBox.Text+ "',emailId='" + EmailregistertextBox.Text + "',dateofbirth='" + DateofbirthregisterdateTimePicker.Text + "',mobileNumber='" + MobilenumbertextBox.Text + "',Division='" + DivisionregistercomboBox.Text + "',City='" + CityregistercomboBox.Text + "',Address='" + AddresText.Text + "',category='" + CategoryregistercomboBox.Text + "' WHERE userName='" +UNtextbox.Text+ "'";
               
                SqlCommand command = new SqlCommand(sql, connection);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    string ab = "";
                    if(CategoryregistercomboBox.Text=="Service Taker")
                    { ab = "ST"; }
                    else if(CategoryregistercomboBox.Text=="Service Giver")
                    { ab = "GU"; }
                    
                    string sql1 = "UPDATE userpermissions SET password='" +PasswordtextBox.Text+ "',uniqueCode='"+ab+"' WHERE userName='" + UNtextbox.Text+ "'";
                    SqlCommand command1 = new SqlCommand(sql1, connection);
                    int result1 = command1.ExecuteNonQuery();
                    if (result1 > 0)
                    {
                        MessageBox.Show("User Information Changed...!!!");
                        connection.Close();
                    }

                    connection.Close();


                }
                else
                {
                    MessageBox.Show("Error while updating");
                    connection.Close();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);

            connection.Open();

            string sql1 = "SELECT *FROM Registrations WHERE userName= '" + textBox1.Text + "'";
            SqlCommand command = new SqlCommand(sql1, connection);
            SqlDataReader reader = command.ExecuteReader();


            textBox1.Text = "";

            if (reader.Read())
            {
                Nametextbox.Text = Convert.ToString(reader["fullName"]);
                UNtextbox.Text = Convert.ToString(reader["userName"]);
                PasswordtextBox.Text = Convert.ToString(reader["password"]);
                MobilenumbertextBox.Text = Convert.ToString(reader["mobileNumber"]);
                AddresText.Text = Convert.ToString(reader["Address"]);
                DivisionregistercomboBox.Text = Convert.ToString(reader["Division"]);
                CityregistercomboBox.Text = Convert.ToString(reader["City"]);
                ProfessionregistercomboBox.Text = Convert.ToString(reader["Profession"]);
                NidregistertextBox.Text = Convert.ToString(reader["NID"]);
                EmailregistertextBox.Text = Convert.ToString(reader["emailId"]);
                BloodgroupregistercomboBox.Text = Convert.ToString(reader["bloodGroup"]);
                
                if(Convert.ToString(reader["gender"])=="Male")
                {
                    radioButtonMale.Checked=true;

                }
                else if(Convert.ToString(reader["gender"]) == "Female")
                {
                    radioButton2.Checked = true;
                }
                else { radioButtonMale.Checked = radioButton2.Checked = false; }
                connection.Close();

            }
            else
            {

                MessageBox.Show("Sorry! There is No User Found");
                connection.Close();
            }


        }

        private void UserProfileInAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UserProfileInAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
