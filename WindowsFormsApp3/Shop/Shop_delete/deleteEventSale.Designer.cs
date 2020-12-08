
namespace ShopApp.Shop.Shop_delete
{
    partial class deleteEventSale
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
            this.CB_Event_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Customer_Delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_Event_name
            // 
            this.CB_Event_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Event_name.FormattingEnabled = true;
            this.CB_Event_name.Location = new System.Drawing.Point(69, 24);
            this.CB_Event_name.Name = "CB_Event_name";
            this.CB_Event_name.Size = new System.Drawing.Size(187, 34);
            this.CB_Event_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event :";
            // 
            // B_Customer_Delete
            // 
            this.B_Customer_Delete.Location = new System.Drawing.Point(69, 74);
            this.B_Customer_Delete.Name = "B_Customer_Delete";
            this.B_Customer_Delete.Size = new System.Drawing.Size(172, 60);
            this.B_Customer_Delete.TabIndex = 2;
            this.B_Customer_Delete.Text = "Delete Event\r\n(Enter)";
            this.B_Customer_Delete.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B_Customer_Delete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CB_Event_name);
            this.panel1.Location = new System.Drawing.Point(8, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 181);
            this.panel1.TabIndex = 3;
            // 
            // deleteEventSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 205);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("AngsanaUPC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "deleteEventSale";
            this.Text = "DeleteEventSale";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Event_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Customer_Delete;
        private System.Windows.Forms.Panel panel1;
    }
}