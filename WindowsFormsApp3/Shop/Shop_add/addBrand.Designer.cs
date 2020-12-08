namespace ShopApp.Shop.add
{
    partial class addBrand
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
            this.label7 = new System.Windows.Forms.Label();
            this.B_add_brand = new System.Windows.Forms.Button();
            this.TBBrand_Add_Brand = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Brand Name  :";
            // 
            // B_add_brand
            // 
            this.B_add_brand.Location = new System.Drawing.Point(115, 86);
            this.B_add_brand.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.B_add_brand.Name = "B_add_brand";
            this.B_add_brand.Size = new System.Drawing.Size(149, 63);
            this.B_add_brand.TabIndex = 2;
            this.B_add_brand.Text = "Add Brand \r\n( Enter )";
            this.B_add_brand.UseVisualStyleBackColor = true;
            this.B_add_brand.Click += new System.EventHandler(this.B_add_brand_Click);
            // 
            // TBBrand_Add_Brand
            // 
            this.TBBrand_Add_Brand.Location = new System.Drawing.Point(116, 31);
            this.TBBrand_Add_Brand.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.TBBrand_Add_Brand.Multiline = true;
            this.TBBrand_Add_Brand.Name = "TBBrand_Add_Brand";
            this.TBBrand_Add_Brand.Size = new System.Drawing.Size(148, 41);
            this.TBBrand_Add_Brand.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBBrand_Add_Brand);
            this.panel1.Controls.Add(this.B_add_brand);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(9, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 179);
            this.panel1.TabIndex = 6;
            // 
            // addBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 205);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("AngsanaUPC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.Name = "addBrand";
            this.Text = "addBrand";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button B_add_brand;
        private System.Windows.Forms.TextBox TBBrand_Add_Brand;
        private System.Windows.Forms.Panel panel1;
    }
}