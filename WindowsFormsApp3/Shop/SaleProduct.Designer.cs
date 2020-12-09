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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_SaleProduct_Show_Cateorie
            // 
            this.CB_SaleProduct_Show_Cateorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_SaleProduct_Show_Cateorie.FormattingEnabled = true;
            this.CB_SaleProduct_Show_Cateorie.Location = new System.Drawing.Point(91, 33);
            this.CB_SaleProduct_Show_Cateorie.Name = "CB_SaleProduct_Show_Cateorie";
            this.CB_SaleProduct_Show_Cateorie.Size = new System.Drawing.Size(149, 34);
            this.CB_SaleProduct_Show_Cateorie.TabIndex = 0;
            this.CB_SaleProduct_Show_Cateorie.SelectedIndexChanged += new System.EventHandler(this.CB_SaleProduct_Show_Cateorie_SelectedIndexChanged);
            // 
            // CB_SaleProduct_Show_Brand
            // 
            this.CB_SaleProduct_Show_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_SaleProduct_Show_Brand.FormattingEnabled = true;
            this.CB_SaleProduct_Show_Brand.Location = new System.Drawing.Point(314, 33);
            this.CB_SaleProduct_Show_Brand.Name = "CB_SaleProduct_Show_Brand";
            this.CB_SaleProduct_Show_Brand.Size = new System.Drawing.Size(149, 34);
            this.CB_SaleProduct_Show_Brand.TabIndex = 0;
            this.CB_SaleProduct_Show_Brand.SelectedIndexChanged += new System.EventHandler(this.CB_SaleProduct_Show_Brand_SelectedIndexChanged);
            // 
            // CB_SaleProduct_Show_Product
            // 
            this.CB_SaleProduct_Show_Product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_SaleProduct_Show_Product.FormattingEnabled = true;
            this.CB_SaleProduct_Show_Product.Location = new System.Drawing.Point(549, 33);
            this.CB_SaleProduct_Show_Product.Name = "CB_SaleProduct_Show_Product";
            this.CB_SaleProduct_Show_Product.Size = new System.Drawing.Size(149, 34);
            this.CB_SaleProduct_Show_Product.TabIndex = 0;
            this.CB_SaleProduct_Show_Product.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_SaleProduct_Show_Product);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CB_SaleProduct_Show_Cateorie);
            this.groupBox1.Controls.Add(this.CB_SaleProduct_Show_Brand);
            this.groupBox1.Location = new System.Drawing.Point(21, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 36);
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
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.B_Checked_Code);
            this.groupBox3.Controls.Add(this.TB_Code_UseCode);
            this.groupBox3.Controls.Add(this.TB_Console_Code);
            this.groupBox3.Controls.Add(this.ChB_Checked_Code);
            this.groupBox3.Location = new System.Drawing.Point(286, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 249);
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
            this.B_Confirm_Informaion.Location = new System.Drawing.Point(513, 284);
            this.B_Confirm_Informaion.Name = "B_Confirm_Informaion";
            this.B_Confirm_Informaion.Size = new System.Drawing.Size(181, 86);
            this.B_Confirm_Informaion.TabIndex = 5;
            this.B_Confirm_Informaion.Text = "Confirm Order";
            this.B_Confirm_Informaion.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B_Confirm_Informaion);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.TB_Console_produc);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 395);
            this.panel1.TabIndex = 6;
            // 
            // SaleProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(763, 419);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("AngsanaUPC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "SaleProduct";
            this.Text = "SaleProduct";
            this.Load += new System.EventHandler(this.SaleProduct_Load);
            this.SizeChanged += new System.EventHandler(this.SaleProduct_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}