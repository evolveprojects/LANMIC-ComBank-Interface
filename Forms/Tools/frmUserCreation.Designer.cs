namespace LANMIC_ComBank_Interface.Forms.Tools
{
    partial class frmUserCreation
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
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            btnNew = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            chkActive = new CheckBox();
            btnCancel = new Button();
            dgvUserDetails = new DataGridView();
            UserID = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewCheckBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            lblUserCreation = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)dgvUserDetails).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(74, 14);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Enabled = false;
            textBox1.Location = new Point(156, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(532, 21);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 71);
            label3.Name = "label3";
            label3.Size = new Size(72, 14);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(155, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 21);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(128, 14);
            label4.TabIndex = 6;
            label4.Text = "Confirm Password";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(155, 92);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 21);
            textBox3.TabIndex = 7;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNew.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(289, 410);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 8;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(370, 410);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(451, 410);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(532, 410);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Enabled = false;
            chkActive.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkActive.Location = new Point(411, 64);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(63, 18);
            chkActive.TabIndex = 12;
            chkActive.Text = "Active";
            chkActive.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(613, 410);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // dgvUserDetails
            // 
            dgvUserDetails.AllowUserToAddRows = false;
            dgvUserDetails.AllowUserToDeleteRows = false;
            dgvUserDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUserDetails.BackgroundColor = SystemColors.AppWorkspace;
            dgvUserDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserDetails.Columns.AddRange(new DataGridViewColumn[] { UserID, IsActive, Username, Status });
            dgvUserDetails.GridColor = SystemColors.ControlDark;
            dgvUserDetails.Location = new Point(12, 119);
            dgvUserDetails.Name = "dgvUserDetails";
            dgvUserDetails.ReadOnly = true;
            dgvUserDetails.Size = new Size(675, 285);
            dgvUserDetails.TabIndex = 15;
            // 
            // UserID
            // 
            UserID.HeaderText = "User ID";
            UserID.Name = "UserID";
            UserID.ReadOnly = true;
            UserID.Visible = false;
            // 
            // IsActive
            // 
            IsActive.HeaderText = "Is Active";
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            IsActive.Visible = false;
            // 
            // Username
            // 
            Username.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Username.HeaderText = "Username";
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // lblUserCreation
            // 
            lblUserCreation.AutoSize = true;
            lblUserCreation.Dock = DockStyle.Top;
            lblUserCreation.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserCreation.Location = new Point(0, 0);
            lblUserCreation.Name = "lblUserCreation";
            lblUserCreation.Size = new Size(175, 30);
            lblUserCreation.TabIndex = 16;
            lblUserCreation.Text = "USER CREATION";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // frmUserCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 445);
            Controls.Add(lblUserCreation);
            Controls.Add(dgvUserDetails);
            Controls.Add(btnCancel);
            Controls.Add(chkActive);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmUserCreation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUserCreation";
            Load += frmUserCreation_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUserDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Button btnNew;
        private Button btnEdit;
        private Button btnSave;
        private Button btnDelete;
        private CheckBox chkActive;
        private Button btnCancel;
        internal DataGridView dgvUserDetails;
        private Label lblUserCreation;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewCheckBoxColumn IsActive;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Status;
    }
}