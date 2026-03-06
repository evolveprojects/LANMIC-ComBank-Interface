namespace LANMIC_ComBank_Interface.Forms.Setting.Sage
{
    partial class frmSageApiCredentials
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
            label1 = new Label();
            txtDomain = new TextBox();
            txtApiVersion = new TextBox();
            label2 = new Label();
            txtTenant = new TextBox();
            label3 = new Label();
            txtCompany = new TextBox();
            label4 = new Label();
            txtUsername = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label6 = new Label();
            btnCancel = new Button();
            btnRefesh = new Button();
            btnSave = new Button();
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
            lblBanks.Size = new Size(238, 30);
            lblBanks.TabIndex = 10;
            lblBanks.Text = "Setup Sage Credentials";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 75);
            label1.Name = "label1";
            label1.Size = new Size(57, 14);
            label1.TabIndex = 77;
            label1.Text = "Domain";
            // 
            // txtDomain
            // 
            txtDomain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDomain.Enabled = false;
            txtDomain.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtDomain.Location = new Point(124, 71);
            txtDomain.Name = "txtDomain";
            txtDomain.Size = new Size(664, 23);
            txtDomain.TabIndex = 76;
            // 
            // txtApiVersion
            // 
            txtApiVersion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtApiVersion.Enabled = false;
            txtApiVersion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtApiVersion.Location = new Point(124, 121);
            txtApiVersion.Name = "txtApiVersion";
            txtApiVersion.Size = new Size(664, 23);
            txtApiVersion.TabIndex = 76;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 125);
            label2.Name = "label2";
            label2.Size = new Size(82, 14);
            label2.TabIndex = 77;
            label2.Text = "Api Version";
            // 
            // txtTenant
            // 
            txtTenant.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTenant.Enabled = false;
            txtTenant.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtTenant.Location = new Point(124, 171);
            txtTenant.Name = "txtTenant";
            txtTenant.Size = new Size(664, 23);
            txtTenant.TabIndex = 76;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 175);
            label3.Name = "label3";
            label3.Size = new Size(52, 14);
            label3.TabIndex = 77;
            label3.Text = "Tenant";
            // 
            // txtCompany
            // 
            txtCompany.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCompany.Enabled = false;
            txtCompany.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCompany.Location = new Point(124, 221);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(664, 23);
            txtCompany.TabIndex = 76;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 225);
            label4.Name = "label4";
            label4.Size = new Size(68, 14);
            label4.TabIndex = 77;
            label4.Text = "Company";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Enabled = false;
            txtUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtUsername.Location = new Point(124, 271);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(664, 23);
            txtUsername.TabIndex = 76;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 275);
            label5.Name = "label5";
            label5.Size = new Size(74, 14);
            label5.TabIndex = 77;
            label5.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Enabled = false;
            txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtPassword.Location = new Point(124, 321);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(664, 23);
            txtPassword.TabIndex = 76;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 325);
            label6.Name = "label6";
            label6.Size = new Size(72, 14);
            label6.TabIndex = 77;
            label6.Text = "Password";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(713, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 80;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRefesh
            // 
            btnRefesh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefesh.Cursor = Cursors.Hand;
            btnRefesh.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefesh.Location = new Point(632, 415);
            btnRefesh.Name = "btnRefesh";
            btnRefesh.Size = new Size(75, 23);
            btnRefesh.TabIndex = 79;
            btnRefesh.Text = "Refresh";
            btnRefesh.UseVisualStyleBackColor = true;
            btnRefesh.Click += btnRefesh_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(470, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 78;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(551, 415);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 81;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // frmSageApiCredentials
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(btnCancel);
            Controls.Add(btnRefesh);
            Controls.Add(btnSave);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtCompany);
            Controls.Add(txtTenant);
            Controls.Add(txtApiVersion);
            Controls.Add(txtDomain);
            Controls.Add(lblBanks);
            Name = "frmSageApiCredentials";
            Text = "frmSageApiCredentials";
            Load += frmSageApiCredentials_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBanks;
        private Label label1;
        private TextBox txtDomain;
        private TextBox txtApiVersion;
        private Label label2;
        private TextBox txtTenant;
        private Label label3;
        private TextBox txtCompany;
        private Label label4;
        private TextBox txtUsername;
        private Label label5;
        private TextBox txtPassword;
        private Label label6;
        private Button btnCancel;
        private Button btnRefesh;
        private Button btnSave;
        private Button btnEdit;
    }
}