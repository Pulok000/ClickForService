using ClickForService.BusinessLogicLayer;
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
    public partial class MaidService : Form
    {
       
        int pos;
        SqlDataAdapter sqladp;
        DataTable data = new DataTable();

        public MaidService()
        {
            InitializeComponent();

            buttonSearchbyC.Click += new System.EventHandler(ClickedButton);
        }

        private void MaidService_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);

            DataAcess ac = new DataAcess();
            string sql = "SELECT *FROM Registrations WHERE City='" + textBox1.Text + "'AND Profession='" + comboBox1.Text + "'";
            sqladp = new SqlDataAdapter(sql, connection);
            sqladp.Fill(data);
            pos = 0;
            displaytext(pos);

        } 
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            HouseHoldService hs = new HouseHoldService();
            this.Hide();
            hs.Show();
        }

        private void MaidService_Load(object sender, EventArgs e)
        {
            string sql = "SELECT *FROM Registrations WHERE userName='" + Login.UserName + "'";
            AccessProperty ap = new AccessProperty();
            DataAcess da = new DataAcess();
            SqlDataReader reader = da.GetData(sql);
            while (reader.Read())
            {
                textBox1.Text = Convert.ToString(reader["City"]);
                GeneralOperations go = new GeneralOperations();
                dataGridView1.DataSource = go.GetMaid();

            }
            da.ConnectionClose();

            
        }

        public void displaytext(int rowno)
        {
            textBox2.Text = data.Rows[rowno][10].ToString();
            textBox3.Text = data.Rows[rowno][4].ToString();
            textBox4.Text = data.Rows[rowno][8].ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pos = pos+1;
            if(pos>=data.Rows.Count)
            {
                pos--;
                MessageBox.Show("Last Record");
            }
            displaytext(pos);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

         }

        private void button3_Click(object sender, EventArgs e)
        {
            pos = pos - 1;
            if (pos == data.Rows.Count)
            {
                
                MessageBox.Show("First Record");
            }
            displaytext(pos);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        public void ClickedButton(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }
        
    }
}
