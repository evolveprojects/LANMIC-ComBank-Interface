namespace LANMIC_ComBank_Interface
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSignIn = new Button();
            btnClose = new Button();
            printDialog1 = new PrintDialog();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(12, 234);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(303, 29);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(12, 290);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(303, 29);
            txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F);
            label1.Location = new Point(10, 210);
            label1.Name = "label1";
            label1.Size = new Size(97, 18);
            label1.TabIndex = 3;
            label1.Text = "USERNAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.Location = new Point(10, 266);
            label2.Name = "label2";
            label2.Size = new Size(102, 18);
            label2.TabIndex = 4;
            label2.Text = "PASSWORD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label3.Location = new Point(41, 9);
            label3.Name = "label3";
            label3.Size = new Size(261, 25);
            label3.TabIndex = 5;
            label3.Text = "LANMIC ComBank Interface";
            // 
            // btnSignIn
            // 
            btnSignIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSignIn.Location = new Point(227, 325);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(88, 30);
            btnSignIn.TabIndex = 6;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.Location = new Point(133, 325);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(88, 31);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(97, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(327, 367);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btnClose);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(btnSignIn);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSignIn;
        private Button btnClose;
        private PrintDialog printDialog1;
        private PictureBox pictureBox1;
    }
}