using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        
        private void button1_Click(object sender, EventArgs e)
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.ib;
            popup.ContentText = textBox1.Text;
            textBox1.Text = "";

            popup.Popup();
        }

        private void SendNotification_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
