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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnViewFrames = new System.Windows.Forms.Button();
            this.btnViewLens = new System.Windows.Forms.Button();
            this.btnViewPromos = new System.Windows.Forms.Button();
            this.btnViewCustomers = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(836, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnViewFrames
            // 
            this.btnViewFrames.Location = new System.Drawing.Point(755, 34);
            this.btnViewFrames.Name = "btnViewFrames";
            this.btnViewFrames.Size = new System.Drawing.Size(75, 23);
            this.btnViewFrames.TabIndex = 6;
            this.btnViewFrames.Text = "View Frames";
            this.btnViewFrames.UseVisualStyleBackColor = true;
            this.btnViewFrames.Click += new System.EventHandler(this.btnViewFrames_Click);
            // 
            // btnViewLens
            // 
            this.btnViewLens.Location = new System.Drawing.Point(674, 34);
            this.btnViewLens.Name = "btnViewLens";
            this.btnViewLens.Size = new System.Drawing.Size(75, 23);
            this.btnViewLens.TabIndex = 7;
            this.btnViewLens.Text = "View Lens";
            this.btnViewLens.UseVisualStyleBackColor = true;
            this.btnViewLens.Click += new System.EventHandler(this.btnViewLens_Click);
            // 
            // btnViewPromos
            // 
            this.btnViewPromos.Location = new System.Drawing.Point(573, 34);
            this.btnViewPromos.Name = "btnViewPromos";
            this.btnViewPromos.Size = new System.Drawing.Size(95, 23);
            this.btnViewPromos.TabIndex = 8;
            this.btnViewPromos.Text = "View Promos";
            this.btnViewPromos.UseVisualStyleBackColor = true;
            this.btnViewPromos.Click += new System.EventHandler(this.btnViewPromos_Click);
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.Location = new System.Drawing.Point(467, 34);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(99, 23);
            this.btnViewCustomers.TabIndex = 9;
            this.btnViewCustomers.Text = "View Customers";
            this.btnViewCustomers.UseVisualStyleBackColor = true;
            this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Location = new System.Drawing.Point(385, 34);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(76, 23);
            this.btnViewOrders.TabIndex = 10;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 499);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnViewCustomers);
            this.Controls.Add(this.btnViewPromos);
            this.Controls.Add(this.btnViewLens);
            this.Controls.Add(this.btnViewFrames);
            this.Controls.Add(this.btnAdd);
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnViewFrames;
        private System.Windows.Forms.Button btnViewLens;
        private System.Windows.Forms.Button btnViewPromos;
        private System.Windows.Forms.Button btnViewCustomers;
        private System.Windows.Forms.Button btnViewOrders;
    }
}