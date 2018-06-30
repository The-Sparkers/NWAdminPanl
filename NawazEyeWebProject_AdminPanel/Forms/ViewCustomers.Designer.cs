namespace NawazEyeWebProject_AdminPanel.Forms
{
    partial class ViewCustomers
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
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.dataCustomers = new System.Windows.Forms.DataGridView();
            this.btnSndEmail = new System.Windows.Forms.Button();
            this.btnDisableAcnt = new System.Windows.Forms.Button();
            this.btnEnAcnt = new System.Windows.Forms.Button();
            this.btnSndSMS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customers";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(876, 15);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 6;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // dataCustomers
            // 
            this.dataCustomers.AllowUserToAddRows = false;
            this.dataCustomers.AllowUserToDeleteRows = false;
            this.dataCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCustomers.Location = new System.Drawing.Point(18, 44);
            this.dataCustomers.Name = "dataCustomers";
            this.dataCustomers.ReadOnly = true;
            this.dataCustomers.Size = new System.Drawing.Size(933, 358);
            this.dataCustomers.TabIndex = 7;
            // 
            // btnSndEmail
            // 
            this.btnSndEmail.Location = new System.Drawing.Point(844, 408);
            this.btnSndEmail.Name = "btnSndEmail";
            this.btnSndEmail.Size = new System.Drawing.Size(107, 23);
            this.btnSndEmail.TabIndex = 8;
            this.btnSndEmail.Text = "Send Email";
            this.btnSndEmail.UseVisualStyleBackColor = true;
            this.btnSndEmail.Click += new System.EventHandler(this.btnSndEmail_Click);
            // 
            // btnDisableAcnt
            // 
            this.btnDisableAcnt.Location = new System.Drawing.Point(18, 409);
            this.btnDisableAcnt.Name = "btnDisableAcnt";
            this.btnDisableAcnt.Size = new System.Drawing.Size(97, 23);
            this.btnDisableAcnt.TabIndex = 9;
            this.btnDisableAcnt.Text = "Disable Account";
            this.btnDisableAcnt.UseVisualStyleBackColor = true;
            this.btnDisableAcnt.Click += new System.EventHandler(this.btnDisableAcnt_Click);
            // 
            // btnEnAcnt
            // 
            this.btnEnAcnt.Location = new System.Drawing.Point(122, 408);
            this.btnEnAcnt.Name = "btnEnAcnt";
            this.btnEnAcnt.Size = new System.Drawing.Size(101, 23);
            this.btnEnAcnt.TabIndex = 10;
            this.btnEnAcnt.Text = "Enable Account";
            this.btnEnAcnt.UseVisualStyleBackColor = true;
            this.btnEnAcnt.Click += new System.EventHandler(this.btnEnAcnt_Click);
            // 
            // btnSndSMS
            // 
            this.btnSndSMS.Location = new System.Drawing.Point(731, 408);
            this.btnSndSMS.Name = "btnSndSMS";
            this.btnSndSMS.Size = new System.Drawing.Size(107, 23);
            this.btnSndSMS.TabIndex = 11;
            this.btnSndSMS.Text = "Send SMS";
            this.btnSndSMS.UseVisualStyleBackColor = true;
            this.btnSndSMS.Click += new System.EventHandler(this.btnSndSMS_Click);
            // 
            // ViewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 457);
            this.Controls.Add(this.btnSndSMS);
            this.Controls.Add(this.btnEnAcnt);
            this.Controls.Add(this.btnDisableAcnt);
            this.Controls.Add(this.btnSndEmail);
            this.Controls.Add(this.dataCustomers);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.label1);
            this.Name = "ViewCustomers";
            this.Text = "View Customers";
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.DataGridView dataCustomers;
        private System.Windows.Forms.Button btnSndEmail;
        private System.Windows.Forms.Button btnDisableAcnt;
        private System.Windows.Forms.Button btnEnAcnt;
        private System.Windows.Forms.Button btnSndSMS;
    }
}