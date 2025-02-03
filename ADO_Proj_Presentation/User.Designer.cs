namespace ADO_Proj_Presentation
{
    partial class User
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
            DGV_User = new DataGridView();
            DGV_Products = new DataGridView();
            Logout_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGV_User).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Products).BeginInit();
            SuspendLayout();
            // 
            // DGV_User
            // 
            DGV_User.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_User.Location = new Point(12, 74);
            DGV_User.Name = "DGV_User";
            DGV_User.RowHeadersWidth = 62;
            DGV_User.Size = new Size(544, 225);
            DGV_User.TabIndex = 4;
            DGV_User.RowHeaderMouseDoubleClick += DGV_User_RowHeaderMouseDoubleClick;
            // 
            // DGV_Products
            // 
            DGV_Products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Products.Location = new Point(754, 74);
            DGV_Products.Name = "DGV_Products";
            DGV_Products.RowHeadersWidth = 62;
            DGV_Products.Size = new Size(510, 225);
            DGV_Products.TabIndex = 5;
            DGV_Products.RowHeaderMouseClick += DGV_Products_RowHeaderMouseClick;
            // 
            // Logout_btn
            // 
            Logout_btn.Location = new Point(59, 394);
            Logout_btn.Name = "Logout_btn";
            Logout_btn.Size = new Size(199, 34);
            Logout_btn.TabIndex = 6;
            Logout_btn.Text = "log out";
            Logout_btn.UseVisualStyleBackColor = true;
            Logout_btn.Click += Logout_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 17);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 7;
            label1.Text = "your favorites";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(922, 17);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 8;
            label2.Text = "Products available";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(838, 320);
            label3.Name = "label3";
            label3.Size = new Size(447, 25);
            label3.TabIndex = 9;
            label3.Text = "double click on what you want to add to your favorites";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 320);
            label4.Name = "label4";
            label4.Size = new Size(401, 25);
            label4.TabIndex = 10;
            label4.Text = " click on what you want to remove from favorites";
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Logout_btn);
            Controls.Add(DGV_Products);
            Controls.Add(DGV_User);
            Name = "User";
            Text = "User";
            Load += User_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_User).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Products).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView DGV_User;
        private DataGridView DGV_Products;
        private Button Logout_btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}