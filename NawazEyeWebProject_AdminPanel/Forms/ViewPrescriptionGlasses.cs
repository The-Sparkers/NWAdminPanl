using NawazEyeWebProject.Models;
using NawazEyeWebProject_AdminPanel.ProjectClasses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NawazEyeWebProject_AdminPanel.Forms
{
    public partial class ViewPrescriptionGlasses : Form
    {
        PrescriptionGlasses prescriptionGlasses;
        List<ImagesViewModel> lstIVM = new List<ImagesViewModel>();
        bool frametxtChanged=false, nameTxtChanged = false, descriptionTxtChanged = false, priceTxtChanged = false, quantityValChanged = false, DiscountValChanged = false, frameColorTxtChanged = false, lensColorTxtChanged = false, stopOrderValChanged = false;

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            quantityValChanged = true;
        }

        private void numDiscount_ValueChanged(object sender, EventArgs e)
        {
            DiscountValChanged = true;
        }

        private void txtFrameColor_TextChanged(object sender, EventArgs e)
        {
            frameColorTxtChanged = true;
        }

        private void txtLensColor_TextChanged(object sender, EventArgs e)
        {
            lensColorTxtChanged = true;
        }

        private void chkStopOrder_Click(object sender, EventArgs e)
        {
            stopOrderValChanged = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
                MessageBoxes.Success("Record saved successfully.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            priceTxtChanged = true;
        }

        private void comboFrames_SelectedIndexChanged(object sender, EventArgs e)
        {
            frametxtChanged = true;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            descriptionTxtChanged = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            nameTxtChanged = true;
        }
        public ViewPrescriptionGlasses(PrescriptionGlasses prescriptionglass)
        {
            try
            {
                InitializeComponent();
                prescriptionGlasses = prescriptionglass;
                lstIVM.Add(new ImagesViewModel { ImageName = prescriptionGlasses.PrimaryImage });
                foreach (var item in prescriptionGlasses.Images)
                {
                    if (item != prescriptionGlasses.PrimaryImage)
                    {
                        lstIVM.Add(new ImagesViewModel { ImageName = item });
                    }
                }
                Reset();
            }
            catch(Exception ex)
            {
                MessageBoxes.Error(ex.Message);
            }
        }
        public void Reset()
        {
            txtDescription.Text = prescriptionGlasses.ProductDescription;
            txtFrameColor.Text = prescriptionGlasses.FrameColor;
            txtName.Text = prescriptionGlasses.Name;
            txtPrice.Text = decimal.Round(prescriptionGlasses.Price).ToString();
            txtProductId.Text = "" + prescriptionGlasses.id;
            numDiscount.Value = prescriptionGlasses.Discount;
            numQuantity.Value = prescriptionGlasses.Quantity;
            chkStopOrder.Checked = prescriptionGlasses.StopOrder;
            BindingSource imagesBinding = new BindingSource();
            imagesBinding.DataSource = lstIVM;
            imageGridView.DataSource = imagesBinding;
            imageGridView.Columns[0].Visible = false;
            imageGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BindingSource frameBinding = new BindingSource();
            BindingSource lensBinding = new BindingSource();
            frameBinding.DataSource = Frame.GetAllFrames();
            lensBinding.DataSource = Lens.GetAllLenses();
            comboFrames.DataSource = frameBinding;
            comboFrames.DisplayMember = "FrameName";
            comboFrames.ValueMember = "FrameId";
            comboFrames.Text = prescriptionGlasses.Frame.FrameName;
            comboLens.DataSource = lensBinding;
            comboLens.DisplayMember = "LensName";
            comboLens.ValueMember = "LensId";
            comboLens.Text = prescriptionGlasses.Lens.LensName;
        }
        public void SetPrimaryImage()
        {
            string imageName = (string)imageGridView.SelectedRows[0].Cells[0].Value;
            prescriptionGlasses.SetPrimaryImage(imageName);
        }

        private void btnSetPrimary_Click(object sender, EventArgs e)
        {
            SetPrimaryImage();
            MessageBoxes.Success("Image Set as the primary");
            Reset();
        }
        private void Save()
        {
            if (nameTxtChanged)
            {
                prescriptionGlasses.Name = txtName.Text;
            }
            if (descriptionTxtChanged)
            {
                prescriptionGlasses.ProductDescription = txtDescription.Text;
            }
            if (priceTxtChanged)
            {
                prescriptionGlasses.Price = Convert.ToDecimal(txtPrice.Text.Substring(3));
            }
            if (quantityValChanged)
            {
                prescriptionGlasses.Quantity = (int)numQuantity.Value;
            }
            if (DiscountValChanged)
            {
                prescriptionGlasses.Discount = (int)numDiscount.Value;
            }
            if (frameColorTxtChanged)
            {
                prescriptionGlasses.FrameColor = txtFrameColor.Text;
            }
            if (stopOrderValChanged)
            {
                prescriptionGlasses.StopOrder = chkStopOrder.Checked;
            }
            if (lensColorTxtChanged)
            {
                prescriptionGlasses.Lens = new Lens((int)comboLens.SelectedValue);
            }
            if (frametxtChanged)
            {
                prescriptionGlasses.Frame = new Frame((int)comboLens.SelectedValue);
            }
        }
    }

}
