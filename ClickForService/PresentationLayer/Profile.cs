using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
