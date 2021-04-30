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
            if (AgreeregistercheckBox.Checked)
            {
                Registerformbutton.Enabled = true;
            }
            else Registerformbutton.Enabled = false;
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

            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            connect.Open();
            string Gender = "";
            if (MaleregisterradioButton.Checked)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }

            string sql1 = "INSERT INTO Registrations(userName, emailId, password, category, Address, City, Division, bloodGroup, mobileNumber, NID, fullName, dateofbirth, gender, Profession) VALUES('" + UsernameregistertextBox.Text + "','"+EmailregistertextBox.Text+ "', '" + PasswordregistertextBox.Text + "','" + CategoryregistercomboBox.Text + "','" + AddressregistertextBox.Text + "','" + CityregistercomboBox.Text + "','" + DivisionregistercomboBox.Text + "','" + BloodgroupregistercomboBox.Text + "','" + MobilenumberregistertextBox.Text + "','" + NidregistertextBox.Text + "','" + NameregistertextBox.Text + "','" + DateofbirthregisterdateTimePicker.Text + "','" + Gender + "','" + ProfessionregistercomboBox.Text + "')";

            SqlCommand command1 = new SqlCommand(sql1, connect);
            int result = command1.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Registration Sucessful....Please Login");
                
                connect.Close();





            }
            else
            {
                MessageBox.Show("Error");
                connect.Close();

            }




            connect.Close();



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
