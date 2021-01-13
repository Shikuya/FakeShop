
namespace ShopApp.Shop
{
    partial class kidmoney
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
            this.TB_Balance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_getmoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.B_Confirm = new System.Windows.Forms.Button();
            this.TB_ton = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_TransportPrice = new System.Windows.Forms.TextBox();
            this.TB_Transport = new System.Windows.Forms.TextBox();
            this.TB_PriceProduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_DisCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Balance
            // 
            this.TB_Balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TB_Balance.Location = new System.Drawing.Point(184, 127);
            this.TB_Balance.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TB_Balance.Name = "TB_Balance";
            this.TB_Balance.ReadOnly = true;
            this.TB_Balance.Size = new System.Drawing.Size(142, 34);
            this.TB_Balance.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "ยอดที่ต้องชำระรวม";
            // 
            // TB_getmoney
            // 
            this.TB_getmoney.BackColor = System.Drawing.Color.White;
            this.TB_getmoney.Location = new System.Drawing.Point(184, 170);
            this.TB_getmoney.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TB_getmoney.Name = "TB_getmoney";
            this.TB_getmoney.Size = new System.Drawing.Size(142, 34);
            this.TB_getmoney.TabIndex = 0;
            this.TB_getmoney.TextChanged += new System.EventHandler(this.TB_getmoney_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "ยอดที่รับมา";
            // 
            // B_Confirm
            // 
            this.B_Confirm.Location = new System.Drawing.Point(341, 170);
            this.B_Confirm.Name = "B_Confirm";
            this.B_Confirm.Size = new System.Drawing.Size(107, 34);
            this.B_Confirm.TabIndex = 1;
            this.B_Confirm.Text = "ยืนยันยอดที่รับ";
            this.B_Confirm.UseVisualStyleBackColor = true;
            this.B_Confirm.Click += new System.EventHandler(this.B_Confirm_Click);
            // 
            // TB_ton
            // 
            this.TB_ton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TB_ton.Location = new System.Drawing.Point(184, 214);
            this.TB_ton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TB_ton.Name = "TB_ton";
            this.TB_ton.ReadOnly = true;
            this.TB_ton.Size = new System.Drawing.Size(142, 34);
            this.TB_ton.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "ทอน";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B_Confirm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TB_ton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TB_getmoney);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TB_DisCount);
            this.panel1.Controls.Add(this.TB_TransportPrice);
            this.panel1.Controls.Add(this.TB_PriceProduct);
            this.panel1.Controls.Add(this.TB_Transport);
            this.panel1.Controls.Add(this.TB_Balance);
            this.panel1.Location = new System.Drawing.Point(15, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 307);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "ราคาค่าส่ง";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "ขนส่ง";
            // 
            // TB_TransportPrice
            // 
            this.TB_TransportPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TB_TransportPrice.Location = new System.Drawing.Point(283, 27);
            this.TB_TransportPrice.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TB_TransportPrice.Name = "TB_TransportPrice";
            this.TB_TransportPrice.ReadOnly = true;
            this.TB_TransportPrice.Size = new System.Drawing.Size(142, 34);
            this.TB_TransportPrice.TabIndex = 10;
            // 
            // TB_Transport
            // 
            this.TB_Transport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TB_Transport.Location = new System.Drawing.Point(64, 27);
            this.TB_Transport.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TB_Transport.Name = "TB_Transport";
            this.TB_Transport.ReadOnly = true;
            this.TB_Transport.Size = new System.Drawing.Size(142, 34);
            this.TB_Transport.TabIndex = 10;
            this.TB_Transport.TextChanged += new System.EventHandler(this.TB_Transport_TextChanged);
            // 
            // TB_PriceProduct
            // 
            this.TB_PriceProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TB_PriceProduct.Location = new System.Drawing.Point(114, 77);
            this.TB_PriceProduct.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TB_PriceProduct.Name = "TB_PriceProduct";
            this.TB_PriceProduct.ReadOnly = true;
            this.TB_PriceProduct.Size = new System.Drawing.Size(92, 34);
            this.TB_PriceProduct.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "ราคาสินค้ารวม";
            // 
            // TB_DisCount
            // 
            this.TB_DisCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TB_DisCount.Location = new System.Drawing.Point(287, 77);
            this.TB_DisCount.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TB_DisCount.Name = "TB_DisCount";
            this.TB_DisCount.ReadOnly = true;
            this.TB_DisCount.Size = new System.Drawing.Size(138, 34);
            this.TB_DisCount.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "ลดราคา %";
            // 
            // kidmoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 334);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("AngsanaUPC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "kidmoney";
            this.Text = "kidmoney";
            this.Load += new System.EventHandler(this.kidmoney_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Balance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_getmoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_Confirm;
        private System.Windows.Forms.TextBox TB_ton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_TransportPrice;
        private System.Windows.Forms.TextBox TB_Transport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_PriceProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_DisCount;
    }
}