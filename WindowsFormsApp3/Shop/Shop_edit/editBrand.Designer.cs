
namespace ShopApp.Shop.Shop_edit
{
    partial class editBrand
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
            this.CB_Brand_Show_list = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Brand_Change_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.B_Brand_Save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_Brand_Show_list
            // 
            this.CB_Brand_Show_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Brand_Show_list.FormattingEnabled = true;
            this.CB_Brand_Show_list.Location = new System.Drawing.Point(95, 20);
            this.CB_Brand_Show_list.Name = "CB_Brand_Show_list";
            this.CB_Brand_Show_list.Size = new System.Drawing.Size(168, 34);
            this.CB_Brand_Show_list.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brand :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TB_Brand_Change_name
            // 
            this.TB_Brand_Change_name.Location = new System.Drawing.Point(96, 60);
            this.TB_Brand_Change_name.Name = "TB_Brand_Change_name";
            this.TB_Brand_Change_name.Size = new System.Drawing.Size(167, 34);
            this.TB_Brand_Change_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Change :";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // B_Brand_Save
            // 
            this.B_Brand_Save.Location = new System.Drawing.Point(110, 111);
            this.B_Brand_Save.Name = "B_Brand_Save";
            this.B_Brand_Save.Size = new System.Drawing.Size(136, 38);
            this.B_Brand_Save.TabIndex = 3;
            this.B_Brand_Save.Text = "Save";
            this.B_Brand_Save.UseVisualStyleBackColor = true;
            this.B_Brand_Save.Click += new System.EventHandler(this.B_Brand_Save_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B_Brand_Save);
            this.panel1.Controls.Add(this.TB_Brand_Change_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CB_Brand_Show_list);
            this.panel1.Location = new System.Drawing.Point(10, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 198);
            this.panel1.TabIndex = 4;
            // 
            // editBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 216);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("AngsanaUPC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "editBrand";
            this.Text = "editBrand";
            this.Load += new System.EventHandler(this.editBrand_Load);
            this.SizeChanged += new System.EventHandler(this.editBrand_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Brand_Show_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Brand_Change_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_Brand_Save;
        private System.Windows.Forms.Panel panel1;
    }
}