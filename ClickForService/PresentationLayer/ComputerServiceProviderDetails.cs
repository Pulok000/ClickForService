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
    public partial class ComputerServiceProviderDetails : Form
    {
        private GeneralOperations generalOperations;
        private GeneralOperations generalOperations2;
        private AccessProperty accessProperty;
        private AccessProperty accessProperty2;

        private string spUserName;
        public ComputerServiceProviderDetails()
        {
            InitializeComponent();
        }

        public ComputerServiceProviderDetails(string spUserName)
        {
            InitializeComponent();
            this.spUserName = spUserName;

            generalOperations = new GeneralOperations();

            accessProperty = generalOperations.GetServiceProviderRegDetails(spUserName);
            fullnametextBox.Text = accessProperty.FullName;
            divisiontextBox.Text = accessProperty.Division;
            citytextBox.Text = accessProperty.City;
            addresstextBox.Text = accessProperty.Address;
            mobilenumbertextBox.Text = accessProperty.MobileNumber;



            generalOperations2 = new GeneralOperations();
            accessProperty2 = generalOperations2.GetServiceProviderAdditionalDetails(spUserName);


            try
            {
                servicechargetextBox.Text = accessProperty2.ServiceCharge.ToString();
                availabilitytextBox.Text = accessProperty2.AvailStime;
            }
            catch (Exception exp)
            {

            }





        }

        private void updatespdetailsbutton_Click(object sender, EventArgs e)
        {
            ComputerServcing computerServcing = new ComputerServcing();
            this.Hide();
            computerServcing.Show();
        }

        private void ComputerServiceProviderDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ComputerServiceProviderDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
