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
    public partial class DashboardforAdmin : Form
    {
        public DashboardforAdmin()
        {
            InitializeComponent();
        }

        private void DashboardforAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void DashboardforAdmin_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            UserList UL = new UserList();
            this.Hide();
            UL.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BlockUser BU = new BlockUser();
            this.Hide();
            BU.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RegistrationforAdmin RFA = new RegistrationforAdmin();
            this.Hide();
            RFA.Show();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ServicePList SPL = new ServicePList();
            this.Hide();
            SPL.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminList AL = new AdminList();
            this.Hide();
            AL.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminMyProfile AMP = new AdminMyProfile();
            this.Hide();
            AMP.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserProfileInAdmin UPA = new UserProfileInAdmin();
            this.Hide();
            UPA.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SendNotification SN = new SendNotification();
            this.Hide();
            SN.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            this.Hide();


            DialogResult d;

            d = MessageBox.Show("Do you want to LOGOUT?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                login.Show();
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
