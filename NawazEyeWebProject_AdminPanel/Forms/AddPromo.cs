using NawazEyeWebProject_AdminPanel.ProjectClasses;
using System;
using System.Windows.Forms;
using NawazEyeWebProject.Models;

namespace NawazEyeWebProject_AdminPanel.Forms
{
    public partial class AddPromo : Form
    {
        public AddPromo()
        {
            InitializeComponent();
        }
        private bool Save()
        {
            if (CheckAllRequired())
            {
                PromoCode promo = new PromoCode((int)numDiscount.Value, true); 
                lblCode.Text = "* You have created a new Promo with code: " + promo.Code + "\nand discount: " + numDiscount.Value + "%.";
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Reset()
        {
            numDiscount.Value = 0;
        }
        private bool CheckAllRequired()
        {
            if (numDiscount.Value == 0)
            {
                toolTip.Show("This feild is required", numDiscount);
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
