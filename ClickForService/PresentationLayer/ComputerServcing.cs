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
    public partial class ComputerServcing : Form
    {
        public ComputerServcing()
        {
            InitializeComponent();
        }

        private void ComputerServcing_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mobileservcingbackbutton_Click(object sender, EventArgs e)
        {
            HouseHoldService houseHoldService = new HouseHoldService();
            this.Hide();
            houseHoldService.Show();
        }

        private void ComputerServcing_Load(object sender, EventArgs e)
        {
            GeneralOperations go = new GeneralOperations();

            List<AccessProperty> getComputerServices = go.GetAllComputerServices();

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

            computerservicingdataGridView.DataSource = dt;
        }

        private void computerservicingdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string spUsername = computerservicingdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            
            ComputerServiceProviderDetails showComputerServiceDetails = new ComputerServiceProviderDetails(spUsername);

            this.Hide();
            showComputerServiceDetails.Show();
        }

        private void advancesearchcpmputerservicelabel_Click(object sender, EventArgs e)
        {

        }
    }
}
