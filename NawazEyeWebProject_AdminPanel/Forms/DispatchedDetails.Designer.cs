namespace NawazEyeWebProject_AdminPanel.Forms
{
    partial class DispatchedDetails
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServiceProviderName = new System.Windows.Forms.TextBox();
            this.txtDeliveryCode = new System.Windows.Forms.TextBox();
            this.txtMaximumDeliveryTime = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Provider:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Delivery Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maximum Delivery Time (Days):";
            // 
            // txtServiceProviderName
            // 
            this.txtServiceProviderName.Location = new System.Drawing.Point(16, 30);
            this.txtServiceProviderName.Name = "txtServiceProviderName";
            this.txtServiceProviderName.Size = new System.Drawing.Size(256, 20);
            this.txtServiceProviderName.TabIndex = 3;
            // 
            // txtDeliveryCode
            // 
            this.txtDeliveryCode.Location = new System.Drawing.Point(16, 72);
            this.txtDeliveryCode.Name = "txtDeliveryCode";
            this.txtDeliveryCode.Size = new System.Drawing.Size(256, 20);
            this.txtDeliveryCode.TabIndex = 4;
            // 
            // txtMaximumDeliveryTime
            // 
            this.txtMaximumDeliveryTime.Location = new System.Drawing.Point(16, 117);
            this.txtMaximumDeliveryTime.Name = "txtMaximumDeliveryTime";
            this.txtMaximumDeliveryTime.Size = new System.Drawing.Size(256, 20);
            this.txtMaximumDeliveryTime.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(196, 151);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Required";
            // 
            // DispatchedDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 186);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtMaximumDeliveryTime);
            this.Controls.Add(this.txtDeliveryCode);
            this.Controls.Add(this.txtServiceProviderName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DispatchedDetails";
            this.Text = "DispatchedDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServiceProviderName;
        private System.Windows.Forms.TextBox txtDeliveryCode;
        private System.Windows.Forms.TextBox txtMaximumDeliveryTime;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ToolTip toolTip;
    }
}