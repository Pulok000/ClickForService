using ClickForService.BusinessLogicLayer;
using ClickForService.DatabaseConnectionLayer;
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
    public partial class MobileServiceProviderDetails : Form
    {
        private GeneralOperations generalOperations;
        private GeneralOperations generalOperations2;
        private AccessPropertySP accessProperty;
        private AccessPropertySP accessProperty2;
        public MobileServiceProviderDetails()
        {
            InitializeComponent();

        }

        private string spUsername;
        public MobileServiceProviderDetails(string spUsername)
        {
            InitializeComponent();
            this.spUsername = spUsername;

            generalOperations = new GeneralOperations();

            accessProperty = generalOperations.GetServiceProviderRegDetails(spUsername);
            fullnametextBox.Text = accessProperty.FullName;
            divisiontextBox.Text = accessProperty.Division;
            citytextBox.Text = accessProperty.City;
            addresstextBox.Text = accessProperty.Address;
            mobilenumbertextBox.Text = accessProperty.MobileNumber;



            generalOperations2 = new GeneralOperations();
            accessProperty2 = generalOperations2.GetServiceProviderAdditionalDetails(spUsername);


            try
            {
                servicechargetextBox.Text = accessProperty2.ServiceCharge.ToString();
                availabilitytextBox.Text = accessProperty2.AvailStime;
            }
            catch (Exception exp)
            {

            }





        }

        private void MobileServiceProviderDetails_Load(object sender, EventArgs e)
        {

        }

        private void updatespdetailsbutton_Click(object sender, EventArgs e)
        {
            MobileServicing mobileServicing = new MobileServicing();
            this.Hide();
            
            


            DialogResult d;

            d = MessageBox.Show("Do you want to Go Back?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                mobileServicing.Show();
            }
            else if (d == DialogResult.No)
            {
                this.Show();
            }
            else
                Close();
        }

        private void MobileServiceProviderDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
