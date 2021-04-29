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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void MobilenumberregistertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Loginregisterbutton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AgreeregistercheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CountryregistercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FemaleregisterradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MaleregisterradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DateofbirthregisterdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EmailregistertextBox_TextChanged(object sender, EventArgs e)
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
            ////Login login = new Login();
            //this.Hide();
            //login.Show();


            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
             connection.Open();

             string sql = "SELECT *FROM Users WHERE userName= '" + UsernameregistertextBox.Text + "' ";
             SqlCommand command = new SqlCommand(sql, connection);
             SqlDataReader reader = command.ExecuteReader();


             if (reader.Read())
             {
                 MessageBox.Show("User Name Already Exist!!!!!!!!!!Give Another User Name.....");
                 Registration registration = new Registration();

                 this.Hide();
                 registration.Show();





             }

             else
             {

                 if (AgreeregistercheckBox.Text == "")
                 {
                     MessageBox.Show("agree can not be empty");
                 }

                 else if (NameregistertextBox.Text == "")
                 { MessageBox.Show("Name can not be empty"); }

                 else if (UsernameregistertextBox.Text == "")
                 { MessageBox.Show("User Name can not be empty"); }

                 else if (PasswordregistertextBox.Text == "")
                 { MessageBox.Show("Password can not be empty"); }

                 else if (ConfirmpasswordregistertextBox.Text == "")
                 { MessageBox.Show("Confrim Password can not be empty"); }

                 else if (EmailregistertextBox.Text == "")
                 { MessageBox.Show("Email can not be empty"); }

                 else if (DateofbirthregisterdateTimePicker.Text == "")
                 { MessageBox.Show("Date of Birth can not be empty"); }

                 else if (MaleregisterradioButton.Text == "" && FemaleregisterradioButton.Text == "")
                 { MessageBox.Show("Gender can not be empty"); }

                 else if (CityregistercomboBox.Text == "")
                 { MessageBox.Show("Blood Group can not be empty"); }

            else if (NidregistertextBox.Text == "")
                 { MessageBox.Show("Blood Group can not be empty"); }

            else if (MobilenumberregistertextBox.Text == "")
                 { MessageBox.Show("Blood Group can not be empty"); }

            else if (DivisionregistercomboBox.Text == "")
                 { MessageBox.Show("Blood Group can not be empty"); }

            else if (AddressregistertextBox.Text == "")
                 { MessageBox.Show("Blood Group can not be empty"); }

            else if (CategoryregistercomboBox.Text == "")
                 { MessageBox.Show("Blood Group can not be empty"); }




                 else
                 {
                     //Database
                     SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);

                     connection1.Open();

                     string gender = "";
                     if (MaleregisterradioButton.Checked)
                     {
                         gender = "Male";
                     }
                     else
                     {
                         gender = "Female";
                     }
                     string sql1 = "INSERT INTO Registrations(userName,emailid,password,category,Address,City,Division,bloodGroup,mobileNumber,NID,fullName,dateofbirth,gender,Profession)VALUES('" + UsernameregistertextBox.Text + "','" + EmailregistertextBox.Text + "','" + PasswordregistertextBox.Text + "','" + CategoryregistercomboBox.Text + "','" + AddressregistertextBox.Text + "','" + CityregistercomboBox.Text + "','" + DivisionregistercomboBox.Text + "','" + BloodgroupregistercomboBox.Text + "','" + MobilenumberregistertextBox.Text + "','" + NidregistertextBox.Text + "','" + NameregistertextBox.Text + "','" + DateofbirthregisterdateTimePicker.Text + "','" + gender+ "','" + ProfessionregistercomboBox.Text + "')";
                     SqlCommand command1 = new SqlCommand(sql, connection1);
                     int result = command1.ExecuteNonQuery();

                     if (result > 0)
                     {
                         MessageBox.Show("User Added");
                         connection1.Close();
                         Login login = new Login();
                         this.Hide();
                         login.Show();
                         connection1.Close();
                     }
                     else

                     {
                         MessageBox.Show("User Not Added");
                         connection1.Close();
                     }

                 }

             }
             connection.Close();



        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
