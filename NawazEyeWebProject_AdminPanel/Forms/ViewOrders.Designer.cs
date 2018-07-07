namespace NawazEyeWebProject_AdminPanel.Forms
{
    partial class ViewOrders
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
            this.dataOrders = new System.Windows.Forms.DataGridView();
            this.btnDetails = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioDelivered = new System.Windows.Forms.RadioButton();
            this.radioInProgress = new System.Windows.Forms.RadioButton();
            this.radioPending = new System.Windows.Forms.RadioButton();
            this.radioAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrders)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Orders";
            // 
            // dataOrders
            // 
            this.dataOrders.AllowUserToAddRows = false;
            this.dataOrders.AllowUserToDeleteRows = false;
            this.dataOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrders.Location = new System.Drawing.Point(13, 106);
            this.dataOrders.MultiSelect = false;
            this.dataOrders.Name = "dataOrders";
            this.dataOrders.ReadOnly = true;
            this.dataOrders.Size = new System.Drawing.Size(541, 380);
            this.dataOrders.TabIndex = 7;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(479, 497);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 23);
            this.btnDetails.TabIndex = 8;
            this.btnDetails.Text = "View Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(375, 63);
            this.txtSearch.Mask = "000000000000000000000000000000000000000000000000000000000000000000000000000000";
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 20);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.Text = "0";
            this.txtSearch.TextChanged += new System.EventHandler(this.FilterValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioDelivered);
            this.groupBox1.Controls.Add(this.radioInProgress);
            this.groupBox1.Controls.Add(this.radioPending);
            this.groupBox1.Controls.Add(this.radioAll);
            this.groupBox1.Location = new System.Drawing.Point(18, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 50);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // radioDelivered
            // 
            this.radioDelivered.AutoSize = true;
            this.radioDelivered.Location = new System.Drawing.Point(206, 19);
            this.radioDelivered.Name = "radioDelivered";
            this.radioDelivered.Size = new System.Drawing.Size(67, 17);
            this.radioDelivered.TabIndex = 3;
            this.radioDelivered.Text = "Dispatch";
            this.radioDelivered.UseVisualStyleBackColor = true;
            this.radioDelivered.CheckedChanged += new System.EventHandler(this.FilterValueChanged);
            // 
            // radioInProgress
            // 
            this.radioInProgress.AutoSize = true;
            this.radioInProgress.Location = new System.Drawing.Point(121, 19);
            this.radioInProgress.Name = "radioInProgress";
            this.radioInProgress.Size = new System.Drawing.Size(78, 17);
            this.radioInProgress.TabIndex = 2;
            this.radioInProgress.Text = "In Progress";
            this.radioInProgress.UseVisualStyleBackColor = true;
            this.radioInProgress.CheckedChanged += new System.EventHandler(this.FilterValueChanged);
            // 
            // radioPending
            // 
            this.radioPending.AutoSize = true;
            this.radioPending.Location = new System.Drawing.Point(50, 19);
            this.radioPending.Name = "radioPending";
            this.radioPending.Size = new System.Drawing.Size(64, 17);
            this.radioPending.TabIndex = 1;
            this.radioPending.Text = "Pending";
            this.radioPending.UseVisualStyleBackColor = true;
            this.radioPending.CheckedChanged += new System.EventHandler(this.FilterValueChanged);
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Checked = true;
            this.radioAll.Location = new System.Drawing.Point(7, 20);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(36, 17);
            this.radioAll.TabIndex = 0;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "All";
            this.radioAll.UseVisualStyleBackColor = true;
            this.radioAll.CheckedChanged += new System.EventHandler(this.FilterValueChanged);
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 530);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.dataOrders);
            this.Controls.Add(this.label1);
            this.Name = "ViewOrders";
            this.Text = "View Orders";
            ((System.ComponentModel.ISupportInitialize)(this.dataOrders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataOrders;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioDelivered;
        private System.Windows.Forms.RadioButton radioInProgress;
        private System.Windows.Forms.RadioButton radioPending;
        private System.Windows.Forms.RadioButton radioAll;
    }
}