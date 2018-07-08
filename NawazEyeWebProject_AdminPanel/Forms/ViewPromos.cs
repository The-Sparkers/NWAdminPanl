using NawazEyeWebProject.Models;
using NawazEyeWebProject_AdminPanel.ProjectClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NawazEyeWebProject_AdminPanel.Forms
{
    public partial class ViewPromos : Form
    {
        public ViewPromos()
        {
            InitializeComponent();
            Reset();
        }
        private void Reset()
        {
            try
            {
                BindingSource bindingPromos = new BindingSource();
                bindingPromos.DataSource = PromoCode.GetAllPromos();
                dataPromos.DataSource = bindingPromos;
            }
            catch(Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                PromoCode p;
                if ((int)dataPromos.SelectedRows[0].Cells[0].Value != 6)
                {
                    if (dataPromos.SelectedRows.Count == 0)
                    {
                        MessageBoxes.Info("No item(s) selected.\nPlease select an item to delete.");
                    }
                    else
                    {
                        string warningMessage = "Are you sure want to delete " + dataPromos.SelectedRows.Count + "Item(s)?\nThis action can't be overturned.";
                        if (MessageBoxes.Warning(warningMessage) == true)
                        {
                            p = new PromoCode((int)dataPromos.SelectedRows[0].Cells[0].Value);
                            p.Delete();
                            Reset();
                            dataPromos.Refresh();
                        }
                    }
                }
                else
                {
                    MessageBoxes.Info("The Promo Code you have chosen is the default code and cannot be deleted.");
                }
            }
            catch (Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                AddPromo ap = new AddPromo();
                if (ap.ShowDialog() == DialogResult.OK)
                {
                    Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }

        }
    }
}
