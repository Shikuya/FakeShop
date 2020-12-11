
namespace ShopApp.Shop.Shop_edit
{
    partial class editCategorie
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_Categorie_Save = new System.Windows.Forms.Button();
            this.TB_Categorie_Chage_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Categorie_Show_list = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B_Categorie_Save);
            this.panel1.Controls.Add(this.TB_Categorie_Chage_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CB_Categorie_Show_list);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 205);
            this.panel1.TabIndex = 5;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // B_Categorie_Save
            // 
            this.B_Categorie_Save.Location = new System.Drawing.Point(125, 107);
            this.B_Categorie_Save.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.B_Categorie_Save.Name = "B_Categorie_Save";
            this.B_Categorie_Save.Size = new System.Drawing.Size(146, 54);
            this.B_Categorie_Save.TabIndex = 3;
            this.B_Categorie_Save.Text = "Save";
            this.B_Categorie_Save.UseVisualStyleBackColor = true;
            this.B_Categorie_Save.Click += new System.EventHandler(this.B_Categorie_Save_Click);
            // 
            // TB_Categorie_Chage_name
            // 
            this.TB_Categorie_Chage_name.Location = new System.Drawing.Point(103, 61);
            this.TB_Categorie_Chage_name.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TB_Categorie_Chage_name.Name = "TB_Categorie_Chage_name";
            this.TB_Categorie_Chage_name.Size = new System.Drawing.Size(194, 34);
            this.TB_Categorie_Chage_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Change :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categorie :";
            // 
            // CB_Categorie_Show_list
            // 
            this.CB_Categorie_Show_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Categorie_Show_list.FormattingEnabled = true;
            this.CB_Categorie_Show_list.Location = new System.Drawing.Point(102, 18);
            this.CB_Categorie_Show_list.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.CB_Categorie_Show_list.Name = "CB_Categorie_Show_list";
            this.CB_Categorie_Show_list.Size = new System.Drawing.Size(195, 34);
            this.CB_Categorie_Show_list.TabIndex = 0;
            // 
            // editCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 242);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("AngsanaUPC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "editCategorie";
            this.Text = "editCategorie";
            this.Load += new System.EventHandler(this.editCategorie_Load);
            this.SizeChanged += new System.EventHandler(this.editCategorie_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button B_Categorie_Save;
        private System.Windows.Forms.TextBox TB_Categorie_Chage_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Categorie_Show_list;
    }
}