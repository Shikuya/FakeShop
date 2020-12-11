namespace ShopApp.Shop
{
    partial class SaleProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleProduct));
            this.CB_SaleProduct_Show_Cateorie = new System.Windows.Forms.ComboBox();
            this.CB_SaleProduct_Show_Brand = new System.Windows.Forms.ComboBox();
            this.CB_SaleProduct_Show_Product = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_SaleProduct_Show_Quantity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Console_produc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Show_Customer_IDcard = new System.Windows.Forms.TextBox();
            this.TB_Show_Customer_name = new System.Windows.Forms.TextBox();
            this.B_Select_Customer = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.B_Checked_Code = new System.Windows.Forms.Button();
            this.TB_Code_UseCode = new System.Windows.Forms.TextBox();
            this.TB_Console_Code = new System.Windows.Forms.TextBox();
            this.ChB_Checked_Code = new System.Windows.Forms.CheckBox();
            this.B_Confirm_Informaion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CB_Select_Transport = new System.Windows.Forms.ComboBox();
            this.TB_Price_Transport = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_SaleProduct_Show_Cateorie
            // 
            this.CB_SaleProduct_Show_Cateorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_SaleProduct_Show_Cateorie.FormattingEnabled = true;
            this.CB_SaleProduct_Show_Cateorie.Location = new System.Drawing.Point(81, 33);
            this.CB_SaleProduct_Show_Cateorie.Name = "CB_SaleProduct_Show_Cateorie";
            this.CB_SaleProduct_Show_Cateorie.Size = new System.Drawing.Size(131, 34);
            this.CB_SaleProduct_Show_Cateorie.TabIndex = 0;
            this.CB_SaleProduct_Show_Cateorie.SelectedIndexChanged += new System.EventHandler(this.CB_SaleProduct_Show_Cateorie_SelectedIndexChanged);
            // 
            // CB_SaleProduct_Show_Brand
            // 
            this.CB_SaleProduct_Show_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_SaleProduct_Show_Brand.FormattingEnabled = true;
            this.CB_SaleProduct_Show_Brand.Location = new System.Drawing.Point(270, 33);
            this.CB_SaleProduct_Show_Brand.Name = "CB_SaleProduct_Show_Brand";
            this.CB_SaleProduct_Show_Brand.Size = new System.Drawing.Size(149, 34);
            this.CB_SaleProduct_Show_Brand.TabIndex = 0;
            this.CB_SaleProduct_Show_Brand.SelectedIndexChanged += new System.EventHandler(this.CB_SaleProduct_Show_Brand_SelectedIndexChanged);
            // 
            // CB_SaleProduct_Show_Product
            // 
            this.CB_SaleProduct_Show_Product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_SaleProduct_Show_Product.FormattingEnabled = true;
            this.CB_SaleProduct_Show_Product.Location = new System.Drawing.Point(486, 33);
            this.CB_SaleProduct_Show_Product.Name = "CB_SaleProduct_Show_Product";
            this.CB_SaleProduct_Show_Product.Size = new System.Drawing.Size(127, 34);
            this.CB_SaleProduct_Show_Product.TabIndex = 0;
            this.CB_SaleProduct_Show_Product.SelectedIndexChanged += new System.EventHandler(this.CB_SaleProduct_Show_Product_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_SaleProduct_Show_Quantity);
            this.groupBox1.Controls.Add(this.CB_SaleProduct_Show_Product);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CB_SaleProduct_Show_Cateorie);
            this.groupBox1.Controls.Add(this.CB_SaleProduct_Show_Brand);
            this.groupBox1.Location = new System.Drawing.Point(21, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Product";
            // 
            // CB_SaleProduct_Show_Quantity
            // 
            this.CB_SaleProduct_Show_Quantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_SaleProduct_Show_Quantity.FormattingEnabled = true;
            this.CB_SaleProduct_Show_Quantity.Location = new System.Drawing.Point(681, 33);
            this.CB_SaleProduct_Show_Quantity.Name = "CB_SaleProduct_Show_Quantity";
            this.CB_SaleProduct_Show_Quantity.Size = new System.Drawing.Size(49, 34);
            this.CB_SaleProduct_Show_Quantity.TabIndex = 0;
            this.CB_SaleProduct_Show_Quantity.SelectedIndexChanged += new System.EventHandler(this.CB_SaleProduct_Show_Quantity_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(619, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categorie";
            // 
            // TB_Console_produc
            // 
            this.TB_Console_produc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_Console_produc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TB_Console_produc.Location = new System.Drawing.Point(32, 106);
            this.TB_Console_produc.Multiline = true;
            this.TB_Console_produc.Name = "TB_Console_produc";
            this.TB_Console_produc.ReadOnly = true;
            this.TB_Console_produc.Size = new System.Drawing.Size(240, 111);
            this.TB_Console_produc.TabIndex = 1;
            this.TB_Console_produc.TextChanged += new System.EventHandler(this.TB_Console_produc_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TB_Show_Customer_IDcard);
            this.groupBox2.Controls.Add(this.TB_Show_Customer_name);
            this.groupBox2.Controls.Add(this.B_Select_Customer);
            this.groupBox2.Location = new System.Drawing.Point(21, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 170);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "เลขบัตร";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "ชื่อ-สกุล";
            // 
            // TB_Show_Customer_IDcard
            // 
            this.TB_Show_Customer_IDcard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TB_Show_Customer_IDcard.Location = new System.Drawing.Point(67, 118);
            this.TB_Show_Customer_IDcard.Name = "TB_Show_Customer_IDcard";
            this.TB_Show_Customer_IDcard.ReadOnly = true;
            this.TB_Show_Customer_IDcard.Size = new System.Drawing.Size(184, 34);
            this.TB_Show_Customer_IDcard.TabIndex = 3;
            // 
            // TB_Show_Customer_name
            // 
            this.TB_Show_Customer_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TB_Show_Customer_name.Location = new System.Drawing.Point(67, 78);
            this.TB_Show_Customer_name.Name = "TB_Show_Customer_name";
            this.TB_Show_Customer_name.ReadOnly = true;
            this.TB_Show_Customer_name.Size = new System.Drawing.Size(184, 34);
            this.TB_Show_Customer_name.TabIndex = 3;
            // 
            // B_Select_Customer
            // 
            this.B_Select_Customer.BackColor = System.Drawing.Color.Transparent;
            this.B_Select_Customer.BackgroundImage = global::ShopApp.Properties.Resources.magnifyingglass_23798;
            this.B_Select_Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Select_Customer.Location = new System.Drawing.Point(16, 33);
            this.B_Select_Customer.Name = "B_Select_Customer";
            this.B_Select_Customer.Size = new System.Drawing.Size(46, 39);
            this.B_Select_Customer.TabIndex = 2;
            this.B_Select_Customer.UseVisualStyleBackColor = false;
            this.B_Select_Customer.Click += new System.EventHandler(this.B_Select_Customer_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.B_Checked_Code);
            this.groupBox3.Controls.Add(this.TB_Code_UseCode);
            this.groupBox3.Controls.Add(this.TB_Console_Code);
            this.groupBox3.Controls.Add(this.ChB_Checked_Code);
            this.groupBox3.Location = new System.Drawing.Point(288, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 263);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Code";
            // 
            // B_Checked_Code
            // 
            this.B_Checked_Code.Location = new System.Drawing.Point(49, 112);
            this.B_Checked_Code.Name = "B_Checked_Code";
            this.B_Checked_Code.Size = new System.Drawing.Size(78, 39);
            this.B_Checked_Code.TabIndex = 2;
            this.B_Checked_Code.Text = "Checked";
            this.B_Checked_Code.UseVisualStyleBackColor = true;
            this.B_Checked_Code.Click += new System.EventHandler(this.B_Checked_Code_Click);
            // 
            // TB_Code_UseCode
            // 
            this.TB_Code_UseCode.BackColor = System.Drawing.Color.Silver;
            this.TB_Code_UseCode.Location = new System.Drawing.Point(19, 69);
            this.TB_Code_UseCode.Name = "TB_Code_UseCode";
            this.TB_Code_UseCode.ReadOnly = true;
            this.TB_Code_UseCode.Size = new System.Drawing.Size(130, 34);
            this.TB_Code_UseCode.TabIndex = 1;
            // 
            // TB_Console_Code
            // 
            this.TB_Console_Code.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_Console_Code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TB_Console_Code.Location = new System.Drawing.Point(19, 157);
            this.TB_Console_Code.Multiline = true;
            this.TB_Console_Code.Name = "TB_Console_Code";
            this.TB_Console_Code.ReadOnly = true;
            this.TB_Console_Code.Size = new System.Drawing.Size(143, 86);
            this.TB_Console_Code.TabIndex = 1;
            // 
            // ChB_Checked_Code
            // 
            this.ChB_Checked_Code.AutoSize = true;
            this.ChB_Checked_Code.Location = new System.Drawing.Point(19, 33);
            this.ChB_Checked_Code.Name = "ChB_Checked_Code";
            this.ChB_Checked_Code.Size = new System.Drawing.Size(125, 30);
            this.ChB_Checked_Code.TabIndex = 0;
            this.ChB_Checked_Code.Text = "Use Code Discont";
            this.ChB_Checked_Code.UseVisualStyleBackColor = true;
            this.ChB_Checked_Code.CheckedChanged += new System.EventHandler(this.ChB_Checked_Code_CheckedChanged);
            // 
            // B_Confirm_Informaion
            // 
            this.B_Confirm_Informaion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.B_Confirm_Informaion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_Confirm_Informaion.BackgroundImage")));
            this.B_Confirm_Informaion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Confirm_Informaion.Location = new System.Drawing.Point(628, 242);
            this.B_Confirm_Informaion.Name = "B_Confirm_Informaion";
            this.B_Confirm_Informaion.Size = new System.Drawing.Size(151, 71);
            this.B_Confirm_Informaion.TabIndex = 5;
            this.B_Confirm_Informaion.Text = "Confirm Order";
            this.B_Confirm_Informaion.UseVisualStyleBackColor = false;
            this.B_Confirm_Informaion.Click += new System.EventHandler(this.B_Confirm_Informaion_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.B_Confirm_Informaion);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.TB_Console_produc);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 398);
            this.panel1.TabIndex = 6;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.TB_Price_Transport);
            this.groupBox4.Controls.Add(this.CB_Select_Transport);
            this.groupBox4.Location = new System.Drawing.Point(478, 223);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(135, 165);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transport";
            // 
            // CB_Select_Transport
            // 
            this.CB_Select_Transport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Select_Transport.FormattingEnabled = true;
            this.CB_Select_Transport.Location = new System.Drawing.Point(19, 50);
            this.CB_Select_Transport.Name = "CB_Select_Transport";
            this.CB_Select_Transport.Size = new System.Drawing.Size(98, 34);
            this.CB_Select_Transport.TabIndex = 0;
            this.CB_Select_Transport.SelectedIndexChanged += new System.EventHandler(this.CB_Select_Transport_SelectedIndexChanged);
            // 
            // TB_Price_Transport
            // 
            this.TB_Price_Transport.Location = new System.Drawing.Point(19, 116);
            this.TB_Price_Transport.Name = "TB_Price_Transport";
            this.TB_Price_Transport.ReadOnly = true;
            this.TB_Price_Transport.Size = new System.Drawing.Size(98, 34);
            this.TB_Price_Transport.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "Select Transport";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Price Transport";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(619, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 52);
            this.label9.TabIndex = 2;
            this.label9.Text = "**ในกรณีที่ไม่ได้ใช้\r\nขนส่งไม่จำเป็นต้องเลือก\r\n";
            // 
            // SaleProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(828, 422);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("AngsanaUPC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "SaleProduct";
            this.Text = "SaleProduct";
            this.Load += new System.EventHandler(this.ChB_Checked_Code_CheckedChanged);
            this.SizeChanged += new System.EventHandler(this.SaleProduct_SizeChanged);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SaleProduct_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_SaleProduct_Show_Cateorie;
        private System.Windows.Forms.ComboBox CB_SaleProduct_Show_Brand;
        private System.Windows.Forms.ComboBox CB_SaleProduct_Show_Product;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_Console_produc;
        private System.Windows.Forms.Button B_Select_Customer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Show_Customer_IDcard;
        private System.Windows.Forms.TextBox TB_Show_Customer_name;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button B_Checked_Code;
        private System.Windows.Forms.TextBox TB_Code_UseCode;
        private System.Windows.Forms.TextBox TB_Console_Code;
        private System.Windows.Forms.CheckBox ChB_Checked_Code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button B_Confirm_Informaion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CB_SaleProduct_Show_Quantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Price_Transport;
        private System.Windows.Forms.ComboBox CB_Select_Transport;
        private System.Windows.Forms.Label label9;
    }
}