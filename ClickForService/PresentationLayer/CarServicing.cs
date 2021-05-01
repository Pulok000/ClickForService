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
    public partial class CarServicing : Form
    {
        public CarServicing()
        {
            InitializeComponent();
        }

        private void CarServicing_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CarServicing_Load(object sender, EventArgs e)
        {
            string sql = "SELECT *FROM Registrations WHERE userName='" + Login.UserName + "'";
            AccessProperty ap = new AccessProperty();
            DataAcess da = new DataAcess();
            SqlDataReader reader = da.GetData(sql);
            while (reader.Read())
            {
                textBoxCity.Text = Convert.ToString(reader["City"]);

            }
            da.ConnectionClose();
        }

        int pos;
        SqlDataAdapter sqladp;
        DataTable data = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);

            DataAcess ac = new DataAcess();
            string PF = "Car Mechanic";
            string sql = "SELECT *FROM Registrations WHERE City='" + textBoxCity.Text + "'AND gender='" + comboBox1.Text + "'AND Profession='" + PF + "'";
            sqladp = new SqlDataAdapter(sql, connection);
            sqladp.Fill(data);
            pos = 0;
            displaytext(pos);

        }
        public void displaytext(int rowno)
        {
            textBox2.Text = data.Rows[rowno][10].ToString();
            textBox3.Text = data.Rows[rowno][4].ToString();
            textBox4.Text = data.Rows[rowno][8].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pos = pos - 1;
            if (pos <= data.Rows.Count)
            {
                pos++;
                MessageBox.Show("First Record");
            }
            displaytext(pos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pos = pos + 1;
            if (pos >= data.Rows.Count)
            {
                pos--;
                MessageBox.Show("Last Record");
            }
            displaytext(pos);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            HouseHoldService houseHoldService = new HouseHoldService();
            this.Hide();


            DialogResult d;

            d = MessageBox.Show("Do you want to Go Back?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                houseHoldService.Show();
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

