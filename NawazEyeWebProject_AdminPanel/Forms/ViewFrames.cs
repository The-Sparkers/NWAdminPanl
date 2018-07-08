using NawazEyeWebProject.Models;
using NawazEyeWebProject_AdminPanel.ProjectClasses;
using System;
using System.Windows.Forms;

namespace NawazEyeWebProject_AdminPanel.Forms
{
    public partial class ViewFrames : Form
    {
        public ViewFrames()
        {
            InitializeComponent();
            Reset();
        }
        private void Reset()
        {
            BindingSource bindingFrames = new BindingSource();
            bindingFrames.DataSource = Frame.GetAllFrames();
            dataFrames.DataSource = bindingFrames;

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                AddFrames af = new AddFrames();
                if (af.ShowDialog() == DialogResult.OK)
                {
                    Reset();
                }
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
                Frame f;
                if (dataFrames.SelectedRows.Count == 0)
                {
                    MessageBoxes.Info("No item(s) selected.\nPlease select an item to delete.");
                }
                else
                {
                    string warningMessage = "Are you sure want to delete " + dataFrames.SelectedRows.Count + "Item(s)?\nThis action can't be overturned.";
                    if (MessageBoxes.Warning(warningMessage) == true)
                    {
                        foreach (DataGridViewRow row in dataFrames.SelectedRows)
                        {
                            int id = (int)row.Cells[0].Value;
                            f = new Frame(id);
                            f.Delete();
                        }
                        Reset();
                        dataFrames.Refresh();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }
    }
}
