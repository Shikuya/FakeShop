namespace ShopApp.Shop.add
{
    partial class addTransport
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
            this.B_transport_add = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.TB_transport_Detail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_transport_name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_transport_add
            // 
            this.B_transport_add.Location = new System.Drawing.Point(143, 197);
            this.B_transport_add.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.B_transport_add.Name = "B_transport_add";
            this.B_transport_add.Size = new System.Drawing.Size(166, 59);
            this.B_transport_add.TabIndex = 8;
            this.B_transport_add.Text = "Add Transport";
            this.B_transport_add.UseVisualStyleBackColor = true;
            this.B_transport_add.Click += new System.EventHandler(this.B_transport_add_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "TransportDetail :";
            // 
            // TB_transport_Detail
            // 
            this.TB_transport_Detail.Location = new System.Drawing.Point(143, 55);
            this.TB_transport_Detail.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TB_transport_Detail.Multiline = true;
            this.TB_transport_Detail.Name = "TB_transport_Detail";
            this.TB_transport_Detail.Size = new System.Drawing.Size(166, 119);
            this.TB_transport_Detail.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Transportname :";
            // 
            // TB_transport_name
            // 
            this.TB_transport_name.Location = new System.Drawing.Point(143, 9);
            this.TB_transport_name.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TB_transport_name.Name = "TB_transport_name";
            this.TB_transport_name.Size = new System.Drawing.Size(166, 34);
            this.TB_transport_name.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B_transport_add);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.TB_transport_Detail);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.TB_transport_name);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 286);
            this.panel1.TabIndex = 10;
            // 
            // addTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 315);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("AngsanaUPC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "addTransport";
            this.Text = "addTransport";
            this.SizeChanged += new System.EventHandler(this.addTransport_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_transport_add;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TB_transport_Detail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_transport_name;
        private System.Windows.Forms.Panel panel1;
    }
}