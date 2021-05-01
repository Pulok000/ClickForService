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
                 UNtextbox.Text = Convert.ToString(reader["emailId"]);
                //textBoxPass.Text = Convert.ToString(reader["password"]);
                //Textboxgender.Text = Convert.ToString(reader["gender"]);
                da.ConnectionClose();


            }
        }
    }
}
