namespace LANMIC_ComBank_Interface
{
    partial class SetupForm
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
            label1 = new Label();
            txtAppName = new TextBox();
            txtDatabase = new TextBox();
            txtServer = new TextBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            btnTest = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(162, 27);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 0;
            label1.Text = "Setup Application";
            // 
            // txtAppName
            // 
            txtAppName.Location = new Point(193, 93);
            txtAppName.Name = "txtAppName";
            txtAppName.Size = new Size(270, 23);
            txtAppName.TabIndex = 1;
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(193, 253);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(270, 23);
            txtDatabase.TabIndex = 1;
            // 
            // txtServer
            // 
            txtServer.Location = new Point(193, 133);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(270, 23);
            txtServer.TabIndex = 1;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(193, 173);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(270, 23);
            txtUser.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(193, 215);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(270, 23);
            txtPassword.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 94);
            label2.Name = "label2";
            label2.Size = new Size(149, 21);
            label2.TabIndex = 0;
            label2.Text = "Application Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 134);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 0;
            label3.Text = "SQL Server";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 254);
            label4.Name = "label4";
            label4.Size = new Size(131, 21);
            label4.TabIndex = 0;
            label4.Text = "Database Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 174);
            label5.Name = "label5";
            label5.Size = new Size(120, 21);
            label5.TabIndex = 0;
            label5.Text = "SQL Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 216);
            label6.Name = "label6";
            label6.Size = new Size(115, 21);
            label6.TabIndex = 0;
            label6.Text = "SQL Password";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(301, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 34);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(385, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(78, 34);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            btnTest.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTest.Location = new Point(385, 294);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(78, 34);
            btnTest.TabIndex = 4;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // SetupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(btnTest);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtServer);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(txtDatabase);
            Controls.Add(txtAppName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(500, 500);
            MinimumSize = new Size(500, 500);
            Name = "SetupForm";
            Text = "Setup Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAppName;
        private TextBox txtDatabase;
        private TextBox txtServer;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnSave;
        private Button btnCancel;
        private Button btnTest;
    }
}