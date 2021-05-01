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
    public partial class ProfileIC : Form
    {
        public ProfileIC()
        {
            InitializeComponent();
        }

        private void ProfileIC_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
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

            else if (DivisionregistercomboBox.Text=="")
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
                

              string sql = "UPDATE Registrations SET fullName='" + Nametextbox.Text + "',emailId='" + EmailregistertextBox.Text + "',dateofbirth='" + DateofbirthregisterdateTimePicker.Text + "',mobileNumber='"+ MobilenumbertextBox .Text+"',Division='"+DivisionregistercomboBox.Text+"',City='"+CityregistercomboBox.Text+"',Address='"+AddresText.Text+"',category='"+ CategoryregistercomboBox.Text+ "' WHERE userName='"+Login.UserName+"'";
              SqlCommand command = new SqlCommand(sql, connection);
              int result = command.ExecuteNonQuery();
                if (result > 0)
                {

                    MessageBox.Show("User Updated");
                    connection.Close();
                    

                }
                else
                {
                    MessageBox.Show("Error while updating");
                    connection.Close();
                }

            }
        }

        private void ProfileIC_Load(object sender, EventArgs e)
        {
            DataAcess da = new DataAcess();

            string sql = "SELECT *FROM Registrations WHERE userName= '" + Login.UserName + "'";

            SqlDataReader reader = da.GetData(sql);

            if (reader.Read())
            {
                Nametextbox.Text = Convert.ToString(reader["fullName"]);
                UNtextbox.Text = Convert.ToString(reader["userName"]);
                PasswordtextBox.Text = Convert.ToString(reader["password"]);
                NidregistertextBox.Text = Convert.ToString(reader["NID"]);
                EmailregistertextBox.Text = Convert.ToString(reader["emailId"]);
                MobilenumbertextBox.Text = Convert.ToString(reader["mobileNumber"]);
                DateofbirthregisterdateTimePicker.Text = Convert.ToString(reader["dateofbirth"]);
                textBoxgender.Text = Convert.ToString(reader["gender"]);
                DivisionregistercomboBox.Text = Convert.ToString(reader["Division"]);
                CityregistercomboBox.Text = Convert.ToString(reader["City"]);
                AddresText.Text = Convert.ToString(reader["Address"]);
                CategoryregistercomboBox.Text = Convert.ToString(reader["category"]);
                textBox6.Text = Convert.ToString(reader["Profession"]);
                textBox7.Text = Convert.ToString(reader["bloodGroup"]);

                //textBoxName.Text = Convert.ToString(reader["fullName"]);
                //textBoxEmail.Text = Convert.ToString(reader["emailId"]);
                //textBoxPass.Text = Convert.ToString(reader["password"]);
                //Textboxgender.Text = Convert.ToString(reader["gender"]);
                da.ConnectionClose();


            }
            da.ConnectionClose();
        }

    }
}

