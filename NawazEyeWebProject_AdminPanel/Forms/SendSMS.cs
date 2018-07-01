using NawazEyeWebProject_AdminPanel.ProjectClasses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NawazEyeWebProject_AdminPanel.Forms
{
    public partial class SendSMS : Form
    {
        List<CustomerContactInfo> customers = new List<CustomerContactInfo>();
        public SendSMS(List<CustomerContactInfo> customers)
        {
            InitializeComponent();
            this.customers = customers;
        }
        private void SendSms(string message, string number)
        {
            //This function will send the sms
        }
        private void SendEmail(string message, string email)
        {
            //This function will send the Email
        }

        private void btnSendSms_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text != "")
            {
                if (txtMessage.Text.Length < 140)
                {
                    string message;
                    try
                    {
                        foreach (var customer in customers)
                        {
                            message = "Dear " + customer.Name + ",\n" + txtMessage.Text + "\nRegrads: Eyeworld Team";
                            SendSms(message, customer.PhoneNumber);
                        }
                        MessageBoxes.Success("SMS(s) sent succesfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBoxes.Error(ex.Message);
                    }
                }
                else
                {
                    MessageBoxes.Error("Messsage Body is too Large.");
                }
            }
            else
            {
                MessageBoxes.Info("Message Body is empty.");
            }
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text != "")
            {
                string message;
                try
                {
                    foreach (var customer in customers)
                    {
                        message = "Dear " + customer.Name + ",\n" + txtMessage.Text + "\n\nRegrads,\nEyeworld Team";
                        SendEmail(message, customer.Email);
                    }
                    MessageBoxes.Success("Email(s) sent succesfully");
                }
                catch (Exception ex)
                {
                    MessageBoxes.Error(ex.Message);
                }
            }
            else
            {
                MessageBoxes.Error("Message Body is empty.");
            }
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            lblCharCount.Text = ""+txtMessage.Text.Length;
            
        }
    }
}
