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
    public partial class MaidService : Form
    {
        public MaidService()
        {
            InitializeComponent();
        }

        private void MaidService_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.CanSelect)
            {
                buttonsearch.Enabled = true;
            }
            else buttonsearch.Enabled = false;
        }
    }
}
