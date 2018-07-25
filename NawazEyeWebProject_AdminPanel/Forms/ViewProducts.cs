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
            try
            {
                BindingSource productBinding = new BindingSource();
                productBinding.DataSource = Product.SearchProduct("");
                viewProductsGridView.DataSource = productBinding;
                viewProductsGridView.Columns[0].Visible = false;
                viewProductsGridView.Columns[2].Visible = false;
                viewProductsGridView.Columns[8].Visible = false;
                viewProductsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
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
                        try
                        {
                            int id = (int)row.Cells[0].Value;
                            Product p = new Product();
                            p.id = id;
                            p.Delete();
                            Reset();
                        }
                        catch (Exception ex)
                        {
                            MessageBoxes.Error(ex.Message);
                        }
                    }
                    viewProductsGridView.Refresh();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddProduct ap = new AddProduct();
                ap.Show();
                ap.FormClosed += Ap_FormClosed;
            }
            catch (Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }

        private void Ap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Reset();
        }

        private void btnViewFrames_Click(object sender, EventArgs e)
        {
            try
            {
                ViewFrames vf = new ViewFrames();
                vf.Show();
            }
            catch (Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }

        private void btnViewLens_Click(object sender, EventArgs e)
        {
            try
            {
                ViewLens vl = new ViewLens();
                vl.Show();
            }
            catch (Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }

        private void btnViewPromos_Click(object sender, EventArgs e)
        {
            try
            {
                ViewPromos vp = new ViewPromos();
                vp.Show();
            }
            catch (Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                ViewCustomers vc = new ViewCustomers();
                vc.Show();
            }
            catch (Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            try
            {
                ViewOrders vo = new Forms.ViewOrders();
                vo.Show();
            }
            catch (Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }
    }
}
