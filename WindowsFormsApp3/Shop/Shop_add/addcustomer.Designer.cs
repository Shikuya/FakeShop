namespace ShopApp.Shop.add
{
    partial class addcustomer
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
            this.BCustomer = new System.Windows.Forms.Button();
            this.TB_customer_Phonenum = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TB_customer_address = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TB_customer_idcard = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TB_Customer_name = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BCustomer
            // 
            this.BCustomer.Location = new System.Drawing.Point(101, 123);
            this.BCustomer.Name = "BCustomer";
            this.BCustomer.Size = new System.Drawing.Size(168, 57);
            this.BCustomer.TabIndex = 14;
            this.BCustomer.Text = "Add Customer";
            this.BCustomer.UseVisualStyleBackColor = true;
            this.BCustomer.Click += new System.EventHandler(this.BCustomer_Click);
            // 
            // TB_customer_Phonenum
            // 
            this.TB_customer_Phonenum.Location = new System.Drawing.Point(126, 97);
            this.TB_customer_Phonenum.Name = "TB_customer_Phonenum";
            this.TB_customer_Phonenum.Size = new System.Drawing.Size(143, 20);
            this.TB_customer_Phonenum.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(36, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 16);
            this.label19.TabIndex = 6;
            this.label19.Text = "Phonenum :";
            // 
            // TB_customer_address
            // 
            this.TB_customer_address.Location = new System.Drawing.Point(126, 71);
            this.TB_customer_address.Name = "TB_customer_address";
            this.TB_customer_address.Size = new System.Drawing.Size(143, 20);
            this.TB_customer_address.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(52, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 16);
            this.label18.TabIndex = 7;
            this.label18.Text = "Address :";
            // 
            // TB_customer_idcard
            // 
            this.TB_customer_idcard.Location = new System.Drawing.Point(126, 45);
            this.TB_customer_idcard.Name = "TB_customer_idcard";
            this.TB_customer_idcard.Size = new System.Drawing.Size(143, 20);
            this.TB_customer_idcard.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(55, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 16);
            this.label17.TabIndex = 9;
            this.label17.Text = "IDCaRd :";
            // 
            // TB_Customer_name
            // 
            this.TB_Customer_name.Location = new System.Drawing.Point(127, 19);
            this.TB_Customer_name.Name = "TB_Customer_name";
            this.TB_Customer_name.Size = new System.Drawing.Size(143, 20);
            this.TB_Customer_name.TabIndex = 13;
            this.TB_Customer_name.TextChanged += new System.EventHandler(this.TBnamecustomer_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 16);
            this.label16.TabIndex = 10;
            this.label16.Text = "Customername :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BCustomer);
            this.panel1.Controls.Add(this.TB_customer_Phonenum);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.TB_customer_address);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.TB_customer_idcard);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.TB_Customer_name);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 231);
            this.panel1.TabIndex = 15;
            // 
            // addcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 259);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addcustomer";
            this.Text = "   ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BCustomer;
        private System.Windows.Forms.TextBox TB_customer_Phonenum;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TB_customer_address;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TB_customer_idcard;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TB_Customer_name;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
    }
}