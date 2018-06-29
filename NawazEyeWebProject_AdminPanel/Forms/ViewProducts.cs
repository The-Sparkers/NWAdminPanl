using NawazEyeWebProject.Models;
using NawazEyeWebProject_AdminPanel.ProjectClasses;
using System;
using System.Windows.Forms;

namespace NawazEyeWebProject_AdminPanel.Forms
{
    public partial class ViewProducts : Form
    {
        public ViewProducts()
        {
            InitializeComponent();
            Reset();
        }
        private void Reset()
        {
            BindingSource productBinding = new BindingSource();
            productBinding.DataSource = Product.SearchProduct("");
            viewProductsGridView.DataSource = productBinding;
            viewProductsGridView.Columns[0].Visible = false;
            viewProductsGridView.Columns[2].Visible = false;
            viewProductsGridView.Columns[8].Visible = false;
            viewProductsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void selectAllBtn_Click(object sender, EventArgs e)
        {
            viewProductsGridView.SelectAll();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (viewProductsGridView.SelectedRows.Count == 0)
            {
                MessageBoxes.Info("No item(s) selected.\nPlease select an item to view.");

            }
            else
            {
                foreach (DataGridViewRow row in viewProductsGridView.SelectedRows)
                {
                    int id = (int)row.Cells[0].Value;
                    if (Product.IsSunglasses(id))
                    {
                        ViewSunglasses vs = new ViewSunglasses(new Sunglasses(id));
                        vs.Show();
                    }
                    else
                    {
                        ViewPrescriptionGlasses vp = new ViewPrescriptionGlasses(new PrescriptionGlasses(id));
                        vp.Show();
                    }
                }
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (viewProductsGridView.SelectedRows.Count == 0)
            {
                MessageBoxes.Info("No item(s) selected.\nPlease select an item to delete.");

            }
            else
            {
                string warningMessage = "Are you sure want to delete " + viewProductsGridView.SelectedRows.Count + "Item(s)?\nThis action can't be overturned.";
                if (MessageBoxes.Warning(warningMessage) == true)
                {
                    foreach (DataGridViewRow row in viewProductsGridView.SelectedRows)
                    {
                        int id = (int)row.Cells[0].Value;
                        Product p = new Product();
                        p.id = id;
                        p.Delete();
                        Reset();
                    }
                    viewProductsGridView.Refresh();
                }
            }
        }
    }
}
