using NawazEyeWebProject.Models;
using NawazEyeWebProject_AdminPanel.ProjectClasses;
using System;
using System.Windows.Forms;

namespace NawazEyeWebProject_AdminPanel.Forms
{
    public partial class ViewLens : Form
    {
        public ViewLens()
        {
            InitializeComponent();
            Reset();
        }
        private void Reset()
        {
            try
            {
                BindingSource bindingLens = new BindingSource();
                bindingLens.DataSource = Lens.GetAllLenses();
                dataLens.DataSource = bindingLens;
            }
            catch(Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                AddLens al = new AddLens();
                al.ShowDialog();
                Reset();

            }
            catch (Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Lens l;
                if (dataLens.SelectedRows.Count == 0)
                {
                    MessageBoxes.Info("No item(s) selected.\nPlease select an item to delete.");
                }
                else
                {
                    string warningMessage = "Are you sure want to delete " + dataLens.SelectedRows.Count + "Item(s)?\nThis action can't be overturned.";
                    if (MessageBoxes.Warning(warningMessage) == true)
                    {
                        foreach (DataGridViewRow row in dataLens.SelectedRows)
                        {
                            int id = (int)row.Cells[0].Value;
                            l = new Lens(id);
                            l.Delete();
                        }
                        Reset();
                        dataLens.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }
    }
}
