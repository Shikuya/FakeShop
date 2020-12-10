namespace ShopApp.Shop.add
{
    partial class addCategorie
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
            this.B_categorie_add = new System.Windows.Forms.Button();
            this.TB_categorie_descliption = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_categorie_name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_categorie_add
            // 
            this.B_categorie_add.BackColor = System.Drawing.Color.Gainsboro;
            this.B_categorie_add.Location = new System.Drawing.Point(140, 232);
            this.B_categorie_add.Name = "B_categorie_add";
            this.B_categorie_add.Size = new System.Drawing.Size(206, 63);
            this.B_categorie_add.TabIndex = 11;
            this.B_categorie_add.Text = "Add Categorie";
            this.B_categorie_add.UseVisualStyleBackColor = false;
            this.B_categorie_add.Click += new System.EventHandler(this.B_categorie_add_Click);
            // 
            // TB_categorie_descliption
            // 
            this.TB_categorie_descliption.Location = new System.Drawing.Point(139, 90);
            this.TB_categorie_descliption.Multiline = true;
            this.TB_categorie_descliption.Name = "TB_categorie_descliption";
            this.TB_categorie_descliption.Size = new System.Drawing.Size(207, 124);
            this.TB_categorie_descliption.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "ShortDesciption :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "NameCategorie :";
            // 
            // TB_categorie_name
            // 
            this.TB_categorie_name.Location = new System.Drawing.Point(140, 37);
            this.TB_categorie_name.Name = "TB_categorie_name";
            this.TB_categorie_name.Size = new System.Drawing.Size(209, 34);
            this.TB_categorie_name.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B_categorie_add);
            this.panel1.Controls.Add(this.TB_categorie_descliption);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TB_categorie_name);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 316);
            this.panel1.TabIndex = 12;
            // 
            // addCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 341);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("AngsanaUPC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "addCategorie";
            this.Text = "addCategorie";
            this.Load += new System.EventHandler(this.addCategorie_Load);
            this.SizeChanged += new System.EventHandler(this.addCategorie_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_categorie_add;
        private System.Windows.Forms.TextBox TB_categorie_descliption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_categorie_name;
        private System.Windows.Forms.Panel panel1;
    }
}