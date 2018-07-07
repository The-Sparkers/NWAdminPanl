using NawazEyeWebProject_AdminPanel.ProjectClasses;
using System;
using System.Windows.Forms;

namespace NawazEyeWebProject_AdminPanel.Forms
{
    public partial class DispatchedDetails : Form
    {
        string logisticsServiceProviderName, deliveryCode, maximumDeliveryTime,buyerName;

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtDeliveryCode.Text == "" || txtMaximumDeliveryTime.Text == "" || txtServiceProviderName.Text == "")
            {
                MessageBoxes.Info("No field should be empty.");
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                logisticsServiceProviderName = txtServiceProviderName.Text;
                deliveryCode = txtDeliveryCode.Text;
                maximumDeliveryTime = txtMaximumDeliveryTime.Text;
                string emailBody = "Dear " + buyerName + ",\n\tYour Order has been dispatched. Details:\n\tDelivery Service Provider: " + logisticsServiceProviderName + "\n\t\tDelivery Code: " + deliveryCode + "\n\t\tMaxmium Time: " + maximumDeliveryTime + "\nRegards,\nEyeWorld Team";
                try
                {
                    SendEmail(emailBody);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBoxes.Error(ex.Message);
                    DialogResult = DialogResult.Cancel;
                }
            }
        }

        public DispatchedDetails(string buyerName)
        {
            InitializeComponent();
            this.buyerName = buyerName;
        }
        private void SendEmail(string body)
        {
            //To be implemented further to send email
        }
    }
}
