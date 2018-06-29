using NawazEyeWebProject.Models;
using NawazEyeWebProject_AdminPanel.ProjectClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NawazEyeWebProject_AdminPanel.Forms
{
    public partial class ViewSunglasses : Form
    {
        Sunglasses sunglasses;
        List<ImagesViewModel> lstIVM = new List<ImagesViewModel>();
        bool nameTxtChanged = false, descriptionTxtChanged = false, priceTxtChanged = false, quantityValChanged = false, DiscountValChanged = false, frameColorTxtChanged = false, lensColorTxtChanged = false, stopOrderValChanged = false;

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
            catch(Exception ex)
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

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            descriptionTxtChanged = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            nameTxtChanged = true;
        }

        public ViewSunglasses(Sunglasses sunglasses)
        {
            InitializeComponent();
            this.sunglasses = sunglasses;
            lstIVM.Add(new ImagesViewModel { ImageName = sunglasses.PrimaryImage});
            foreach(var item in sunglasses.Images)
            {
                if (item != sunglasses.PrimaryImage)
                {
                    lstIVM.Add(new ImagesViewModel { ImageName = item});
                }
            }

            Reset();
        }
        public void Reset()
        {
            txtDescription.Text = sunglasses.ProductDescription;
            txtFrameColor.Text = sunglasses.FrameColor;
            txtLensColor.Text = sunglasses.LensColor;
            txtName.Text = sunglasses.Name;
            txtPrice.Text = decimal.Round(sunglasses.Price).ToString(); 
            txtProductId.Text = ""+sunglasses.id;
            numDiscount.Value = sunglasses.Discount;
            numQuantity.Value = sunglasses.Quantity;
            BindingSource imagesBinding = new BindingSource();
            imagesBinding.DataSource = lstIVM;
            imageGridView.DataSource = imagesBinding;
            imageGridView.Columns[0].Visible = false;
            imageGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void SetPrimaryImage()
        {
            string imageName = (string)imageGridView.SelectedRows[0].Cells[0].Value;
            sunglasses.SetPrimaryImage(imageName);
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
                sunglasses.Name = txtName.Text;
            }
            if (descriptionTxtChanged)
            {
                sunglasses.ProductDescription = txtDescription.Text;
            }
            if (priceTxtChanged)
            {
                sunglasses.Price = Convert.ToDecimal(txtPrice.Text.Substring(3));
            }
            if (quantityValChanged)
            {
                sunglasses.Quantity = (int)numQuantity.Value;
            }
            if (DiscountValChanged)
            {
                sunglasses.Discount = (int)numDiscount.Value;
            }
            if (frameColorTxtChanged)
            {
                sunglasses.FrameColor = txtFrameColor.Text;
            }
            if (lensColorTxtChanged)
            {
                sunglasses.LensColor = txtLensColor.Text;
            }
        }
    }
    public class ImagesViewModel
    {
        public string ImageName { get; set; }
        public Image ProductImage
        {
            get
            {
                try
                {
                    //This would be changed by the original Image Path on the server by using FTP
                    string imagePath = @"D:\New folder\VS Projects\NawazEyeWebProject\123NawazEyeWebProject\NawazEyeWebProject\images\Uploads\" + ImageName;
                    return Image.FromFile(imagePath);
                }
                catch (FileNotFoundException)
                {
                    return null;
                }
            }
        }
    }
}
