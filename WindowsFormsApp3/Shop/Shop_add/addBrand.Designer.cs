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
            this.label1 = new System.Windows.Forms.Label();
            this.B_add_brand = new System.Windows.Forms.Button();
            this.TBBrand_Add_Brand = new System.Windows.Forms.TextBox();
            this.CBCategorie_Add_Brand = new System.Windows.Forms.ComboBox();
            this.b_leave_brand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Brand Name  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Categorie  :";
            // 
            // B_add_brand
            // 
            this.B_add_brand.Location = new System.Drawing.Point(130, 148);
            this.B_add_brand.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.B_add_brand.Name = "B_add_brand";
            this.B_add_brand.Size = new System.Drawing.Size(193, 57);
            this.B_add_brand.TabIndex = 2;
            this.B_add_brand.Text = "Add Brand ( Enter )";
            this.B_add_brand.UseVisualStyleBackColor = true;
            // 
            // TBBrand_Add_Brand
            // 
            this.TBBrand_Add_Brand.Location = new System.Drawing.Point(163, 98);
            this.TBBrand_Add_Brand.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TBBrand_Add_Brand.Multiline = true;
            this.TBBrand_Add_Brand.Name = "TBBrand_Add_Brand";
            this.TBBrand_Add_Brand.Size = new System.Drawing.Size(160, 38);
            this.TBBrand_Add_Brand.TabIndex = 1;
            // 
            // CBCategorie_Add_Brand
            // 
            this.CBCategorie_Add_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCategorie_Add_Brand.FormattingEnabled = true;
            this.CBCategorie_Add_Brand.Location = new System.Drawing.Point(162, 47);
            this.CBCategorie_Add_Brand.Name = "CBCategorie_Add_Brand";
            this.CBCategorie_Add_Brand.Size = new System.Drawing.Size(161, 34);
            this.CBCategorie_Add_Brand.TabIndex = 0;
            // 
            // b_leave_brand
            // 
            this.b_leave_brand.BackgroundImage = global::ShopApp.Properties.Resources.back_arrow_14447;
            this.b_leave_brand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_leave_brand.Location = new System.Drawing.Point(3, 265);
            this.b_leave_brand.Name = "b_leave_brand";
            this.b_leave_brand.Size = new System.Drawing.Size(53, 50);
            this.b_leave_brand.TabIndex = 3;
            this.b_leave_brand.UseVisualStyleBackColor = true;
            // 
            // addBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 314);
            this.Controls.Add(this.b_leave_brand);
            this.Controls.Add(this.CBCategorie_Add_Brand);
            this.Controls.Add(this.TBBrand_Add_Brand);
            this.Controls.Add(this.B_add_brand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("TH SarabunPSK", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "addBrand";
            this.Text = "addBrand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_add_brand;
        private System.Windows.Forms.TextBox TBBrand_Add_Brand;
        private System.Windows.Forms.ComboBox CBCategorie_Add_Brand;
        private System.Windows.Forms.Button b_leave_brand;
    }
}