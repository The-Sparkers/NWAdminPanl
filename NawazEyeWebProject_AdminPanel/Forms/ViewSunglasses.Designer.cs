namespace NawazEyeWebProject_AdminPanel.Forms
{
    partial class ViewSunglasses
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.chkStopOrder = new System.Windows.Forms.CheckedListBox();
            this.txtFrameColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtLensColor = new System.Windows.Forms.TextBox();
            this.lblLensColor = new System.Windows.Forms.Label();
            this.imageGridView = new System.Windows.Forms.DataGridView();
            this.btnSetPrimary = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.toolTip.ToolTipTitle = "Error";
            // 
            // numDiscount
            // 
            this.numDiscount.Location = new System.Drawing.Point(82, 315);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(120, 20);
            this.numDiscount.TabIndex = 33;
            this.numDiscount.ValueChanged += new System.EventHandler(this.numDiscount_ValueChanged);
            // 
            // chkStopOrder
            // 
            this.chkStopOrder.FormattingEnabled = true;
            this.chkStopOrder.Items.AddRange(new object[] {
            "Stop Order"});
            this.chkStopOrder.Location = new System.Drawing.Point(12, 451);
            this.chkStopOrder.Name = "chkStopOrder";
            this.chkStopOrder.Size = new System.Drawing.Size(120, 19);
            this.chkStopOrder.TabIndex = 40;
            this.chkStopOrder.Click += new System.EventHandler(this.chkStopOrder_Click);
            // 
            // txtFrameColor
            // 
            this.txtFrameColor.Location = new System.Drawing.Point(82, 358);
            this.txtFrameColor.Name = "txtFrameColor";
            this.txtFrameColor.Size = new System.Drawing.Size(120, 20);
            this.txtFrameColor.TabIndex = 36;
            this.txtFrameColor.TextChanged += new System.EventHandler(this.txtFrameColor_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "FrameColor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Discount (%):";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(82, 281);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 20);
            this.numQuantity.TabIndex = 32;
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Quantity:";
            // 
            // txtPrice
            // 
            this.txtPrice.BeepOnError = true;
            this.txtPrice.Location = new System.Drawing.Point(82, 242);
            this.txtPrice.Mask = "RS. 0000000000000";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 20);
            this.txtPrice.TabIndex = 30;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Price:";
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsReturn = true;
            this.txtDescription.AcceptsTab = true;
            this.txtDescription.Location = new System.Drawing.Point(82, 88);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(246, 141);
            this.txtDescription.TabIndex = 28;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Description:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 20);
            this.txtName.TabIndex = 26;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Product Id:";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(82, 16);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Size = new System.Drawing.Size(246, 20);
            this.txtProductId.TabIndex = 42;
            // 
            // txtLensColor
            // 
            this.txtLensColor.Location = new System.Drawing.Point(82, 393);
            this.txtLensColor.Name = "txtLensColor";
            this.txtLensColor.Size = new System.Drawing.Size(121, 20);
            this.txtLensColor.TabIndex = 44;
            this.txtLensColor.TextChanged += new System.EventHandler(this.txtLensColor_TextChanged);
            // 
            // lblLensColor
            // 
            this.lblLensColor.AutoSize = true;
            this.lblLensColor.Location = new System.Drawing.Point(12, 396);
            this.lblLensColor.Name = "lblLensColor";
            this.lblLensColor.Size = new System.Drawing.Size(60, 13);
            this.lblLensColor.TabIndex = 43;
            this.lblLensColor.Text = "Lens Color:";
            // 
            // imageGridView
            // 
            this.imageGridView.AllowUserToAddRows = false;
            this.imageGridView.AllowUserToDeleteRows = false;
            this.imageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imageGridView.Location = new System.Drawing.Point(481, 12);
            this.imageGridView.MultiSelect = false;
            this.imageGridView.Name = "imageGridView";
            this.imageGridView.ReadOnly = true;
            this.imageGridView.Size = new System.Drawing.Size(424, 366);
            this.imageGridView.TabIndex = 45;
            // 
            // btnSetPrimary
            // 
            this.btnSetPrimary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPrimary.Location = new System.Drawing.Point(481, 384);
            this.btnSetPrimary.Name = "btnSetPrimary";
            this.btnSetPrimary.Size = new System.Drawing.Size(140, 25);
            this.btnSetPrimary.TabIndex = 46;
            this.btnSetPrimary.Text = "Set Primary Image";
            this.btnSetPrimary.UseVisualStyleBackColor = true;
            this.btnSetPrimary.Click += new System.EventHandler(this.btnSetPrimary_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(829, 463);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(748, 463);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ViewSunglasses
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(917, 498);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSetPrimary);
            this.Controls.Add(this.imageGridView);
            this.Controls.Add(this.txtLensColor);
            this.Controls.Add(this.lblLensColor);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numDiscount);
            this.Controls.Add(this.chkStopOrder);
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
            this.Name = "ViewSunglasses";
            this.Text = "View Sunglasses";
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.CheckedListBox chkStopOrder;
        private System.Windows.Forms.TextBox txtFrameColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtLensColor;
        private System.Windows.Forms.Label lblLensColor;
        private System.Windows.Forms.DataGridView imageGridView;
        private System.Windows.Forms.Button btnSetPrimary;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}