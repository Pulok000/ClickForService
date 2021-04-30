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
    public partial class MobileServicing : Form
    {
        public MobileServicing()
        {
            InitializeComponent();
        }

        private void MobileServicing_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MobileServicing_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mobileservcingbackbutton_Click(object sender, EventArgs e)
        {
            HouseHoldService houseHoldService = new HouseHoldService();
            this.Hide();
            houseHoldService.Show();
        }
    }
}
