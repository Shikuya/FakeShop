
namespace ShopApp.Shop.Shop_delete
{
    partial class deleteTransport
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
            this.CB_Transport_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Transport_Delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_Transport_name
            // 
            this.CB_Transport_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Transport_name.FormattingEnabled = true;
            this.CB_Transport_name.Location = new System.Drawing.Point(84, 24);
            this.CB_Transport_name.Name = "CB_Transport_name";
            this.CB_Transport_name.Size = new System.Drawing.Size(183, 34);
            this.CB_Transport_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transport :";
            // 
            // B_Transport_Delete
            // 
            this.B_Transport_Delete.Location = new System.Drawing.Point(65, 84);
            this.B_Transport_Delete.Name = "B_Transport_Delete";
            this.B_Transport_Delete.Size = new System.Drawing.Size(147, 62);
            this.B_Transport_Delete.TabIndex = 2;
            this.B_Transport_Delete.Text = "Delete Transport\r\n(Enter)";
            this.B_Transport_Delete.UseVisualStyleBackColor = true;
            this.B_Transport_Delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B_Transport_Delete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CB_Transport_name);
            this.panel1.Location = new System.Drawing.Point(8, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 183);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // deleteTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 197);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("AngsanaUPC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "deleteTransport";
            this.Text = "deleteTransport";
            this.SizeChanged += new System.EventHandler(this.deleteTransport_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Transport_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Transport_Delete;
        private System.Windows.Forms.Panel panel1;
    }
}