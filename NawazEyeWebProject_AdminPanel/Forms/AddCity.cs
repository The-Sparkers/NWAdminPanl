using NawazEyeWebProject.Models;
using NawazEyeWebProject_AdminPanel.ProjectClasses;
using System;
using System.Windows.Forms;

namespace NawazEyeWebProject_AdminPanel.Forms
{
    public partial class AddCity : Form
    {
        public AddCity()
        {
            InitializeComponent();
        }
        private bool Save()
        {
            if (CheckAllRequired())
            {
                decimal d = Convert.ToDecimal(txtDelCharges.Text.Substring(3));
                City city = new City(txtName.Text, d);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Reset()
        {
            txtName.Text = "";
            txtDelCharges.Text = "";
        }
        private bool CheckAllRequired()
        {
            if (txtName.Text == "")
            {
                toolTip.Show("This feild is required", txtName);
                return false;
            }
            if (txtDelCharges.Text == "RS.")
            {
                toolTip.Show("This feild is required", txtDelCharges);
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Save())
                {
                    Reset();
                    MessageBoxes.Success("Record Added Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }
    }
}
