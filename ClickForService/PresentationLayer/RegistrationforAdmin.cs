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
    public partial class RegistrationforAdmin : Form
    {
        public RegistrationforAdmin()
        {
            InitializeComponent();
        }

        private void RegistrationforAdmin_Load(object sender, EventArgs e)
        {

        }

        private void Registerformbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection11 = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            connection11.Open();

            string sql = "SELECT *FROM Registrations WHERE userName='" + UsernameregistertextBox.Text + "'";
            SqlCommand command11 = new SqlCommand(sql, connection11);
            SqlDataReader reader = command11.ExecuteReader();

            if (reader.Read())
            {

                MessageBox.Show("This Username Already Used by Another Person....Give Another User Name....!!");
                Registration rr = new Registration();
                this.Hide();
                rr.Show();
                connection11.Close();


            }

            else
            {
                connection11.Close();
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
                {
                    MessageBox.Show("Confrim Password can not be empty");
                }
                else if (EmailregistertextBox.Text ==" ")
                {
                        MessageBox.Show("Email can not be empty");
                }

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

                    string sql1 = "INSERT INTO Registrations(userName, emailId, password, category, Address, City, Division, bloodGroup, mobileNumber, NID, fullName, dateofbirth, gender, Profession) VALUES('" + UsernameregistertextBox.Text + "','" + EmailregistertextBox.Text + "', '" + PasswordregistertextBox.Text + "','" + CategoryregistercomboBox.Text + "','" + AddressregistertextBox.Text + "','" + CityregistercomboBox.Text + "','" + DivisionregistercomboBox.Text + "','" + BloodgroupregistercomboBox.Text + "','" + MobilenumberregistertextBox.Text + "','" + NidregistertextBox.Text + "','" + NameregistertextBox.Text + "','" + DateofbirthregisterdateTimePicker.Text + "','" + Gender + "','" + ProfessionregistercomboBox.Text + "')";

                    string ab = "";
                    if (CategoryregistercomboBox.Text == "Service Giver")
                    {
                        ab = "GU";
                    }
                    else if (CategoryregistercomboBox.Text == "Service Taker")
                    { ab = "ST"; }

                    else { ab = "AD"; }



                    SqlCommand command1 = new SqlCommand(sql1, connect);

                    int result = command1.ExecuteNonQuery();
                    if (result > 0)
                    {
                        string sql2 = "INSERT INTO userpermissions(userName, uniqueCode, password, Designation) VALUES('" + UsernameregistertextBox.Text + "','" + ab + "', '" + PasswordregistertextBox.Text + "','" +comboBoxDesig.Text+ "')";
                        SqlCommand command2 = new SqlCommand(sql2, connect);
                        int result3 = command2.ExecuteNonQuery();


                        MessageBox.Show("Registration Sucessful....Please Login");
                        Login login = new Login();
                        this.Hide();
                        login.Show();

                        connect.Close();

                    }
                    else
                    {
                        MessageBox.Show("Error");
                        connect.Close();

                    }


                    connect.Close();
                }
            }
        }

        private void RegistrationforAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
