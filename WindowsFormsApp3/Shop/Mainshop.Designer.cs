namespace WindowsFormsApp3.Shop
{
    partial class Mainshop
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.เพมสงตางๆToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_Customer_add = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_Customer_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_Customer_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_Categorie = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_Categorie_add = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_Categorie_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_Categorie_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_Brand = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_brand_add = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_brand_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_brand_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_Product = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_product_add = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_product_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_product_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_Transport = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_transport_add = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_transport_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_transport_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_event = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_event_add = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_event_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_1_event_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_2_CheckStock = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_2_HistoryOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.เพมสงตางๆToolStripMenuItem,
            this.optionToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // เพมสงตางๆToolStripMenuItem
            // 
            this.เพมสงตางๆToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_1_Customer,
            this.TSM_1_Categorie,
            this.TSM_1_Brand,
            this.TSM_1_Product,
            this.TSM_1_Transport,
            this.TSM_1_event});
            this.เพมสงตางๆToolStripMenuItem.Name = "เพมสงตางๆToolStripMenuItem";
            this.เพมสงตางๆToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.เพมสงตางๆToolStripMenuItem.Text = "1 ) จัดการข้อมูล";
            // 
            // TSM_1_Customer
            // 
            this.TSM_1_Customer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_1_Customer_add,
            this.TSM_1_Customer_edit,
            this.TSM_1_Customer_delete});
            this.TSM_1_Customer.Name = "TSM_1_Customer";
            this.TSM_1_Customer.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_Customer.Text = "1 Customer";
            // 
            // TSM_1_Customer_add
            // 
            this.TSM_1_Customer_add.Name = "TSM_1_Customer_add";
            this.TSM_1_Customer_add.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_Customer_add.Text = "1 Add Customer";
            this.TSM_1_Customer_add.Click += new System.EventHandler(this.TSM_1_Customer_add_Click);
            // 
            // TSM_1_Customer_edit
            // 
            this.TSM_1_Customer_edit.Name = "TSM_1_Customer_edit";
            this.TSM_1_Customer_edit.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_Customer_edit.Text = "2 Edit Customer";
            // 
            // TSM_1_Customer_delete
            // 
            this.TSM_1_Customer_delete.Name = "TSM_1_Customer_delete";
            this.TSM_1_Customer_delete.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_Customer_delete.Text = " 3 Delete Customer";
            // 
            // TSM_1_Categorie
            // 
            this.TSM_1_Categorie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_1_Categorie_add,
            this.TSM_1_Categorie_edit,
            this.TSM_1_Categorie_delete});
            this.TSM_1_Categorie.Name = "TSM_1_Categorie";
            this.TSM_1_Categorie.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_Categorie.Text = "2 Categorie";
            this.TSM_1_Categorie.Click += new System.EventHandler(this.categorieToolStripMenuItem_Click);
            // 
            // TSM_1_Categorie_add
            // 
            this.TSM_1_Categorie_add.Name = "TSM_1_Categorie_add";
            this.TSM_1_Categorie_add.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_Categorie_add.Text = "1 Add Categorie";
            // 
            // TSM_1_Categorie_edit
            // 
            this.TSM_1_Categorie_edit.Name = "TSM_1_Categorie_edit";
            this.TSM_1_Categorie_edit.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_Categorie_edit.Text = "2 Edit Categorie";
            // 
            // TSM_1_Categorie_delete
            // 
            this.TSM_1_Categorie_delete.Name = "TSM_1_Categorie_delete";
            this.TSM_1_Categorie_delete.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_Categorie_delete.Text = "3 Delete Categorie";
            // 
            // TSM_1_Brand
            // 
            this.TSM_1_Brand.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_1_brand_add,
            this.TSM_1_brand_edit,
            this.TSM_1_brand_delete});
            this.TSM_1_Brand.Name = "TSM_1_Brand";
            this.TSM_1_Brand.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_Brand.Text = "3 Brand";
            // 
            // TSM_1_brand_add
            // 
            this.TSM_1_brand_add.Name = "TSM_1_brand_add";
            this.TSM_1_brand_add.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_brand_add.Text = "1 Add Brand";
            // 
            // TSM_1_brand_edit
            // 
            this.TSM_1_brand_edit.Name = "TSM_1_brand_edit";
            this.TSM_1_brand_edit.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_brand_edit.Text = "2 Edit Brand";
            // 
            // TSM_1_brand_delete
            // 
            this.TSM_1_brand_delete.Name = "TSM_1_brand_delete";
            this.TSM_1_brand_delete.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_brand_delete.Text = "3 Delete Brand";
            // 
            // TSM_1_Product
            // 
            this.TSM_1_Product.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_1_product_add,
            this.TSM_1_product_edit,
            this.TSM_1_product_delete});
            this.TSM_1_Product.Name = "TSM_1_Product";
            this.TSM_1_Product.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_Product.Text = "4 Product";
            // 
            // TSM_1_product_add
            // 
            this.TSM_1_product_add.Name = "TSM_1_product_add";
            this.TSM_1_product_add.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_product_add.Text = "1 Add Product";
            this.TSM_1_product_add.Click += new System.EventHandler(this.เพมToolStripMenuItem3_Click);
            // 
            // TSM_1_product_edit
            // 
            this.TSM_1_product_edit.Name = "TSM_1_product_edit";
            this.TSM_1_product_edit.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_product_edit.Text = "2 Edit Product";
            // 
            // TSM_1_product_delete
            // 
            this.TSM_1_product_delete.Name = "TSM_1_product_delete";
            this.TSM_1_product_delete.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_product_delete.Text = "3 Delete Product";
            // 
            // TSM_1_Transport
            // 
            this.TSM_1_Transport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_1_transport_add,
            this.TSM_1_transport_edit,
            this.TSM_1_transport_delete});
            this.TSM_1_Transport.Name = "TSM_1_Transport";
            this.TSM_1_Transport.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_Transport.Text = "5 Transport";
            // 
            // TSM_1_transport_add
            // 
            this.TSM_1_transport_add.Name = "TSM_1_transport_add";
            this.TSM_1_transport_add.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_transport_add.Text = "1 Add Trransport";
            // 
            // TSM_1_transport_edit
            // 
            this.TSM_1_transport_edit.Name = "TSM_1_transport_edit";
            this.TSM_1_transport_edit.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_transport_edit.Text = "2 Edit Trransport";
            // 
            // TSM_1_transport_delete
            // 
            this.TSM_1_transport_delete.Name = "TSM_1_transport_delete";
            this.TSM_1_transport_delete.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_transport_delete.Text = "3 Delete Trransport";
            // 
            // TSM_1_event
            // 
            this.TSM_1_event.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_1_event_add,
            this.TSM_1_event_edit,
            this.TSM_1_event_delete});
            this.TSM_1_event.Name = "TSM_1_event";
            this.TSM_1_event.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_event.Text = "6 EventSale";
            // 
            // TSM_1_event_add
            // 
            this.TSM_1_event_add.Name = "TSM_1_event_add";
            this.TSM_1_event_add.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_event_add.Text = "1 Add EventSale";
            // 
            // TSM_1_event_edit
            // 
            this.TSM_1_event_edit.Name = "TSM_1_event_edit";
            this.TSM_1_event_edit.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_event_edit.Text = "2 Edit EventSale";
            // 
            // TSM_1_event_delete
            // 
            this.TSM_1_event_delete.Name = "TSM_1_event_delete";
            this.TSM_1_event_delete.Size = new System.Drawing.Size(180, 22);
            this.TSM_1_event_delete.Text = "3 Delete EventSale";
            // 
            // optionToolStripMenuItem1
            // 
            this.optionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_2_CheckStock,
            this.TSM_2_HistoryOrder});
            this.optionToolStripMenuItem1.Name = "optionToolStripMenuItem1";
            this.optionToolStripMenuItem1.Size = new System.Drawing.Size(72, 20);
            this.optionToolStripMenuItem1.Text = "2 ) Option";
            // 
            // TSM_2_CheckStock
            // 
            this.TSM_2_CheckStock.Name = "TSM_2_CheckStock";
            this.TSM_2_CheckStock.Size = new System.Drawing.Size(180, 22);
            this.TSM_2_CheckStock.Text = "Check Stock";
            // 
            // TSM_2_HistoryOrder
            // 
            this.TSM_2_HistoryOrder.Name = "TSM_2_HistoryOrder";
            this.TSM_2_HistoryOrder.Size = new System.Drawing.Size(180, 22);
            this.TSM_2_HistoryOrder.Text = "History Order";
            // 
            // Mainshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Mainshop";
            this.Text = "Mainshop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem เพมสงตางๆToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_Customer;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_Categorie;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_Brand;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_Product;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_Transport;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_event;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TSM_2_CheckStock;
        private System.Windows.Forms.ToolStripMenuItem TSM_2_HistoryOrder;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_Customer_add;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_Customer_edit;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_Customer_delete;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_Categorie_add;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_Categorie_edit;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_Categorie_delete;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_brand_add;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_brand_edit;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_brand_delete;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_product_add;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_product_edit;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_product_delete;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_transport_add;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_transport_edit;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_transport_delete;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_event_add;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_event_edit;
        private System.Windows.Forms.ToolStripMenuItem TSM_1_event_delete;
    }
}