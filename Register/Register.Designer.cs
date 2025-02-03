namespace Register
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
            Btn_Register = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            Password_TXT = new TextBox();
            Email_TXT = new TextBox();
            UP_Age = new NumericUpDown();
            CB_Role = new ComboBox();
            DGV_Registered = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)UP_Age).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Registered).BeginInit();
            SuspendLayout();
            // 
            // Btn_Register
            // 
            Btn_Register.Location = new Point(564, 390);
            Btn_Register.Name = "Btn_Register";
            Btn_Register.Size = new Size(112, 34);
            Btn_Register.TabIndex = 0;
            Btn_Register.Text = "Register";
            Btn_Register.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(439, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 1;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 88);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(439, 234);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(439, 311);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 4;
            label4.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(439, 165);
            label5.Name = "label5";
            label5.Size = new Size(44, 25);
            label5.TabIndex = 5;
            label5.Text = "Age";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(566, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 6;
            // 
            // Password_TXT
            // 
            Password_TXT.Location = new Point(566, 85);
            Password_TXT.Name = "Password_TXT";
            Password_TXT.Size = new Size(150, 31);
            Password_TXT.TabIndex = 7;
            Password_TXT.UseSystemPasswordChar = true;
            Password_TXT.TextChanged += textBox2_TextChanged;
            // 
            // Email_TXT
            // 
            Email_TXT.Location = new Point(566, 231);
            Email_TXT.Name = "Email_TXT";
            Email_TXT.Size = new Size(150, 31);
            Email_TXT.TabIndex = 8;
            // 
            // UP_Age
            // 
            UP_Age.Location = new Point(566, 165);
            UP_Age.Name = "UP_Age";
            UP_Age.Size = new Size(180, 31);
            UP_Age.TabIndex = 9;
            // 
            // CB_Role
            // 
            CB_Role.FormattingEnabled = true;
            CB_Role.Items.AddRange(new object[] { "Admin", "User" });
            CB_Role.Location = new Point(564, 311);
            CB_Role.Name = "CB_Role";
            CB_Role.Size = new Size(182, 33);
            CB_Role.TabIndex = 10;
            // 
            // DGV_Registered
            // 
            DGV_Registered.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Registered.Location = new Point(2, -1);
            DGV_Registered.Name = "DGV_Registered";
            DGV_Registered.RowHeadersWidth = 62;
            DGV_Registered.Size = new Size(431, 451);
            DGV_Registered.TabIndex = 11;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DGV_Registered);
            Controls.Add(CB_Role);
            Controls.Add(UP_Age);
            Controls.Add(Email_TXT);
            Controls.Add(Password_TXT);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btn_Register);
            Name = "Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)UP_Age).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Registered).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Register;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox Password_TXT;
        private TextBox Email_TXT;
        private NumericUpDown UP_Age;
        private ComboBox CB_Role;
        private DataGridView DGV_Registered;
    }
}
