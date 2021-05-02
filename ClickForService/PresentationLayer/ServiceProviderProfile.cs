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
    public partial class ServiceProviderProfile : Form
    {
        private string spUsername;
        private GeneralOperations generalOperations;
        private AccessPropertySP accessProperty;

        public ServiceProviderProfile()
        {
            InitializeComponent();
        }

        public ServiceProviderProfile(string spUsername)
        {
            InitializeComponent();
            this.spUsername = spUsername;

            generalOperations = new GeneralOperations();
            accessProperty = generalOperations.GetServiceProviderRegDetails(spUsername);

            fullnametextBox.Text = accessProperty.UserName;
            EmailtextBox.Text = accessProperty.EmailId;
            passwordtextBox.Text = accessProperty.Password;
            catagorytextBox.Text = accessProperty.Category;
            addresstextBox.Text = accessProperty.Address;
            citytextBox.Text = accessProperty.City;
            divisiontextBox.Text = accessProperty.Division;
            mobiletoextBox.Text = accessProperty.MobileNumber;
            NidtextBox.Text = accessProperty.NID;
            nametextBox.Text = accessProperty.FullName;
            dobtextBox.Text = accessProperty.DOB;
            gendertextBox.Text = accessProperty.Gender;
            professiontextBox.Text = accessProperty.Profession;


        }

        private void ServiceProviderProfile_Load(object sender, EventArgs e)
        {

        }

        private void updatespdetailsbutton_Click(object sender, EventArgs e)
        {
            DashboardforSP dashboardforSP = new DashboardforSP(spUsername);
            this.Hide();
            dashboardforSP.Show();
        }
    }
}
