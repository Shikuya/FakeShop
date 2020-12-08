
namespace ShopApp.Shop.Shop_delete
{
    partial class SelectCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TB_Select = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phonenum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVInformation = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInformation)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Select
            // 
            this.TB_Select.Location = new System.Drawing.Point(124, 15);
            this.TB_Select.Name = "TB_Select";
            this.TB_Select.Size = new System.Drawing.Size(510, 34);
            this.TB_Select.TabIndex = 1;
            this.TB_Select.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select :";
            // 
            // address
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.address.DefaultCellStyle = dataGridViewCellStyle13;
            this.address.HeaderText = "ที่อยู่";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 230;
            // 
            // Phonenum
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.Phonenum.DefaultCellStyle = dataGridViewCellStyle14;
            this.Phonenum.HeaderText = "เบอร์โทรศัพท์";
            this.Phonenum.Name = "Phonenum";
            this.Phonenum.ReadOnly = true;
            this.Phonenum.Width = 140;
            // 
            // idcard
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.idcard.DefaultCellStyle = dataGridViewCellStyle15;
            this.idcard.HeaderText = "เลขบัตรประชาชน";
            this.idcard.Name = "idcard";
            this.idcard.ReadOnly = true;
            this.idcard.Width = 160;
            // 
            // name
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.name.DefaultCellStyle = dataGridViewCellStyle16;
            this.name.HeaderText = "ชื่อ - นามสกุล";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // DGVInformation
            // 
            this.DGVInformation.AllowUserToAddRows = false;
            this.DGVInformation.AllowUserToDeleteRows = false;
            this.DGVInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.idcard,
            this.Phonenum,
            this.address});
            this.DGVInformation.Location = new System.Drawing.Point(15, 74);
            this.DGVInformation.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.DGVInformation.Name = "DGVInformation";
            this.DGVInformation.ReadOnly = true;
            this.DGVInformation.Size = new System.Drawing.Size(775, 329);
            this.DGVInformation.TabIndex = 0;
            this.DGVInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TB_Select);
            this.panel1.Controls.Add(this.DGVInformation);
            this.panel1.Location = new System.Drawing.Point(8, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 416);
            this.panel1.TabIndex = 3;
            // 
            // SelectCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 449);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("AngsanaUPC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "SelectCustomer";
            this.Text = "deleteCustomer_2";
            this.TextChanged += new System.EventHandler(this.a);
            ((System.ComponentModel.ISupportInitialize)(this.DGVInformation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TB_Select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phonenum;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcard;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridView DGVInformation;
        private System.Windows.Forms.Panel panel1;
    }
}