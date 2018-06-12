namespace NawazEyeWebProject_AdminPanel
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFrameColor = new System.Windows.Forms.TextBox();
            this.CategoryGroup = new System.Windows.Forms.GroupBox();
            this.radioSunglasses = new System.Windows.Forms.RadioButton();
            this.radioPrescriptionGlasses = new System.Windows.Forms.RadioButton();
            this.btnAddImages = new System.Windows.Forms.Button();
            this.flowImages = new System.Windows.Forms.FlowLayoutPanel();
            this.chkStopOrder = new System.Windows.Forms.CheckedListBox();
            this.lblLensColor = new System.Windows.Forms.Label();
            this.txtLensColor = new System.Windows.Forms.TextBox();
            this.lblFrameName = new System.Windows.Forms.Label();
            this.lblLensName = new System.Windows.Forms.Label();
            this.comboFrames = new System.Windows.Forms.ComboBox();
            this.comboLens = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.CategoryGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsReturn = true;
            this.txtDescription.AcceptsTab = true;
            this.txtDescription.Location = new System.Drawing.Point(85, 60);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(246, 141);
            this.txtDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.BeepOnError = true;
            this.txtPrice.Location = new System.Drawing.Point(85, 214);
            this.txtPrice.Mask = "RS. 0000000000000";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity:";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(85, 253);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 20);
            this.numQuantity.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Discount (%):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "FrameColor:";
            // 
            // txtFrameColor
            // 
            this.txtFrameColor.Location = new System.Drawing.Point(85, 330);
            this.txtFrameColor.Name = "txtFrameColor";
            this.txtFrameColor.Size = new System.Drawing.Size(120, 20);
            this.txtFrameColor.TabIndex = 11;
            // 
            // CategoryGroup
            // 
            this.CategoryGroup.Controls.Add(this.radioPrescriptionGlasses);
            this.CategoryGroup.Controls.Add(this.radioSunglasses);
            this.CategoryGroup.Location = new System.Drawing.Point(15, 363);
            this.CategoryGroup.Name = "CategoryGroup";
            this.CategoryGroup.Size = new System.Drawing.Size(200, 86);
            this.CategoryGroup.TabIndex = 12;
            this.CategoryGroup.TabStop = false;
            this.CategoryGroup.Text = "Category";
            // 
            // radioSunglasses
            // 
            this.radioSunglasses.AutoSize = true;
            this.radioSunglasses.Checked = true;
            this.radioSunglasses.Location = new System.Drawing.Point(6, 30);
            this.radioSunglasses.Name = "radioSunglasses";
            this.radioSunglasses.Size = new System.Drawing.Size(79, 17);
            this.radioSunglasses.TabIndex = 0;
            this.radioSunglasses.TabStop = true;
            this.radioSunglasses.Text = "Sunglasses";
            this.radioSunglasses.UseVisualStyleBackColor = true;
            this.radioSunglasses.CheckedChanged += new System.EventHandler(this.radioSunglasses_CheckedChanged);
            // 
            // radioPrescriptionGlasses
            // 
            this.radioPrescriptionGlasses.AutoSize = true;
            this.radioPrescriptionGlasses.Location = new System.Drawing.Point(7, 54);
            this.radioPrescriptionGlasses.Name = "radioPrescriptionGlasses";
            this.radioPrescriptionGlasses.Size = new System.Drawing.Size(120, 17);
            this.radioPrescriptionGlasses.TabIndex = 1;
            this.radioPrescriptionGlasses.Text = "Prescription Glasses";
            this.radioPrescriptionGlasses.UseVisualStyleBackColor = true;
            // 
            // btnAddImages
            // 
            this.btnAddImages.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddImages.Location = new System.Drawing.Point(480, 21);
            this.btnAddImages.Name = "btnAddImages";
            this.btnAddImages.Size = new System.Drawing.Size(75, 23);
            this.btnAddImages.TabIndex = 13;
            this.btnAddImages.Text = "Add Images";
            this.btnAddImages.UseVisualStyleBackColor = true;
            this.btnAddImages.Click += new System.EventHandler(this.btnAddImages_Click);
            // 
            // flowImages
            // 
            this.flowImages.Location = new System.Drawing.Point(480, 51);
            this.flowImages.Name = "flowImages";
            this.flowImages.Size = new System.Drawing.Size(426, 299);
            this.flowImages.TabIndex = 14;
            // 
            // chkStopOrder
            // 
            this.chkStopOrder.FormattingEnabled = true;
            this.chkStopOrder.Items.AddRange(new object[] {
            "Stop Order"});
            this.chkStopOrder.Location = new System.Drawing.Point(15, 455);
            this.chkStopOrder.Name = "chkStopOrder";
            this.chkStopOrder.Size = new System.Drawing.Size(120, 19);
            this.chkStopOrder.TabIndex = 15;
            // 
            // lblLensColor
            // 
            this.lblLensColor.AutoSize = true;
            this.lblLensColor.Location = new System.Drawing.Point(477, 363);
            this.lblLensColor.Name = "lblLensColor";
            this.lblLensColor.Size = new System.Drawing.Size(60, 13);
            this.lblLensColor.TabIndex = 16;
            this.lblLensColor.Text = "Lens Color:";
            // 
            // txtLensColor
            // 
            this.txtLensColor.Location = new System.Drawing.Point(547, 360);
            this.txtLensColor.Name = "txtLensColor";
            this.txtLensColor.Size = new System.Drawing.Size(100, 20);
            this.txtLensColor.TabIndex = 17;
            // 
            // lblFrameName
            // 
            this.lblFrameName.AutoSize = true;
            this.lblFrameName.Location = new System.Drawing.Point(477, 389);
            this.lblFrameName.Name = "lblFrameName";
            this.lblFrameName.Size = new System.Drawing.Size(39, 13);
            this.lblFrameName.TabIndex = 18;
            this.lblFrameName.Text = "Frame:";
            this.lblFrameName.Visible = false;
            // 
            // lblLensName
            // 
            this.lblLensName.AutoSize = true;
            this.lblLensName.Location = new System.Drawing.Point(477, 420);
            this.lblLensName.Name = "lblLensName";
            this.lblLensName.Size = new System.Drawing.Size(33, 13);
            this.lblLensName.TabIndex = 20;
            this.lblLensName.Text = "Lens:";
            this.lblLensName.Visible = false;
            // 
            // comboFrames
            // 
            this.comboFrames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFrames.FormattingEnabled = true;
            this.comboFrames.Location = new System.Drawing.Point(547, 389);
            this.comboFrames.Name = "comboFrames";
            this.comboFrames.Size = new System.Drawing.Size(121, 21);
            this.comboFrames.Sorted = true;
            this.comboFrames.TabIndex = 21;
            this.comboFrames.Visible = false;
            // 
            // comboLens
            // 
            this.comboLens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLens.FormattingEnabled = true;
            this.comboLens.Location = new System.Drawing.Point(547, 420);
            this.comboLens.Name = "comboLens";
            this.comboLens.Size = new System.Drawing.Size(121, 21);
            this.comboLens.Sorted = true;
            this.comboLens.TabIndex = 22;
            this.comboLens.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.Location = new System.Drawing.Point(787, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 30);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // numDiscount
            // 
            this.numDiscount.Location = new System.Drawing.Point(85, 287);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(120, 20);
            this.numDiscount.TabIndex = 8;
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(654, 455);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 30);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.toolTip.ToolTipTitle = "Error";
            // 
            // AddProduct
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(918, 497);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.numDiscount);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboLens);
            this.Controls.Add(this.comboFrames);
            this.Controls.Add(this.lblLensName);
            this.Controls.Add(this.lblFrameName);
            this.Controls.Add(this.txtLensColor);
            this.Controls.Add(this.lblLensColor);
            this.Controls.Add(this.chkStopOrder);
            this.Controls.Add(this.flowImages);
            this.Controls.Add(this.btnAddImages);
            this.Controls.Add(this.CategoryGroup);
            this.Controls.Add(this.txtFrameColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.CategoryGroup.ResumeLayout(false);
            this.CategoryGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFrameColor;
        private System.Windows.Forms.GroupBox CategoryGroup;
        private System.Windows.Forms.RadioButton radioPrescriptionGlasses;
        private System.Windows.Forms.RadioButton radioSunglasses;
        private System.Windows.Forms.Button btnAddImages;
        private System.Windows.Forms.FlowLayoutPanel flowImages;
        private System.Windows.Forms.CheckedListBox chkStopOrder;
        private System.Windows.Forms.Label lblLensColor;
        private System.Windows.Forms.TextBox txtLensColor;
        private System.Windows.Forms.Label lblFrameName;
        private System.Windows.Forms.Label lblLensName;
        private System.Windows.Forms.ComboBox comboFrames;
        private System.Windows.Forms.ComboBox comboLens;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolTip toolTip;
    }
}