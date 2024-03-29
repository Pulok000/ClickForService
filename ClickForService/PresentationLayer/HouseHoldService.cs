﻿using System;
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
    public partial class HouseHoldService : Form
    {
        public HouseHoldService()
        {
            InitializeComponent();
        }

        private void HouseHoldService_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaid_Click(object sender, EventArgs e)
        {
            MaidService ms = new MaidService();
            this.Hide();
            ms.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ComputerServcing computerServcing = new ComputerServcing();
            this.Hide();
            computerServcing.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MobileServicing mobileServicing = new MobileServicing();
            this.Hide();
            mobileServicing.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ACServicing acs = new ACServicing();
            this.Hide();
            acs.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();


            DialogResult d;

            d = MessageBox.Show("Do you want to Go Back?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                dashboard.Show();
            }
            else if (d == DialogResult.No)
            {
                this.Show();
            }
            else
                Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CarServicing carServicing = new CarServicing();
            this.Hide();
            carServicing.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FridgeServicing fridgeServicing = new FridgeServicing();
            this.Hide();
            fridgeServicing.Show();
        }
    }
}
