namespace ADO_Project
{
    partial class Welcome
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
            textBox1 = new TextBox();
            Login_Btn = new Button();
            GoTo_Register = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(301, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            textBox1.Text = "Welcome!";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Login_Btn
            // 
            Login_Btn.Location = new Point(326, 122);
            Login_Btn.Name = "Login_Btn";
            Login_Btn.Size = new Size(112, 34);
            Login_Btn.TabIndex = 1;
            Login_Btn.Text = "Login";
            Login_Btn.UseVisualStyleBackColor = true;
            Login_Btn.Click += Login_Btn_Click;
            // 
            // GoTo_Register
            // 
            GoTo_Register.Location = new Point(326, 214);
            GoTo_Register.Name = "GoTo_Register";
            GoTo_Register.Size = new Size(112, 34);
            GoTo_Register.TabIndex = 2;
            GoTo_Register.Text = "Register";
            GoTo_Register.UseVisualStyleBackColor = true;
            GoTo_Register.Click += GoTo_Register_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GoTo_Register);
            Controls.Add(Login_Btn);
            Controls.Add(textBox1);
            Name = "Welcome";
            Text = "Welcome";
            Load += Welcome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button Login_Btn;
        private Button GoTo_Register;
    }
}
