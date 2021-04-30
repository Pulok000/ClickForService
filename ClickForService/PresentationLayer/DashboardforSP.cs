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
    public partial class DashboardforSP : Form
    {
        public DashboardforSP()
        {
            InitializeComponent();
        }

        private void DashboardforSP_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
