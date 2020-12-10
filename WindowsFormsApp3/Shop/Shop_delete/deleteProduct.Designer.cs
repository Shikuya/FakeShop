
namespace ShopApp.Shop.Shop_delete
{
    partial class deleteProduct
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
            this.CB_Product_Categoriename = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Product_Baradname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Product_Productname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.B_Product_DeleteProduct = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_Product_Categoriename
            // 
            this.CB_Product_Categoriename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Product_Categoriename.FormattingEnabled = true;
            this.CB_Product_Categoriename.Location = new System.Drawing.Point(84, 10);
            this.CB_Product_Categoriename.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.CB_Product_Categoriename.Name = "CB_Product_Categoriename";
            this.CB_Product_Categoriename.Size = new System.Drawing.Size(185, 34);
            this.CB_Product_Categoriename.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categorie :";
            // 
            // CB_Product_Baradname
            // 
            this.CB_Product_Baradname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Product_Baradname.FormattingEnabled = true;
            this.CB_Product_Baradname.Location = new System.Drawing.Point(84, 54);
            this.CB_Product_Baradname.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.CB_Product_Baradname.Name = "CB_Product_Baradname";
            this.CB_Product_Baradname.Size = new System.Drawing.Size(185, 34);
            this.CB_Product_Baradname.TabIndex = 0;
            this.CB_Product_Baradname.SelectedIndexChanged += new System.EventHandler(this.CB_Product_Baradname_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand :";
            // 
            // CB_Product_Productname
            // 
            this.CB_Product_Productname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Product_Productname.FormattingEnabled = true;
            this.CB_Product_Productname.Location = new System.Drawing.Point(84, 100);
            this.CB_Product_Productname.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.CB_Product_Productname.Name = "CB_Product_Productname";
            this.CB_Product_Productname.Size = new System.Drawing.Size(185, 34);
            this.CB_Product_Productname.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product :";
            // 
            // B_Product_DeleteProduct
            // 
            this.B_Product_DeleteProduct.Location = new System.Drawing.Point(84, 143);
            this.B_Product_DeleteProduct.Name = "B_Product_DeleteProduct";
            this.B_Product_DeleteProduct.Size = new System.Drawing.Size(182, 65);
            this.B_Product_DeleteProduct.TabIndex = 2;
            this.B_Product_DeleteProduct.Text = "Delete Product\r\n(Enter)";
            this.B_Product_DeleteProduct.UseVisualStyleBackColor = true;
            this.B_Product_DeleteProduct.Click += new System.EventHandler(this.B_Product_DeleteProduct_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B_Product_DeleteProduct);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CB_Product_Productname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CB_Product_Baradname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CB_Product_Categoriename);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 249);
            this.panel1.TabIndex = 3;
            // 
            // deleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 259);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("AngsanaUPC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "deleteProduct";
            this.Text = "deleteProduct";
            this.Load += new System.EventHandler(this.deleteProduct_Load);
            this.SizeChanged += new System.EventHandler(this.deleteProduct_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Product_Categoriename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Product_Baradname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Product_Productname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button B_Product_DeleteProduct;
        private System.Windows.Forms.Panel panel1;
    }
}