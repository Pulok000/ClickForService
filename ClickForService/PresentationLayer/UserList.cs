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

            string sql = "SELECT *FROM Registrations WHERE userName='" + Login.UserName + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<AccessProperty> EL = new List<AccessProperty>();
            while (reader.Read())
            {
                AccessProperty eventlist = new AccessProperty();
                eventlist.ID = (int)reader["Id"];
                eventlist.EventsName = Convert.ToString(reader["eventName"]);
                eventlist.Des = Convert.ToString(reader["description"]);
                eventlist.DateCreate = Convert.ToString(reader["dateOfCreate"]);
                eventlist.ChangeDate = Convert.ToString(reader["dateOfChange"]);
                eventlist.IMPORTANT = Convert.ToString(reader["importance"]);

                eventlist.Image = Convert.ToString(reader["photo"]);




                EL.Add(eventlist);

            }

            dataGridView1.DataSource = EL;
            connection.Close();

        }
    }
}
