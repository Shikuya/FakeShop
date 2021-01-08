
namespace ShopApp.Shop
{
    partial class Product_Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Sale));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TB_Transport = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_Select_Transport = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.B_Checked_Code = new System.Windows.Forms.Button();
            this.TB_Code_UseCode = new System.Windows.Forms.TextBox();
            this.TB_Console_StatusCode = new System.Windows.Forms.TextBox();
            this.Chb_on_off_code = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.B_Confirm_Order = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Price_Transport = new System.Windows.Forms.TextBox();
            this.B_ClearTab = new System.Windows.Forms.Button();
            this.B_AddProduct = new System.Windows.Forms.Button();
            this.TB_Balance_product = new System.Windows.Forms.TextBox();
            this.B_list_Product = new System.Windows.Forms.Button();
            this.DGV_Product = new System.Windows.Forms.DataGridView();
            this.IDProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TB_Select_Product = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Select_Customer = new System.Windows.Forms.Button();
            this.TB_phone_Customer = new System.Windows.Forms.TextBox();
            this.TB_name_Customer = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Product)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TB_Transport);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CB_Select_Transport);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 376);
            this.panel1.TabIndex = 14;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // TB_Transport
            // 
            this.TB_Transport.Location = new System.Drawing.Point(326, 149);
            this.TB_Transport.Name = "TB_Transport";
            this.TB_Transport.ReadOnly = true;
            this.TB_Transport.Size = new System.Drawing.Size(45, 34);
            this.TB_Transport.TabIndex = 15;
            this.TB_Transport.Text = "0";
            this.TB_Transport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Transport.TextChanged += new System.EventHandler(this.TB_Transport_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 26);
            this.label8.TabIndex = 13;
            this.label8.Text = "Price Transport";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Select Transport";
            // 
            // CB_Select_Transport
            // 
            this.CB_Select_Transport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Select_Transport.FormattingEnabled = true;
            this.CB_Select_Transport.Location = new System.Drawing.Point(118, 149);
            this.CB_Select_Transport.Name = "CB_Select_Transport";
            this.CB_Select_Transport.Size = new System.Drawing.Size(98, 34);
            this.CB_Select_Transport.TabIndex = 11;
            this.CB_Select_Transport.SelectedIndexChanged += new System.EventHandler(this.CB_Select_Transport_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.B_Checked_Code);
            this.groupBox3.Controls.Add(this.TB_Code_UseCode);
            this.groupBox3.Controls.Add(this.TB_Console_StatusCode);
            this.groupBox3.Controls.Add(this.Chb_on_off_code);
            this.groupBox3.Location = new System.Drawing.Point(15, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 152);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "โค้ดส่วนลด";
            // 
            // B_Checked_Code
            // 
            this.B_Checked_Code.Location = new System.Drawing.Point(29, 89);
            this.B_Checked_Code.Name = "B_Checked_Code";
            this.B_Checked_Code.Size = new System.Drawing.Size(97, 41);
            this.B_Checked_Code.TabIndex = 2;
            this.B_Checked_Code.Text = "ใส่โค้ด";
            this.B_Checked_Code.UseVisualStyleBackColor = true;
            this.B_Checked_Code.Click += new System.EventHandler(this.B_Checked_Code_Click);
            // 
            // TB_Code_UseCode
            // 
            this.TB_Code_UseCode.BackColor = System.Drawing.Color.Silver;
            this.TB_Code_UseCode.Location = new System.Drawing.Point(17, 49);
            this.TB_Code_UseCode.Name = "TB_Code_UseCode";
            this.TB_Code_UseCode.ReadOnly = true;
            this.TB_Code_UseCode.Size = new System.Drawing.Size(130, 34);
            this.TB_Code_UseCode.TabIndex = 1;
            this.TB_Code_UseCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Code_UseCode.TextChanged += new System.EventHandler(this.TB_Code_UseCode_TextChanged);
            // 
            // TB_Console_StatusCode
            // 
            this.TB_Console_StatusCode.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_Console_StatusCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TB_Console_StatusCode.Location = new System.Drawing.Point(172, 20);
            this.TB_Console_StatusCode.Multiline = true;
            this.TB_Console_StatusCode.Name = "TB_Console_StatusCode";
            this.TB_Console_StatusCode.ReadOnly = true;
            this.TB_Console_StatusCode.Size = new System.Drawing.Size(156, 110);
            this.TB_Console_StatusCode.TabIndex = 1;
            this.TB_Console_StatusCode.Text = "    Code : -\r\n  Status : -\r\nDiscount : 0 %\r\n";
            // 
            // Chb_on_off_code
            // 
            this.Chb_on_off_code.AutoSize = true;
            this.Chb_on_off_code.Location = new System.Drawing.Point(24, 22);
            this.Chb_on_off_code.Name = "Chb_on_off_code";
            this.Chb_on_off_code.Size = new System.Drawing.Size(123, 30);
            this.Chb_on_off_code.TabIndex = 0;
            this.Chb_on_off_code.Text = "เปิด/ปิด การใช้งาน";
            this.Chb_on_off_code.UseVisualStyleBackColor = true;
            this.Chb_on_off_code.CheckedChanged += new System.EventHandler(this.Chb_on_off_code_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.B_Confirm_Order);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TB_Price_Transport);
            this.groupBox2.Controls.Add(this.B_ClearTab);
            this.groupBox2.Controls.Add(this.B_AddProduct);
            this.groupBox2.Controls.Add(this.TB_Balance_product);
            this.groupBox2.Controls.Add(this.B_list_Product);
            this.groupBox2.Controls.Add(this.DGV_Product);
            this.groupBox2.Controls.Add(this.TB_Select_Product);
            this.groupBox2.Location = new System.Drawing.Point(381, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 328);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "รายการสินค้า";
            // 
            // B_Confirm_Order
            // 
            this.B_Confirm_Order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B_Confirm_Order.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_Confirm_Order.BackgroundImage")));
            this.B_Confirm_Order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Confirm_Order.Location = new System.Drawing.Point(528, 246);
            this.B_Confirm_Order.Name = "B_Confirm_Order";
            this.B_Confirm_Order.Size = new System.Drawing.Size(116, 67);
            this.B_Confirm_Order.TabIndex = 9;
            this.B_Confirm_Order.Text = "Confirm Order (F1)";
            this.B_Confirm_Order.UseVisualStyleBackColor = false;
            this.B_Confirm_Order.Click += new System.EventHandler(this.B_Confirm_Order_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "ยอดรวม";
            // 
            // TB_Price_Transport
            // 
            this.TB_Price_Transport.Location = new System.Drawing.Point(-63, 144);
            this.TB_Price_Transport.Name = "TB_Price_Transport";
            this.TB_Price_Transport.ReadOnly = true;
            this.TB_Price_Transport.Size = new System.Drawing.Size(57, 34);
            this.TB_Price_Transport.TabIndex = 12;
            // 
            // B_ClearTab
            // 
            this.B_ClearTab.Location = new System.Drawing.Point(528, 202);
            this.B_ClearTab.Name = "B_ClearTab";
            this.B_ClearTab.Size = new System.Drawing.Size(87, 38);
            this.B_ClearTab.TabIndex = 13;
            this.B_ClearTab.Text = "ล้างหน้าต่าง";
            this.B_ClearTab.UseVisualStyleBackColor = true;
            this.B_ClearTab.Click += new System.EventHandler(this.B_ClearTab_Click);
            // 
            // B_AddProduct
            // 
            this.B_AddProduct.Location = new System.Drawing.Point(514, 23);
            this.B_AddProduct.Name = "B_AddProduct";
            this.B_AddProduct.Size = new System.Drawing.Size(130, 35);
            this.B_AddProduct.TabIndex = 8;
            this.B_AddProduct.Text = "เพิ่มรายการ (Enter)";
            this.B_AddProduct.UseVisualStyleBackColor = true;
            this.B_AddProduct.Click += new System.EventHandler(this.B_AddProduct_Click);
            // 
            // TB_Balance_product
            // 
            this.TB_Balance_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TB_Balance_product.Location = new System.Drawing.Point(527, 105);
            this.TB_Balance_product.Name = "TB_Balance_product";
            this.TB_Balance_product.ReadOnly = true;
            this.TB_Balance_product.Size = new System.Drawing.Size(87, 34);
            this.TB_Balance_product.TabIndex = 5;
            this.TB_Balance_product.Text = "0";
            this.TB_Balance_product.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Balance_product.TextChanged += new System.EventHandler(this.TB_name_Customer_TextChanged);
            // 
            // B_list_Product
            // 
            this.B_list_Product.Location = new System.Drawing.Point(528, 161);
            this.B_list_Product.Name = "B_list_Product";
            this.B_list_Product.Size = new System.Drawing.Size(87, 35);
            this.B_list_Product.TabIndex = 8;
            this.B_list_Product.Text = "รายการสินค้า";
            this.B_list_Product.UseVisualStyleBackColor = true;
            this.B_list_Product.Click += new System.EventHandler(this.B_list_Product_Click);
            // 
            // DGV_Product
            // 
            this.DGV_Product.AllowUserToAddRows = false;
            this.DGV_Product.AllowUserToDeleteRows = false;
            this.DGV_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProduct,
            this.nameProduct,
            this.Quantity,
            this.Column1,
            this.Column2,
            this.Column3});
            this.DGV_Product.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV_Product.Location = new System.Drawing.Point(28, 65);
            this.DGV_Product.Name = "DGV_Product";
            this.DGV_Product.Size = new System.Drawing.Size(494, 250);
            this.DGV_Product.TabIndex = 7;
            this.DGV_Product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Product_CellContentClick);
            this.DGV_Product.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Product_CellEndEdit);
            this.DGV_Product.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DGV_Product_CellValidating);
            this.DGV_Product.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGV_Product_MouseClick);
            // 
            // IDProduct
            // 
            this.IDProduct.HeaderText = "รหัสสินค้า";
            this.IDProduct.Name = "IDProduct";
            this.IDProduct.ReadOnly = true;
            this.IDProduct.Width = 120;
            // 
            // nameProduct
            // 
            this.nameProduct.HeaderText = "ชื่อสินค้า";
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.ReadOnly = true;
            this.nameProduct.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "จำนวน";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ราคา";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ProductID";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Priceone";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // TB_Select_Product
            // 
            this.TB_Select_Product.Location = new System.Drawing.Point(28, 25);
            this.TB_Select_Product.Name = "TB_Select_Product";
            this.TB_Select_Product.Size = new System.Drawing.Size(480, 34);
            this.TB_Select_Product.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.B_Select_Customer);
            this.groupBox1.Controls.Add(this.TB_phone_Customer);
            this.groupBox1.Controls.Add(this.TB_name_Customer);
            this.groupBox1.Location = new System.Drawing.Point(15, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 115);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "รายชื่อผู้ซื้อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "เบอร์โทรศัพท์";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "ชื่อ-นามสกุล";
            // 
            // B_Select_Customer
            // 
            this.B_Select_Customer.BackColor = System.Drawing.Color.Transparent;
            this.B_Select_Customer.BackgroundImage = global::ShopApp.Properties.Resources.magnifyingglass_23798;
            this.B_Select_Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Select_Customer.Location = new System.Drawing.Point(285, 26);
            this.B_Select_Customer.Name = "B_Select_Customer";
            this.B_Select_Customer.Size = new System.Drawing.Size(46, 39);
            this.B_Select_Customer.TabIndex = 3;
            this.B_Select_Customer.UseVisualStyleBackColor = false;
            this.B_Select_Customer.Click += new System.EventHandler(this.B_Select_Customer_Click);
            // 
            // TB_phone_Customer
            // 
            this.TB_phone_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TB_phone_Customer.Location = new System.Drawing.Point(108, 66);
            this.TB_phone_Customer.Name = "TB_phone_Customer";
            this.TB_phone_Customer.ReadOnly = true;
            this.TB_phone_Customer.Size = new System.Drawing.Size(171, 34);
            this.TB_phone_Customer.TabIndex = 5;
            this.TB_phone_Customer.TextChanged += new System.EventHandler(this.TB_id_Customer_TextChanged);
            // 
            // TB_name_Customer
            // 
            this.TB_name_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TB_name_Customer.Location = new System.Drawing.Point(108, 26);
            this.TB_name_Customer.Name = "TB_name_Customer";
            this.TB_name_Customer.ReadOnly = true;
            this.TB_name_Customer.Size = new System.Drawing.Size(171, 34);
            this.TB_name_Customer.TabIndex = 5;
            this.TB_name_Customer.TextChanged += new System.EventHandler(this.TB_name_Customer_TextChanged);
            // 
            // Product_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 400);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("AngsanaUPC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Product_Sale";
            this.Text = "Product_Sale";
            this.Load += new System.EventHandler(this.Product_Sale_Load);
            this.SizeChanged += new System.EventHandler(this.Product_Sale_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Product_Sale_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Product)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button B_ClearTab;
        private System.Windows.Forms.Button B_Confirm_Order;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button B_Checked_Code;
        private System.Windows.Forms.TextBox TB_Code_UseCode;
        private System.Windows.Forms.TextBox TB_Console_StatusCode;
        private System.Windows.Forms.CheckBox Chb_on_off_code;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button B_AddProduct;
        private System.Windows.Forms.Button B_list_Product;
        private System.Windows.Forms.DataGridView DGV_Product;
        private System.Windows.Forms.TextBox TB_Select_Product;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Select_Customer;
        private System.Windows.Forms.TextBox TB_phone_Customer;
        private System.Windows.Forms.TextBox TB_name_Customer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Balance_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CB_Select_Transport;
        private System.Windows.Forms.TextBox TB_Price_Transport;
        private System.Windows.Forms.TextBox TB_Transport;
    }
}