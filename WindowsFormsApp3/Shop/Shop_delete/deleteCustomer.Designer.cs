
namespace ShopApp.Shop.Shop_delete
{
    partial class deleteCustomer
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
            this.TB_Customer_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Customer_IDcard = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.B_Customer_Delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_Customer_Select = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Customer_name
            // 
            this.TB_Customer_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TB_Customer_name.Location = new System.Drawing.Point(121, 54);
            this.TB_Customer_name.Name = "TB_Customer_name";
            this.TB_Customer_name.ReadOnly = true;
            this.TB_Customer_name.Size = new System.Drawing.Size(224, 34);
            this.TB_Customer_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "ชื่อ - นามสกุล";
            // 
            // TB_Customer_IDcard
            // 
            this.TB_Customer_IDcard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TB_Customer_IDcard.Location = new System.Drawing.Point(121, 97);
            this.TB_Customer_IDcard.Name = "TB_Customer_IDcard";
            this.TB_Customer_IDcard.ReadOnly = true;
            this.TB_Customer_IDcard.Size = new System.Drawing.Size(224, 34);
            this.TB_Customer_IDcard.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "เลขบัตรประชาชน";
            // 
            // B_Customer_Delete
            // 
            this.B_Customer_Delete.Location = new System.Drawing.Point(159, 137);
            this.B_Customer_Delete.Name = "B_Customer_Delete";
            this.B_Customer_Delete.Size = new System.Drawing.Size(155, 64);
            this.B_Customer_Delete.TabIndex = 3;
            this.B_Customer_Delete.Text = "Delete Customer\r\n(Enter)";
            this.B_Customer_Delete.UseVisualStyleBackColor = true;
            this.B_Customer_Delete.SizeChanged += new System.EventHandler(this.B_Customer_Delete_SizeChanged);
            this.B_Customer_Delete.Click += new System.EventHandler(this.B_Customer_Delete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B_Customer_Delete);
            this.panel1.Controls.Add(this.B_Customer_Select);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TB_Customer_IDcard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TB_Customer_name);
            this.panel1.Location = new System.Drawing.Point(10, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 225);
            this.panel1.TabIndex = 4;
            // 
            // B_Customer_Select
            // 
            this.B_Customer_Select.BackColor = System.Drawing.Color.Transparent;
            this.B_Customer_Select.BackgroundImage = global::ShopApp.Properties.Resources.magnifyingglass_23798;
            this.B_Customer_Select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Customer_Select.Location = new System.Drawing.Point(351, 47);
            this.B_Customer_Select.Name = "B_Customer_Select";
            this.B_Customer_Select.Size = new System.Drawing.Size(50, 46);
            this.B_Customer_Select.TabIndex = 2;
            this.B_Customer_Select.UseVisualStyleBackColor = false;
            this.B_Customer_Select.Click += new System.EventHandler(this.B_Customer_Select_Click);
            // 
            // deleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 306);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("AngsanaUPC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "deleteCustomer";
            this.Text = "deleteCustomer";
            this.Load += new System.EventHandler(this.deleteCustomer_Load);
            this.SizeChanged += new System.EventHandler(this.deleteCustomer_SizeChanged);
            this.MouseHover += new System.EventHandler(this.deleteCustomer_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.deleteCustomer_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Customer_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Customer_Select;
        private System.Windows.Forms.TextBox TB_Customer_IDcard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_Customer_Delete;
        private System.Windows.Forms.Panel panel1;
    }
}