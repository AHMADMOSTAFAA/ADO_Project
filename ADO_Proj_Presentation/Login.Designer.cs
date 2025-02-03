namespace ADO_Proj_Presentation
{
    partial class Login
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
            Login_Btn = new Button();
            Label_1 = new Label();
            label2 = new Label();
            UserName_TXT = new TextBox();
            Password_TXT = new TextBox();
            SuspendLayout();
            // 
            // Login_Btn
            // 
            Login_Btn.Location = new Point(325, 315);
            Login_Btn.Name = "Login_Btn";
            Login_Btn.Size = new Size(112, 34);
            Login_Btn.TabIndex = 0;
            Login_Btn.Text = "Login";
            Login_Btn.UseVisualStyleBackColor = true;
            Login_Btn.Click += Login_Btn_Click;
            // 
            // Label_1
            // 
            Label_1.AutoSize = true;
            Label_1.Location = new Point(230, 74);
            Label_1.Name = "Label_1";
            Label_1.Size = new Size(94, 25);
            Label_1.TabIndex = 1;
            Label_1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 205);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // UserName_TXT
            // 
            UserName_TXT.Location = new Point(417, 74);
            UserName_TXT.Name = "UserName_TXT";
            UserName_TXT.Size = new Size(150, 31);
            UserName_TXT.TabIndex = 3;
            // 
            // Password_TXT
            // 
            Password_TXT.Location = new Point(417, 220);
            Password_TXT.Name = "Password_TXT";
            Password_TXT.Size = new Size(150, 31);
            Password_TXT.TabIndex = 4;
            Password_TXT.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Password_TXT);
            Controls.Add(UserName_TXT);
            Controls.Add(label2);
            Controls.Add(Label_1);
            Controls.Add(Login_Btn);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login_Btn;
        private Label Label_1;
        private Label label2;
        private TextBox UserName_TXT;
        private TextBox Password_TXT;
    }
}