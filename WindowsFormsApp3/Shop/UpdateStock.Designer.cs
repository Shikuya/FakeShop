
namespace ShopApp.Shop
{
    partial class updateStock
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
            this.CB_Categorie_list = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_update_Stock = new System.Windows.Forms.TextBox();
            this.CB_Brand_list = new System.Windows.Forms.ComboBox();
            this.CB_Product_list = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.B_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_Categorie_list
            // 
            this.CB_Categorie_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Categorie_list.FormattingEnabled = true;
            this.CB_Categorie_list.Location = new System.Drawing.Point(161, 39);
            this.CB_Categorie_list.Name = "CB_Categorie_list";
            this.CB_Categorie_list.Size = new System.Drawing.Size(164, 34);
            this.CB_Categorie_list.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categorie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Brand";
            // 
            // TB_update_Stock
            // 
            this.TB_update_Stock.Location = new System.Drawing.Point(161, 159);
            this.TB_update_Stock.Name = "TB_update_Stock";
            this.TB_update_Stock.Size = new System.Drawing.Size(164, 34);
            this.TB_update_Stock.TabIndex = 3;
            // 
            // CB_Brand_list
            // 
            this.CB_Brand_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Brand_list.FormattingEnabled = true;
            this.CB_Brand_list.Location = new System.Drawing.Point(161, 79);
            this.CB_Brand_list.Name = "CB_Brand_list";
            this.CB_Brand_list.Size = new System.Drawing.Size(164, 34);
            this.CB_Brand_list.TabIndex = 0;
            this.CB_Brand_list.SelectedIndexChanged += new System.EventHandler(this.CB_Brand_list_SelectedIndexChanged);
            // 
            // CB_Product_list
            // 
            this.CB_Product_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Product_list.FormattingEnabled = true;
            this.CB_Product_list.Location = new System.Drawing.Point(161, 119);
            this.CB_Product_list.Name = "CB_Product_list";
            this.CB_Product_list.Size = new System.Drawing.Size(164, 34);
            this.CB_Product_list.TabIndex = 0;
            this.CB_Product_list.SelectedIndexChanged += new System.EventHandler(this.CB_Product_list_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "จำนวนสต็อกที่ลงเพิ่ม";
            // 
            // B_save
            // 
            this.B_save.Location = new System.Drawing.Point(190, 199);
            this.B_save.Name = "B_save";
            this.B_save.Size = new System.Drawing.Size(97, 35);
            this.B_save.TabIndex = 4;
            this.B_save.Text = "save";
            this.B_save.UseVisualStyleBackColor = true;
            this.B_save.Click += new System.EventHandler(this.B_save_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B_save);
            this.panel1.Controls.Add(this.TB_update_Stock);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CB_Product_list);
            this.panel1.Controls.Add(this.CB_Brand_list);
            this.panel1.Controls.Add(this.CB_Categorie_list);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 280);
            this.panel1.TabIndex = 5;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            // 
            // updateStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 303);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("AngsanaUPC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "updateStock";
            this.Text = "updateStock";
            this.Load += new System.EventHandler(this.updateStock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Categorie_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_update_Stock;
        private System.Windows.Forms.ComboBox CB_Brand_list;
        private System.Windows.Forms.ComboBox CB_Product_list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button B_save;
        private System.Windows.Forms.Panel panel1;
    }
}