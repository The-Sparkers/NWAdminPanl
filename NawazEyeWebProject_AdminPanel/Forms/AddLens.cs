using NawazEyeWebProject.Models;
using NawazEyeWebProject_AdminPanel.ProjectClasses;
using System;
using System.Windows.Forms;

namespace NawazEyeWebProject_AdminPanel.Forms
{
    public partial class AddLens : Form
    {
        public AddLens()
        {
            InitializeComponent();
        }
        private bool Save()
        {
            if (CheckAllRequired())
            {
                Lens lens = new Lens(txtName.Text);
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
        }
        private bool CheckAllRequired()
        {
            if (txtName.Text == "")
            {
                toolTip.Show("This feild is required", txtName);
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
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }
    }
}
