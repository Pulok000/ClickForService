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
    }
}
