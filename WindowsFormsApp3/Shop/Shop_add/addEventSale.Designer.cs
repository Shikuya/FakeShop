namespace ShopApp.Shop.add
{
    partial class addEventSale
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CB_event_list = new System.Windows.Forms.ComboBox();
            this.TB_event_console_list = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.B_event_add = new System.Windows.Forms.Button();
            this.TB_event_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_event_persent = new System.Windows.Forms.TextBox();
            this.TB_event_descliption = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.CB_event_list);
            this.groupBox3.Controls.Add(this.TB_event_console_list);
            this.groupBox3.Location = new System.Drawing.Point(326, 21);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox3.Size = new System.Drawing.Size(269, 359);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List Event";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "NameEvent :";
            // 
            // CB_event_list
            // 
            this.CB_event_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_event_list.FormattingEnabled = true;
            this.CB_event_list.Location = new System.Drawing.Point(101, 54);
            this.CB_event_list.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.CB_event_list.Name = "CB_event_list";
            this.CB_event_list.Size = new System.Drawing.Size(140, 34);
            this.CB_event_list.TabIndex = 4;
            this.CB_event_list.SelectedIndexChanged += new System.EventHandler(this.CB_event_list_SelectedIndexChanged);
            // 
            // TB_event_console_list
            // 
            this.TB_event_console_list.BackColor = System.Drawing.SystemColors.MenuText;
            this.TB_event_console_list.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TB_event_console_list.Location = new System.Drawing.Point(10, 100);
            this.TB_event_console_list.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TB_event_console_list.Multiline = true;
            this.TB_event_console_list.Name = "TB_event_console_list";
            this.TB_event_console_list.ReadOnly = true;
            this.TB_event_console_list.Size = new System.Drawing.Size(248, 250);
            this.TB_event_console_list.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.B_event_add);
            this.groupBox2.Controls.Add(this.TB_event_name);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TB_event_persent);
            this.groupBox2.Controls.Add(this.TB_event_descliption);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox2.Size = new System.Drawing.Size(293, 325);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Event";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "NameEvent :";
            // 
            // B_event_add
            // 
            this.B_event_add.Location = new System.Drawing.Point(117, 254);
            this.B_event_add.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.B_event_add.Name = "B_event_add";
            this.B_event_add.Size = new System.Drawing.Size(166, 52);
            this.B_event_add.TabIndex = 3;
            this.B_event_add.Text = "Add Event";
            this.B_event_add.UseVisualStyleBackColor = true;
            this.B_event_add.Click += new System.EventHandler(this.B_event_add_Click);
            // 
            // TB_event_name
            // 
            this.TB_event_name.Location = new System.Drawing.Point(117, 27);
            this.TB_event_name.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TB_event_name.Name = "TB_event_name";
            this.TB_event_name.Size = new System.Drawing.Size(166, 34);
            this.TB_event_name.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Descliption :";
            // 
            // TB_event_persent
            // 
            this.TB_event_persent.Location = new System.Drawing.Point(117, 73);
            this.TB_event_persent.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TB_event_persent.Name = "TB_event_persent";
            this.TB_event_persent.Size = new System.Drawing.Size(166, 34);
            this.TB_event_persent.TabIndex = 1;
            // 
            // TB_event_descliption
            // 
            this.TB_event_descliption.Location = new System.Drawing.Point(117, 119);
            this.TB_event_descliption.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TB_event_descliption.Multiline = true;
            this.TB_event_descliption.Name = "TB_event_descliption";
            this.TB_event_descliption.Size = new System.Drawing.Size(166, 112);
            this.TB_event_descliption.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Sale % :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 392);
            this.panel1.TabIndex = 10;
            // 
            // addEventSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 397);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("AngsanaUPC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "addEventSale";
            this.Text = "addEventSale";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CB_event_list;
        private System.Windows.Forms.TextBox TB_event_console_list;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button B_event_add;
        private System.Windows.Forms.TextBox TB_event_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_event_persent;
        private System.Windows.Forms.TextBox TB_event_descliption;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
    }
}