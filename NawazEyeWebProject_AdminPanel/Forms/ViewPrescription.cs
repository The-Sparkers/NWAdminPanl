using NawazEyeWebProject_AdminPanel.ProjectClasses;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NawazEyeWebProject_AdminPanel.Forms
{
    public partial class ViewPrescription : Form
    {
        public ViewPrescription(string path, int id)
        {
            InitializeComponent();
            try
            {
                txtId.Text = id.ToString();
                picturePrescription.Image = Image.FromFile(path);
            }
            catch(Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }
    }
}
