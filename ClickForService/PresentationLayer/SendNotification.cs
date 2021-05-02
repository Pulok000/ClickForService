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
using Tulpep.NotificationWindow;

namespace ClickForService.PresentationLayer
{
    public partial class SendNotification : Form
    {
 

        public SendNotification()
        {
            InitializeComponent();
        }

        public static void Nf()
        {
        }
        
        public static string ab;

        public void notification()
        {
            
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.ib;
            popup.ContentText = textBox1.Text;
            //textBox1.Text = "";
            ab = textBox1.Text;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);

            connection.Open();

            string sql1 = "SELECT *FROM userpermissions WHERE (uniqueCode='" + "AD" + "' AND uniqueCode='" + "ST" + "' OR uniqueCode='" + "GU" + "' OR uniqueCode='" + "" + "')";
            SqlCommand command = new SqlCommand(sql1, connection);
            SqlDataReader reader = command.ExecuteReader();


            textBox1.Text = "";

            if (reader.Read())
            {
                popup.Popup();
                    
                connection.Close();

            }
            else
            {

                MessageBox.Show("Sorry! There is No User Found");
                connection.Close();
            }

             

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            notification();
            
           
        }

        public static void ABC()
        {
            SendNotification SN = new SendNotification();
            SN.notification();
        }
        private void SendNotification_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void updatespdetailsbutton_Click(object sender, EventArgs e)
        {
            DashboardforAdmin dashboardforAdmin = new DashboardforAdmin();
            this.Hide();




            DialogResult d;

            d = MessageBox.Show("Do you want to Go Back?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                dashboardforAdmin.Show();
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
