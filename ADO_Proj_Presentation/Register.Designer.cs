namespace ADO_Proj_Presentation
{
    partial class Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Register_Btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            DGV_Registred = new DataGridView();
            UserName_TXT = new TextBox();
            Password_TXT = new TextBox();
            Email_TXT = new TextBox();
            Up_Age = new NumericUpDown();
            CB_Role = new ComboBox();
            label6 = new Label();
            Address_TXT = new TextBox();
            Back_Btn = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_Registred).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Up_Age).BeginInit();
            SuspendLayout();
            // 
            // Register_Btn
            // 
            Register_Btn.Location = new Point(1209, 410);
            Register_Btn.Name = "Register_Btn";
            Register_Btn.Size = new Size(112, 34);
            Register_Btn.TabIndex = 0;
            Register_Btn.Text = "Register";
            Register_Btn.UseVisualStyleBackColor = true;
            Register_Btn.Click += Register_Btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(974, 38);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 1;
            label1.Text = "User Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(986, 194);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(974, 117);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(986, 262);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 4;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(984, 361);
            label5.Name = "label5";
            label5.Size = new Size(46, 25);
            label5.TabIndex = 5;
            label5.Text = "Role";
            // 
            // DGV_Registred
            // 
            DGV_Registred.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Registred.Location = new Point(-1, 0);
            DGV_Registred.Name = "DGV_Registred";
            DGV_Registred.RowHeadersWidth = 62;
            DGV_Registred.Size = new Size(969, 448);
            DGV_Registred.TabIndex = 6;
            // 
            // UserName_TXT
            // 
            UserName_TXT.Location = new Point(1079, 38);
            UserName_TXT.Name = "UserName_TXT";
            UserName_TXT.Size = new Size(182, 31);
            UserName_TXT.TabIndex = 7;
            // 
            // Password_TXT
            // 
            Password_TXT.Location = new Point(1078, 117);
            Password_TXT.Name = "Password_TXT";
            Password_TXT.Size = new Size(182, 31);
            Password_TXT.TabIndex = 9;
            Password_TXT.UseSystemPasswordChar = true;
            // 
            // Email_TXT
            // 
            Email_TXT.Location = new Point(1078, 194);
            Email_TXT.Name = "Email_TXT";
            Email_TXT.Size = new Size(182, 31);
            Email_TXT.TabIndex = 10;
            // 
            // Up_Age
            // 
            Up_Age.Location = new Point(1078, 262);
            Up_Age.Minimum = new decimal(new int[] { 12, 0, 0, 0 });
            Up_Age.Name = "Up_Age";
            Up_Age.Size = new Size(182, 31);
            Up_Age.TabIndex = 11;
            Up_Age.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // CB_Role
            // 
            CB_Role.FormattingEnabled = true;
            CB_Role.Items.AddRange(new object[] { "Admin", "User" });
            CB_Role.Location = new Point(1078, 361);
            CB_Role.Name = "CB_Role";
            CB_Role.Size = new Size(182, 33);
            CB_Role.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(984, 320);
            label6.Name = "label6";
            label6.Size = new Size(77, 25);
            label6.TabIndex = 13;
            label6.Text = "Address";
            label6.Click += label6_Click;
            // 
            // Address_TXT
            // 
            Address_TXT.Location = new Point(1078, 317);
            Address_TXT.Name = "Address_TXT";
            Address_TXT.Size = new Size(182, 31);
            Address_TXT.TabIndex = 14;
            // 
            // Back_Btn
            // 
            Back_Btn.Location = new Point(984, 410);
            Back_Btn.Name = "Back_Btn";
            Back_Btn.Size = new Size(112, 34);
            Back_Btn.TabIndex = 15;
            Back_Btn.Text = "Back";
            Back_Btn.UseVisualStyleBackColor = true;
            Back_Btn.Click += Back_Btn_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 450);
            Controls.Add(Back_Btn);
            Controls.Add(Address_TXT);
            Controls.Add(label6);
            Controls.Add(CB_Role);
            Controls.Add(Up_Age);
            Controls.Add(Email_TXT);
            Controls.Add(Password_TXT);
            Controls.Add(UserName_TXT);
            Controls.Add(DGV_Registred);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Register_Btn);
            Name = "Register";
            Text = "Register";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Registred).EndInit();
            ((System.ComponentModel.ISupportInitialize)Up_Age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Register_Btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView DGV_Registred;
        private TextBox UserName_TXT;
        private TextBox Password_TXT;
        private TextBox Email_TXT;
        private NumericUpDown Up_Age;
        private ComboBox CB_Role;
        private Label label6;
        private TextBox Address_TXT;
        private Button Back_Btn;
    }
}
