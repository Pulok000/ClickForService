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


            DialogResult d;

            d = MessageBox.Show("Do you want to Go Back?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                houseHoldService.Show();
            }
            else if (d == DialogResult.No)
            {
                this.Show();
            }
            else
                Close();
        }

        private void MobileServicing_Load(object sender, EventArgs e)
        {
            GeneralOperations go = new GeneralOperations();

            List<AccessPropertySP> getComputerServices = go.GetAllMobileServices();

            DataTable dt = new DataTable();

            dt.Columns.Add("Name");
            dt.Columns.Add("Profession");
            dt.Columns.Add("City");
            dt.Columns.Add("Address");




            foreach (var item in getComputerServices)
            {
                var row = dt.NewRow();

                row["Name"] = item.UserName;
                row["Profession"] = item.Profession;
                row["City"] = item.City;
                row["Address"] = item.Address;




                dt.Rows.Add(row);
            }

            mobileservicingdataGridView.DataSource = dt;
        }

        private void mobileservicingdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string spUsername = mobileservicingdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            
            MobileServiceProviderDetails mobileServiceProviderDetails = new MobileServiceProviderDetails(spUsername);

            this.Hide();
            mobileServiceProviderDetails.Show();
        }
    }
}
