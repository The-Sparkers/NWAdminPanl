namespace NawazEyeWebProject_AdminPanel.Forms
{
    partial class ViewOrderDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataItemsLst = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeliveryCharges = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGTotal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnViewBuyer = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnPrntDetails = new System.Windows.Forms.Button();
            this.txtPromoDiscount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnViewPrescription = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataItemsLst)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OrderId:";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(64, 21);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(100, 20);
            this.txtOrderId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Items List:";
            // 
            // dataItemsLst
            // 
            this.dataItemsLst.AllowUserToAddRows = false;
            this.dataItemsLst.AllowUserToDeleteRows = false;
            this.dataItemsLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataItemsLst.Location = new System.Drawing.Point(19, 67);
            this.dataItemsLst.MultiSelect = false;
            this.dataItemsLst.Name = "dataItemsLst";
            this.dataItemsLst.ReadOnly = true;
            this.dataItemsLst.Size = new System.Drawing.Size(440, 124);
            this.dataItemsLst.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Price:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(87, 237);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalPrice.Size = new System.Drawing.Size(372, 20);
            this.txtTotalPrice.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Delivery Charges:";
            // 
            // txtDeliveryCharges
            // 
            this.txtDeliveryCharges.Location = new System.Drawing.Point(112, 290);
            this.txtDeliveryCharges.Name = "txtDeliveryCharges";
            this.txtDeliveryCharges.ReadOnly = true;
            this.txtDeliveryCharges.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDeliveryCharges.Size = new System.Drawing.Size(347, 20);
            this.txtDeliveryCharges.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Grand Total:";
            // 
            // txtGTotal
            // 
            this.txtGTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGTotal.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtGTotal.Location = new System.Drawing.Point(100, 323);
            this.txtGTotal.Name = "txtGTotal";
            this.txtGTotal.ReadOnly = true;
            this.txtGTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGTotal.Size = new System.Drawing.Size(359, 26);
            this.txtGTotal.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnViewBuyer);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(13, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 201);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buyer\'s Info";
            // 
            // btnViewBuyer
            // 
            this.btnViewBuyer.Location = new System.Drawing.Point(6, 41);
            this.btnViewBuyer.Name = "btnViewBuyer";
            this.btnViewBuyer.Size = new System.Drawing.Size(75, 27);
            this.btnViewBuyer.TabIndex = 6;
            this.btnViewBuyer.Text = "View Buyer";
            this.btnViewBuyer.UseVisualStyleBackColor = true;
            this.btnViewBuyer.Click += new System.EventHandler(this.btnViewBuyer_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(52, 74);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(373, 121);
            this.txtAddress.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Address:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(277, 13);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(148, 20);
            this.txtCity.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "City:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(52, 15);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(148, 20);
            this.txtName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name:";
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(13, 568);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(93, 23);
            this.btnStatus.TabIndex = 11;
            this.btnStatus.Text = "Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnPrntDetails
            // 
            this.btnPrntDetails.Location = new System.Drawing.Point(384, 568);
            this.btnPrntDetails.Name = "btnPrntDetails";
            this.btnPrntDetails.Size = new System.Drawing.Size(75, 23);
            this.btnPrntDetails.TabIndex = 12;
            this.btnPrntDetails.Text = "Print Details";
            this.btnPrntDetails.UseVisualStyleBackColor = true;
            this.btnPrntDetails.Click += new System.EventHandler(this.btnPrntDetails_Click);
            // 
            // txtPromoDiscount
            // 
            this.txtPromoDiscount.Location = new System.Drawing.Point(112, 264);
            this.txtPromoDiscount.Name = "txtPromoDiscount";
            this.txtPromoDiscount.ReadOnly = true;
            this.txtPromoDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPromoDiscount.Size = new System.Drawing.Size(347, 20);
            this.txtPromoDiscount.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Promo Discount:";
            // 
            // btnViewPrescription
            // 
            this.btnViewPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPrescription.Location = new System.Drawing.Point(355, 198);
            this.btnViewPrescription.Name = "btnViewPrescription";
            this.btnViewPrescription.Size = new System.Drawing.Size(103, 23);
            this.btnViewPrescription.TabIndex = 16;
            this.btnViewPrescription.Text = "View Prescription";
            this.btnViewPrescription.UseVisualStyleBackColor = true;
            this.btnViewPrescription.Click += new System.EventHandler(this.btnViewPrescription_Click);
            // 
            // ViewOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 596);
            this.Controls.Add(this.btnViewPrescription);
            this.Controls.Add(this.txtPromoDiscount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnPrntDetails);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtGTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDeliveryCharges);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataItemsLst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ViewOrderDetails";
            this.Text = "Order Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataItemsLst)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataItemsLst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeliveryCharges;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnPrntDetails;
        private System.Windows.Forms.TextBox txtPromoDiscount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnViewBuyer;
        private System.Windows.Forms.Button btnViewPrescription;
    }
}