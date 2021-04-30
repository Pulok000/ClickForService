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
    public partial class ShowProfile : Form
    {
        public ShowProfile()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ShowProfile_Load(object sender, EventArgs e)
        {
            DataAcess da = new DataAcess();

            string sql = "SELECT *FROM Registrations WHERE userName= '" + Login.UserName+"'";
           
            da.GetData(sql);
            SqlDataReader reader=;

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
    }
}
