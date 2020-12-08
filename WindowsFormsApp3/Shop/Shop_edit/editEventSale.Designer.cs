
namespace ShopApp.Shop.Shop_edit
{
    partial class editEventSale
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
            this.CB_Event_Select_Name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Event_Change_name = new System.Windows.Forms.TextBox();
            this.TB_Event_Change_Discount = new System.Windows.Forms.TextBox();
            this.TB_Event_Change_Descliption = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.B_Event_Save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_Event_Select_Name
            // 
            this.CB_Event_Select_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Event_Select_Name.FormattingEnabled = true;
            this.CB_Event_Select_Name.Location = new System.Drawing.Point(127, 12);
            this.CB_Event_Select_Name.Name = "CB_Event_Select_Name";
            this.CB_Event_Select_Name.Size = new System.Drawing.Size(225, 34);
            this.CB_Event_Select_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event name";
            // 
            // TB_Event_Change_name
            // 
            this.TB_Event_Change_name.Location = new System.Drawing.Point(129, 52);
            this.TB_Event_Change_name.Name = "TB_Event_Change_name";
            this.TB_Event_Change_name.Size = new System.Drawing.Size(139, 34);
            this.TB_Event_Change_name.TabIndex = 2;
            // 
            // TB_Event_Change_Discount
            // 
            this.TB_Event_Change_Discount.Location = new System.Drawing.Point(127, 92);
            this.TB_Event_Change_Discount.Name = "TB_Event_Change_Discount";
            this.TB_Event_Change_Discount.Size = new System.Drawing.Size(139, 34);
            this.TB_Event_Change_Discount.TabIndex = 3;
            // 
            // TB_Event_Change_Descliption
            // 
            this.TB_Event_Change_Descliption.Location = new System.Drawing.Point(127, 132);
            this.TB_Event_Change_Descliption.Multiline = true;
            this.TB_Event_Change_Descliption.Name = "TB_Event_Change_Descliption";
            this.TB_Event_Change_Descliption.Size = new System.Drawing.Size(225, 152);
            this.TB_Event_Change_Descliption.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name Event";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Discount Persect";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Descliption";
            // 
            // B_Event_Save
            // 
            this.B_Event_Save.Location = new System.Drawing.Point(277, 290);
            this.B_Event_Save.Name = "B_Event_Save";
            this.B_Event_Save.Size = new System.Drawing.Size(75, 33);
            this.B_Event_Save.TabIndex = 5;
            this.B_Event_Save.Text = "Save";
            this.B_Event_Save.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B_Event_Save);
            this.panel1.Controls.Add(this.TB_Event_Change_Descliption);
            this.panel1.Controls.Add(this.TB_Event_Change_Discount);
            this.panel1.Controls.Add(this.TB_Event_Change_name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CB_Event_Select_Name);
            this.panel1.Location = new System.Drawing.Point(11, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 339);
            this.panel1.TabIndex = 6;
            // 
            // editEventSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 342);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("AngsanaUPC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "editEventSale";
            this.Text = "editEventSale";
            this.Load += new System.EventHandler(this.editEventSale_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Event_Select_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Event_Change_name;
        private System.Windows.Forms.TextBox TB_Event_Change_Discount;
        private System.Windows.Forms.TextBox TB_Event_Change_Descliption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button B_Event_Save;
        private System.Windows.Forms.Panel panel1;
    }
}