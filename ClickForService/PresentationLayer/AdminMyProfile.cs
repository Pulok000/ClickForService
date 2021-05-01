using ClickForService.DatabaseConnectionLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickForService.PresentationLayer
{
    public partial class AdminMyProfile : Form
    {
        public AdminMyProfile()
        {
            InitializeComponent();
        }

        private void AdminMyProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AdminMyProfile_Load(object sender, EventArgs e)
        {
            DataAcess da = new DataAcess();

            string sql = "SELECT *FROM Registrations WHERE userName= '" + Login.UserName + "'";

            da.GetData(sql);
            SqlDataReader reader = da.GetData(sql);

            if (reader.Read())
            {
                 Nametextbox.Text = Convert.ToString(reader["fullName"]);
                 UNtextbox.Text = Convert.ToString(reader["userName"]);
                 PasswordtextBox.Text = Convert.ToString(reader["password"]);
                 NidregistertextBox.Text = Convert.ToString(reader["NID"]);
                 EmailregistertextBox.Text = Convert.ToString(reader["emailId"]);
                 MobilenumbertextBox.Text = Convert.ToString(reader["mobileNumber"]);
                 DOBBOX.Text = Convert.ToString(reader["dateofbirth"]);
                 textBoxgender.Text = Convert.ToString(reader["gender"]);
                 textBoxdivision.Text = Convert.ToString(reader["Division"]);
                 textBox4.Text = Convert.ToString(reader["City"]);
                 AddresText.Text = Convert.ToString(reader["Address"]);
                 textBox5.Text = Convert.ToString(reader["category"]);
                 textBox6.Text = Convert.ToString(reader["Profession"]);
                 textBox7.Text = Convert.ToString(reader["bloodGroup"]);

                //textBoxPass.Text = Convert.ToString(reader["password"]);
                //Textboxgender.Text = Convert.ToString(reader["gender"]);
                da.ConnectionClose();


            }

            DataAcess da1 = new DataAcess();

            string sql1 = "SELECT *FROM userpermissions WHERE userName= '" + Login.UserName + "'";

            da1.GetData(sql1);
            SqlDataReader reader1 = da1.GetData(sql1);

            if (reader.Read())
            {
                textBox8.Text = Convert.ToString(reader["Designation"]);

                da1.ConnectionClose();


            }
        }
    }
}
