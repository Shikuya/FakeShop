
namespace ShopApp.Shop.Shop_delete
{
    partial class deleteBrand
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
            this.CB_Brand_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Brand_Delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_Brand_name
            // 
            this.CB_Brand_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Brand_name.FormattingEnabled = true;
            this.CB_Brand_name.Location = new System.Drawing.Point(85, 38);
            this.CB_Brand_name.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.CB_Brand_name.Name = "CB_Brand_name";
            this.CB_Brand_name.Size = new System.Drawing.Size(204, 34);
            this.CB_Brand_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brand :";
            // 
            // B_Brand_Delete
            // 
            this.B_Brand_Delete.Location = new System.Drawing.Point(108, 81);
            this.B_Brand_Delete.Name = "B_Brand_Delete";
            this.B_Brand_Delete.Size = new System.Drawing.Size(146, 63);
            this.B_Brand_Delete.TabIndex = 2;
            this.B_Brand_Delete.Text = "Delete Brand \r\n(Enter)";
            this.B_Brand_Delete.UseVisualStyleBackColor = true;
            this.B_Brand_Delete.Click += new System.EventHandler(this.B_Brand_Delete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B_Brand_Delete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CB_Brand_name);
            this.panel1.Location = new System.Drawing.Point(24, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 197);
            this.panel1.TabIndex = 3;
            // 
            // deleteBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 249);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("AngsanaUPC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "deleteBrand";
            this.Text = "deleteBrand";
            this.SizeChanged += new System.EventHandler(this.deleteBrand_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Brand_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Brand_Delete;
        private System.Windows.Forms.Panel panel1;
    }
}