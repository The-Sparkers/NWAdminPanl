using NawazEyeWebProject.Models;
using NawazEyeWebProject_AdminPanel.ProjectClasses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NawazEyeWebProject_AdminPanel.Forms
{
    public partial class ViewCustomers : Form
    {
        List<CustomersViewModel> customersData;
        bool haveAccount = false;
        public ViewCustomers()
        {
            InitializeComponent();
            Reset();
            dataCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        public void Reset()
        {
            try
            {
                customersData = new List<CustomersViewModel>();
                foreach (var buyer in Buyer.GetAllBuyers())
                {
                    if (buyer.GetAccount() != null)
                    {
                        haveAccount = true;
                    }
                    CustomersViewModel c = new CustomersViewModel();

                    c.BuyerId = buyer.BuyerId;
                    c.Name = buyer.Name;
                    c.Email = buyer.Email;
                    c.PhoneNumber = buyer.PhoneNumber;
                    c.City = buyer.City.Name;
                    c.HaveAccount = haveAccount;
                    if (buyer.GetAccount() != null)
                    {
                        c.UserName = buyer.GetAccount().Username;
                        c.AccountBlocked = buyer.GetAccount().IsBlocked;
                        c.Orders = buyer.GetAccount().GetNumberOfOrders();
                    }
                    else
                    {
                        c.UserName = "";
                        c.AccountBlocked = false;
                        c.Orders = 0;
                    }
                    
                    customersData.Add(c);
                }
                BindingSource custBinding = new BindingSource();
                custBinding.DataSource = customersData;
                dataCustomers.DataSource = custBinding;
            }
            catch(Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            dataCustomers.SelectAll();
        }

        private void btnDisableAcnt_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow customer in dataCustomers.SelectedRows)
                {
                    Account a = new Account((int)customer.Cells[0].Value);
                    a.IsBlocked = true;
                }
                Reset();
            }
            catch(Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }

        private void btnEnAcnt_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow customer in dataCustomers.SelectedRows)
                {
                    Account a = new Account((int)customer.Cells[0].Value);
                    a.IsBlocked = false;
                }
                Reset();
            }
            catch (Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }

        private void btnSndSMS_Click(object sender, EventArgs e)
        {
            if (dataCustomers.SelectedRows.Count > 0)
            {
                List<CustomerContactInfo> l = new List<CustomerContactInfo>();
                foreach (DataGridViewRow row in dataCustomers.SelectedRows)
                {
                    l.Add(new CustomerContactInfo() { Name = (string)row.Cells[1].Value, Email = (string)row.Cells[2].Value, PhoneNumber = (string)row.Cells[3].Value });
                }
                SendSMS sendSMS = new SendSMS(l); 
                sendSMS.ShowDialog();
            }
            else
            {
                MessageBoxes.Info("No row(s) selected.");
            }
        }
        
    }
    public class CustomersViewModel
    {
        public int BuyerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public bool HaveAccount { get; set; }
        public string UserName { get; set; }  
        public bool AccountBlocked { get; set; }
        public int Orders { get; set; }
    }
    public class CustomerContactInfo
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
