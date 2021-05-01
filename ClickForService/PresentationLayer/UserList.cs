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
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void UserList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserList_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);
            connection.Open();

            string sql = "SELECT *FROM Registrations WHERE category='" + "Service Taker" + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<userlistpro> EL = new List<userlistpro>();
            while (reader.Read())
            {
                userlistpro eventlist = new userlistpro();
                eventlist.FullName = Convert.ToString(reader["fullName"]);
                eventlist.UN = Convert.ToString(reader["userName"]);
                eventlist.NID = Convert.ToString(reader["NID"]);
                eventlist.MobileNumber = Convert.ToString(reader["mobileNumber"]);
                eventlist.Address = Convert.ToString(reader["Address"]);
                eventlist.Division = Convert.ToString(reader["Division"]);

                eventlist.City = Convert.ToString(reader["City"]);




                EL.Add(eventlist);

            }

            dataGridView1.DataSource = EL;
            connection.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

           /* pictureBox1.Image = new Bitmap(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());

            textBoxImagepath.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxCreateDate.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        */}
    }
}
