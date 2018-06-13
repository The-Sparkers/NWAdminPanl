using NawazEyeWebProject.Models;
using NawazEyeWebProject_AdminPanel.ProjectClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace NawazEyeWebProject_AdminPanel
{
    public partial class AddProduct : Form
    {
        List<FileInfo> fileNames = new List<FileInfo>();
        public AddProduct()
        {
            
            InitializeComponent();
            BindingSource bindFrames = new BindingSource();
            bindFrames.DataSource = Frame.GetAllFrames();
            comboFrames.DataSource = bindFrames;
            comboFrames.ValueMember = "FrameId";
            comboFrames.DisplayMember = "FrameName";
            BindingSource bindLens = new BindingSource();
            bindLens.DataSource = Lens.GetAllLenses();
            comboLens.DataSource = bindLens;
            comboLens.DisplayMember = "LensName";
            comboLens.ValueMember = "LensId";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioSunglasses_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSunglasses.Checked)
            {
                txtLensColor.Visible = true;
                lblLensColor.Visible = true;
                lblFrameName.Visible = false;
                lblLensName.Visible = false;
                comboFrames.Visible = false;
                comboLens.Visible = false;
            }
            else
            {
                txtLensColor.Visible = false;
                lblLensColor.Visible = false;
                lblFrameName.Visible = true;
                lblLensName.Visible = true;
                comboFrames.Visible = true;
                comboLens.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Save())
                {
                    MessageBoxes.Success("Record added succesfully");
                    Reset();
                }
            }
            catch(Exception ex)
            {
                MessageBoxes.Error(ex.Message); 
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtDescription.Text = null;
            txtFrameColor.Text = null;
            txtLensColor.Text = null;
            txtName.Text = null;
            txtPrice.Text = null;
            numDiscount.Value = 0;
            numQuantity.Value = 0;
            chkStopOrder.SetItemCheckState(0, CheckState.Unchecked);
            flowImages.Controls.Clear();
        }

        private Control CreateImageControl(string imagePath)
        {
            FileInfo fileInfo = new FileInfo(imagePath);
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(imagePath);
            pictureBox.Width = 200;
            pictureBox.Height = 150;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            fileNames.Add(fileInfo);
            return pictureBox;
        }

        private void btnAddImages_Click(object sender, EventArgs e)
        {
            flowImages.Dock = DockStyle.None;
            flowImages.FlowDirection = FlowDirection.LeftToRight;
            flowImages.AutoScroll = true;
            flowImages.WrapContents = true;
            OpenFileDialog oFDialog = new OpenFileDialog();
            oFDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            oFDialog.Multiselect = true;
            oFDialog.Title = "Choose Images";
            if (oFDialog.ShowDialog() == DialogResult.OK)
            {
                foreach(var file in oFDialog.FileNames)
                {
                    flowImages.Controls.Add(CreateImageControl(file));
                }
            }
        }
        private bool Save()
        {
            if (CheckAllRequired() && radioSunglasses.Checked)
            {
                decimal price = Convert.ToDecimal(txtPrice.Text.Substring(3));
                bool stopO=false;
                if (chkStopOrder.GetItemChecked(0))
                {
                    stopO = true;
                }
                string s = "";
                Sunglasses sunglasses = new Sunglasses(txtName.Text, price, (int)numQuantity.Value, (int)numDiscount.Value, txtFrameColor.Text, txtDescription.Text, stopO, txtLensColor.Text);
                foreach (FileInfo item in fileNames)
                {
                    s = UploadImageToFTP(item, sunglasses.ProductId);
                    sunglasses.AddImage(s);
                }
                sunglasses.SetPrimaryImage(s);
                return true;
            }
            else if (CheckAllRequired() && radioPrescriptionGlasses.Checked)
            {
                decimal price = Convert.ToDecimal(txtPrice.Text.Substring(3));
                bool stopO = false;
                if (chkStopOrder.GetItemChecked(0))
                {
                    stopO = true;
                }
                string s = "";
                PrescriptionGlasses prescrptionGlasses = new PrescriptionGlasses(txtName.Text, price, (int)numDiscount.Value, (int)numQuantity.Value, txtFrameColor.Text, txtDescription.Text, stopO, new Lens((int)comboLens.SelectedValue), new Frame((int)comboFrames.SelectedValue)); 
                foreach (FileInfo item in fileNames)
                {
                    s = UploadImageToFTP(item, prescrptionGlasses.ProductId);
                    prescrptionGlasses.AddImage(s);
                }
                prescrptionGlasses.SetPrimaryImage(s);
                return true;
            }
            return false;
        }

        private string UploadImageToFTP(FileInfo item, int productId)
        {
            string serverFileName = productId + "_" + item.Name;
            //Use This Code when Website will be on Some Server
            /*try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("{0}/{1}", "ServerAddress", serverFileName)));
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("Username", "Password");
                Stream ftpStream = request.GetRequestStream();
                FileStream file = File.OpenRead(item.FullName);
                file.CopyTo(ftpStream);
                file.Close();
                ftpStream.Close();
                return serverFileName;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Connecting to the Server......");
            }*/
            //the code below will be removed in order to run the FTP code
            File.Copy(item.FullName, @"D:\New folder\VS Projects\NawazEyeWebProject\123NawazEyeWebProject\NawazEyeWebProject\images\Uploads\" + serverFileName, true);
            return serverFileName;
        }

        private bool CheckAllRequired()
        {
            if(txtDescription.Text=="")
            {
                toolTip.Show("This feild is required", txtDescription);
                return false;
            }
            if (txtFrameColor.Text == "")
            {
                toolTip.Show("This feild is required", txtFrameColor);
                return false;
            }
            if ( radioSunglasses.Checked && txtLensColor.Text == "")
            {
                toolTip.Show("This feild is required", txtLensColor);
                return false;
            }
            if (txtName.Text == "")
            {
                toolTip.Show("This feild is required", txtName);
                return false;
            }
            if (txtPrice.Text == "")
            {
                toolTip.Show("This feild is required", txtPrice);
                return false;
            }
            return true;
        }
    }
}
