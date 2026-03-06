namespace LANMIC_ComBank_Interface.Forms.Setting.CommercialBank
{
    partial class frmComBankAPICredentials
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
            lblBanks = new Label();
            btnCancel = new Button();
            btnRefesh = new Button();
            btnSave = new Button();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtOrgAccount = new TextBox();
            txtInputUser = new TextBox();
            txtInputChanel = new TextBox();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // lblBanks
            // 
            lblBanks.AutoSize = true;
            lblBanks.Dock = DockStyle.Top;
            lblBanks.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBanks.Location = new Point(0, 0);
            lblBanks.Name = "lblBanks";
            lblBanks.Size = new Size(326, 30);
            lblBanks.TabIndex = 9;
            lblBanks.Text = "Setup ComBank API Credentials";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(755, 492);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 79;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRefesh
            // 
            btnRefesh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefesh.Cursor = Cursors.Hand;
            btnRefesh.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefesh.Location = new Point(674, 492);
            btnRefesh.Name = "btnRefesh";
            btnRefesh.Size = new Size(75, 23);
            btnRefesh.TabIndex = 78;
            btnRefesh.Text = "Refresh";
            btnRefesh.UseVisualStyleBackColor = true;
            btnRefesh.Click += btnRefesh_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(512, 492);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 77;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 252);
            label6.Name = "label6";
            label6.Size = new Size(72, 14);
            label6.TabIndex = 86;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 202);
            label5.Name = "label5";
            label5.Size = new Size(74, 14);
            label5.TabIndex = 87;
            label5.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 152);
            label3.Name = "label3";
            label3.Size = new Size(96, 14);
            label3.TabIndex = 89;
            label3.Text = "Bank Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 102);
            label2.Name = "label2";
            label2.Size = new Size(77, 14);
            label2.TabIndex = 90;
            label2.Text = "Input User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 52);
            label1.Name = "label1";
            label1.Size = new Size(91, 14);
            label1.TabIndex = 91;
            label1.Text = "Input Chanel";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Enabled = false;
            txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtPassword.Location = new Point(129, 248);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(701, 23);
            txtPassword.TabIndex = 80;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Enabled = false;
            txtUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtUsername.Location = new Point(129, 198);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(701, 23);
            txtUsername.TabIndex = 81;
            // 
            // txtOrgAccount
            // 
            txtOrgAccount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOrgAccount.Enabled = false;
            txtOrgAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtOrgAccount.Location = new Point(129, 148);
            txtOrgAccount.Name = "txtOrgAccount";
            txtOrgAccount.Size = new Size(701, 23);
            txtOrgAccount.TabIndex = 83;
            // 
            // txtInputUser
            // 
            txtInputUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtInputUser.Enabled = false;
            txtInputUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtInputUser.Location = new Point(129, 98);
            txtInputUser.Name = "txtInputUser";
            txtInputUser.Size = new Size(701, 23);
            txtInputUser.TabIndex = 84;
            // 
            // txtInputChanel
            // 
            txtInputChanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtInputChanel.Enabled = false;
            txtInputChanel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtInputChanel.Location = new Point(129, 48);
            txtInputChanel.Name = "txtInputChanel";
            txtInputChanel.Size = new Size(701, 23);
            txtInputChanel.TabIndex = 85;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(593, 492);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 92;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // frmComBankAPICredentials
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 523);
            Controls.Add(btnEdit);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtOrgAccount);
            Controls.Add(txtInputUser);
            Controls.Add(txtInputChanel);
            Controls.Add(btnCancel);
            Controls.Add(btnRefesh);
            Controls.Add(btnSave);
            Controls.Add(lblBanks);
            Name = "frmComBankAPICredentials";
            Text = "frmComBankAPICredentials";
            Load += frmComBankAPICredentials_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBanks;
        private Button btnCancel;
        private Button btnRefesh;
        private Button btnSave;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtOrgAccount;
        private TextBox txtInputUser;
        private TextBox txtInputChanel;
        private Button btnEdit;
    }
}