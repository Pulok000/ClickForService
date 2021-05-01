using ClickForService.BusinessLogicLayer;
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
    public partial class AddServiceProviderDetails : Form
    {

        private string spUserName;
        public AddServiceProviderDetails()
        {
            InitializeComponent();
        }

        public AddServiceProviderDetails(string spUserName)
        {
            InitializeComponent();
            this.spUserName = spUserName;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DashboardforSP dsp = new DashboardforSP(spUserName);
            this.Hide();
            dsp.Show();
        }

        private void AddServiceProviderDetails_Load(object sender, EventArgs e)
        {

        }

        private void Registerformbutton_Click(object sender, EventArgs e)
        {
            double serviceCharge = Convert.ToDouble(NameregistertextBox.Text);
            string availableTime = fromtimetextBox.Text + " " + fromtimecomboBox.Text + "-" + totimetextBox.Text + " " + totimecomboBox.Text;
            GeneralOperations generalOperations = new GeneralOperations();

            int result = generalOperations.AddServiceProviderDetails(spUserName, serviceCharge, availableTime);

            if (result > 0)
            {
                MessageBox.Show("Details Added successfully !!");
                DashboardforSP dashboardforSP = new DashboardforSP(spUserName);
                this.Hide();
                dashboardforSP.Show();
                //UpdateListOfProducts();
            }
            else
            {
                MessageBox.Show("Error in adding.");
            }

        }
    }
}
