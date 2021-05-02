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
           
            SqlDataReader reader=da.GetData(sql);

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

                //textBoxName.Text = Convert.ToString(reader["fullName"]);
                //textBoxEmail.Text = Convert.ToString(reader["emailId"]);
                //textBoxPass.Text = Convert.ToString(reader["password"]);
                //Textboxgender.Text = Convert.ToString(reader["gender"]);
                da.ConnectionClose();

               
            }
            da.ConnectionClose();
        }

        private void ShowProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
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
