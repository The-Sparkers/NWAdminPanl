using NawazEyeWebProject.Models;
using NawazEyeWebProject_AdminPanel.ProjectClasses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NawazEyeWebProject_AdminPanel.Forms
{
    public partial class ViewOrders : Form
    {
        BindingSource orderBinding = new BindingSource();
        public ViewOrders()
        {
            InitializeComponent();
            Reset("");
        }
        private void Reset(string status, int id=0)
        {
            if (id == 0)
            {
                orderBinding.DataSource = Order.Search(status);
                dataOrders.DataSource = orderBinding;
            }
            else if (id > 0)
            {
                Order order = new Order(id);
                List<Order> o = new List<Order>();
                o.Add(order);
                orderBinding.DataSource = o;
                dataOrders.DataSource = orderBinding;
            }
            dataOrders.Columns[4].Visible = false;
            dataOrders.Columns[5].Visible = false;
        }
        private void FilterValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioAll.Checked)
                {
                    Reset("", Convert.ToInt32(txtSearch.Text));
                }
                else if (radioDelivered.Checked)
                {
                    Reset("DISPATCHED", Convert.ToInt32(txtSearch.Text));
                }
                else if (radioInProgress.Checked)
                {
                    Reset("IN PROGRESS", Convert.ToInt32(txtSearch.Text));
                }
                else if (radioPending.Checked)
                {
                    Reset("PENDING", Convert.ToInt32(txtSearch.Text));
                }
            }
            catch (FormatException)
            {
                txtSearch.Text = 0.ToString(); 
            }
            catch(Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (dataOrders.SelectedRows.Count > 0)
            {
                try
                {
                    int id = (int)dataOrders.SelectedRows[0].Cells[0].Value;
                    ViewOrderDetails vod = new ViewOrderDetails(new Order(id));
                    vod.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBoxes.Error(ex.Message);
                }
            }
            else
            {
                MessageBoxes.Info("No row(s) selected.");
            }
        }
    }
}
