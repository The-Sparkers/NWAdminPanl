namespace NawazEyeWebProject_AdminPanel.Forms
{
    partial class ViewProducts
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
            this.viewProductsGridView = new System.Windows.Forms.DataGridView();
            this.selectAllBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewProductsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewProductsGridView
            // 
            this.viewProductsGridView.AllowUserToAddRows = false;
            this.viewProductsGridView.AllowUserToDeleteRows = false;
            this.viewProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewProductsGridView.Location = new System.Drawing.Point(12, 63);
            this.viewProductsGridView.Name = "viewProductsGridView";
            this.viewProductsGridView.ReadOnly = true;
            this.viewProductsGridView.Size = new System.Drawing.Size(900, 372);
            this.viewProductsGridView.TabIndex = 0;
            // 
            // selectAllBtn
            // 
            this.selectAllBtn.Location = new System.Drawing.Point(12, 441);
            this.selectAllBtn.Name = "selectAllBtn";
            this.selectAllBtn.Size = new System.Drawing.Size(75, 23);
            this.selectAllBtn.TabIndex = 1;
            this.selectAllBtn.Text = "Select All";
            this.selectAllBtn.UseVisualStyleBackColor = true;
            this.selectAllBtn.Click += new System.EventHandler(this.selectAllBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(837, 441);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 2;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(756, 442);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(75, 23);
            this.viewBtn.TabIndex = 3;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Products";
            // 
            // ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.selectAllBtn);
            this.Controls.Add(this.viewProductsGridView);
            this.Name = "ViewProducts";
            this.Text = "View Products";
            ((System.ComponentModel.ISupportInitialize)(this.viewProductsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewProductsGridView;
        private System.Windows.Forms.Button selectAllBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Label label1;
    }
}