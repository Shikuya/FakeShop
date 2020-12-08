
namespace ShopApp.Shop.Shop_edit
{
    partial class editCustomer
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
            this.B_Customer_Select = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Customer_Show_IDcard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Customer_Show_name = new System.Windows.Forms.TextBox();
            this.TB_Customer_Change_name = new System.Windows.Forms.TextBox();
            this.TB_Customer_Change_Idcard = new System.Windows.Forms.TextBox();
            this.TB_Customer_Change_Address = new System.Windows.Forms.TextBox();
            this.TB_Customer_Change_PhoneNum = new System.Windows.Forms.TextBox();
            this.B_Customer_Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_Customer_Select
            // 
            this.B_Customer_Select.BackColor = System.Drawing.Color.Transparent;
            this.B_Customer_Select.BackgroundImage = global::ShopApp.Properties.Resources.magnifyingglass_23798;
            this.B_Customer_Select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Customer_Select.Location = new System.Drawing.Point(9, 7);
            this.B_Customer_Select.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.B_Customer_Select.Name = "B_Customer_Select";
            this.B_Customer_Select.Size = new System.Drawing.Size(52, 50);
            this.B_Customer_Select.TabIndex = 0;
            this.B_Customer_Select.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "เลขบัตรประชาชน";
            // 
            // TB_Customer_Show_IDcard
            // 
            this.TB_Customer_Show_IDcard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TB_Customer_Show_IDcard.Location = new System.Drawing.Point(202, 53);
            this.TB_Customer_Show_IDcard.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TB_Customer_Show_IDcard.Name = "TB_Customer_Show_IDcard";
            this.TB_Customer_Show_IDcard.ReadOnly = true;
            this.TB_Customer_Show_IDcard.Size = new System.Drawing.Size(261, 34);
            this.TB_Customer_Show_IDcard.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "ชื่อ - นามสกุล";
            // 
            // TB_Customer_Show_name
            // 
            this.TB_Customer_Show_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TB_Customer_Show_name.Location = new System.Drawing.Point(202, 7);
            this.TB_Customer_Show_name.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TB_Customer_Show_name.Name = "TB_Customer_Show_name";
            this.TB_Customer_Show_name.ReadOnly = true;
            this.TB_Customer_Show_name.Size = new System.Drawing.Size(261, 34);
            this.TB_Customer_Show_name.TabIndex = 3;
            // 
            // TB_Customer_Change_name
            // 
            this.TB_Customer_Change_name.Location = new System.Drawing.Point(193, 27);
            this.TB_Customer_Change_name.Name = "TB_Customer_Change_name";
            this.TB_Customer_Change_name.Size = new System.Drawing.Size(286, 34);
            this.TB_Customer_Change_name.TabIndex = 6;
            // 
            // TB_Customer_Change_Idcard
            // 
            this.TB_Customer_Change_Idcard.Location = new System.Drawing.Point(331, 107);
            this.TB_Customer_Change_Idcard.Name = "TB_Customer_Change_Idcard";
            this.TB_Customer_Change_Idcard.Size = new System.Drawing.Size(148, 34);
            this.TB_Customer_Change_Idcard.TabIndex = 6;
            // 
            // TB_Customer_Change_Address
            // 
            this.TB_Customer_Change_Address.Location = new System.Drawing.Point(111, 67);
            this.TB_Customer_Change_Address.Name = "TB_Customer_Change_Address";
            this.TB_Customer_Change_Address.Size = new System.Drawing.Size(368, 34);
            this.TB_Customer_Change_Address.TabIndex = 6;
            // 
            // TB_Customer_Change_PhoneNum
            // 
            this.TB_Customer_Change_PhoneNum.Location = new System.Drawing.Point(65, 107);
            this.TB_Customer_Change_PhoneNum.Name = "TB_Customer_Change_PhoneNum";
            this.TB_Customer_Change_PhoneNum.Size = new System.Drawing.Size(148, 34);
            this.TB_Customer_Change_PhoneNum.TabIndex = 6;
            this.TB_Customer_Change_PhoneNum.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // B_Customer_Save
            // 
            this.B_Customer_Save.Location = new System.Drawing.Point(356, 147);
            this.B_Customer_Save.Name = "B_Customer_Save";
            this.B_Customer_Save.Size = new System.Drawing.Size(123, 43);
            this.B_Customer_Save.TabIndex = 7;
            this.B_Customer_Save.Text = "Save";
            this.B_Customer_Save.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "เลขบัตรประชาชน";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "ชื่อ - นามสกุล";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "ที่อยู่";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "เบอร์";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupbox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TB_Customer_Show_IDcard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TB_Customer_Show_name);
            this.panel1.Controls.Add(this.B_Customer_Select);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 310);
            this.panel1.TabIndex = 8;
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.label4);
            this.groupbox1.Controls.Add(this.B_Customer_Save);
            this.groupbox1.Controls.Add(this.label5);
            this.groupbox1.Controls.Add(this.TB_Customer_Change_PhoneNum);
            this.groupbox1.Controls.Add(this.label6);
            this.groupbox1.Controls.Add(this.TB_Customer_Change_Address);
            this.groupbox1.Controls.Add(this.label3);
            this.groupbox1.Controls.Add(this.TB_Customer_Change_Idcard);
            this.groupbox1.Controls.Add(this.TB_Customer_Change_name);
            this.groupbox1.Location = new System.Drawing.Point(9, 96);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(490, 199);
            this.groupbox1.TabIndex = 8;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Change";
            // 
            // editCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 340);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("AngsanaUPC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "editCustomer";
            this.Text = "editCustomer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_Customer_Select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Customer_Show_IDcard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Customer_Show_name;
        private System.Windows.Forms.TextBox TB_Customer_Change_name;
        private System.Windows.Forms.TextBox TB_Customer_Change_Idcard;
        private System.Windows.Forms.TextBox TB_Customer_Change_Address;
        private System.Windows.Forms.TextBox TB_Customer_Change_PhoneNum;
        private System.Windows.Forms.Button B_Customer_Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupbox1;
    }
}