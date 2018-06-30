namespace NawazEyeWebProject_AdminPanel.Forms
{
    partial class ViewPrescriptionGlasses
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
            this.chkStopOrder = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSetPrimary = new System.Windows.Forms.Button();
            this.imageGridView = new System.Windows.Forms.DataGridView();
            this.lblLensColor = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.txtFrameColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.comboLens = new System.Windows.Forms.ComboBox();
            this.comboFrames = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // chkStopOrder
            // 
            this.chkStopOrder.AutoSize = true;
            this.chkStopOrder.Location = new System.Drawing.Point(8, 466);
            this.chkStopOrder.Name = "chkStopOrder";
            this.chkStopOrder.Size = new System.Drawing.Size(77, 17);
            this.chkStopOrder.TabIndex = 9;
            this.chkStopOrder.Text = "Stop Order";
            this.chkStopOrder.UseVisualStyleBackColor = true;
            this.chkStopOrder.CheckedChanged += new System.EventHandler(this.chkStopOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(741, 463);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(822, 463);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSetPrimary
            // 
            this.btnSetPrimary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPrimary.Location = new System.Drawing.Point(474, 384);
            this.btnSetPrimary.Name = "btnSetPrimary";
            this.btnSetPrimary.Size = new System.Drawing.Size(140, 25);
            this.btnSetPrimary.TabIndex = 10;
            this.btnSetPrimary.Text = "Set Primary Image";
            this.btnSetPrimary.UseVisualStyleBackColor = true;
            this.btnSetPrimary.Click += new System.EventHandler(this.btnSetPrimary_Click);
            // 
            // imageGridView
            // 
            this.imageGridView.AllowUserToAddRows = false;
            this.imageGridView.AllowUserToDeleteRows = false;
            this.imageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imageGridView.Location = new System.Drawing.Point(474, 12);
            this.imageGridView.MultiSelect = false;
            this.imageGridView.Name = "imageGridView";
            this.imageGridView.ReadOnly = true;
            this.imageGridView.Size = new System.Drawing.Size(424, 366);
            this.imageGridView.TabIndex = 66;
            // 
            // lblLensColor
            // 
            this.lblLensColor.AutoSize = true;
            this.lblLensColor.Location = new System.Drawing.Point(5, 399);
            this.lblLensColor.Name = "lblLensColor";
            this.lblLensColor.Size = new System.Drawing.Size(33, 13);
            this.lblLensColor.TabIndex = 65;
            this.lblLensColor.Text = "Lens:";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(75, 16);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Size = new System.Drawing.Size(246, 20);
            this.txtProductId.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Product Id:";
            // 
            // numDiscount
            // 
            this.numDiscount.Location = new System.Drawing.Point(75, 315);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(120, 20);
            this.numDiscount.TabIndex = 5;
            this.numDiscount.ValueChanged += new System.EventHandler(this.numDiscount_ValueChanged);
            // 
            // txtFrameColor
            // 
            this.txtFrameColor.Location = new System.Drawing.Point(75, 358);
            this.txtFrameColor.Name = "txtFrameColor";
            this.txtFrameColor.Size = new System.Drawing.Size(120, 20);
            this.txtFrameColor.TabIndex = 6;
            this.txtFrameColor.TextChanged += new System.EventHandler(this.txtFrameColor_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "FrameColor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Discount (%):";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(75, 281);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 20);
            this.numQuantity.TabIndex = 4;
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Description:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Name:";
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.toolTip.ToolTipTitle = "Error";
            // 
            // txtPrice
            // 
            this.txtPrice.BeepOnError = true;
            this.txtPrice.Location = new System.Drawing.Point(75, 242);
            this.txtPrice.Mask = "RS. 0000000000000";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 20);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsReturn = true;
            this.txtDescription.AcceptsTab = true;
            this.txtDescription.Location = new System.Drawing.Point(75, 88);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(246, 141);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // comboLens
            // 
            this.comboLens.FormattingEnabled = true;
            this.comboLens.Location = new System.Drawing.Point(75, 396);
            this.comboLens.Name = "comboLens";
            this.comboLens.Size = new System.Drawing.Size(121, 21);
            this.comboLens.TabIndex = 7;
            this.comboLens.TextChanged += new System.EventHandler(this.txtLensColor_TextChanged);
            // 
            // comboFrames
            // 
            this.comboFrames.FormattingEnabled = true;
            this.comboFrames.Location = new System.Drawing.Point(74, 439);
            this.comboFrames.Name = "comboFrames";
            this.comboFrames.Size = new System.Drawing.Size(121, 21);
            this.comboFrames.TabIndex = 8;
            this.comboFrames.SelectedIndexChanged += new System.EventHandler(this.comboFrames_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Frame:";
            // 
            // ViewPrescriptionGlasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 498);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboFrames);
            this.Controls.Add(this.comboLens);
            this.Controls.Add(this.chkStopOrder);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSetPrimary);
            this.Controls.Add(this.imageGridView);
            this.Controls.Add(this.lblLensColor);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numDiscount);
            this.Controls.Add(this.txtFrameColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Name = "ViewPrescriptionGlasses";
            this.Text = "View Prescription Glasses";
            ((System.ComponentModel.ISupportInitialize)(this.imageGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkStopOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSetPrimary;
        private System.Windows.Forms.DataGridView imageGridView;
        private System.Windows.Forms.Label lblLensColor;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.TextBox txtFrameColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox comboLens;
        private System.Windows.Forms.ComboBox comboFrames;
        private System.Windows.Forms.Label label8;
    }
}