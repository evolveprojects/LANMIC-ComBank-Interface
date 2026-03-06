namespace LANMIC_ComBank_Interface.Forms.Tools.Sage
{
    partial class frmVendors
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblVendors = new Label();
            label2 = new Label();
            txtVendorNumber = new TextBox();
            txtVendorName = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtBankName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dataGridView = new DataGridView();
            VendorNumber = new DataGridViewTextBoxColumn();
            VendorName = new DataGridViewTextBoxColumn();
            BankName = new DataGridViewTextBoxColumn();
            BankAccountNo = new DataGridViewTextBoxColumn();
            SWIFTCode = new DataGridViewTextBoxColumn();
            CurrencyCode = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            AddressLine1 = new DataGridViewTextBoxColumn();
            AddressLine2 = new DataGridViewTextBoxColumn();
            AddressLine3 = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            btnCancel = new Button();
            btnSave = new Button();
            btnSageVendors = new Button();
            txtBankAccountNo = new TextBox();
            label6 = new Label();
            btnRefesh = new Button();
            progressBar = new ProgressBar();
            btnAdd = new Button();
            chkIsActive = new CheckBox();
            txtSWIFTCode = new TextBox();
            label7 = new Label();
            cmbCurrencyCode = new ComboBox();
            btnNew = new Button();
            txtAddressLine1 = new TextBox();
            label8 = new Label();
            txtAddressLine2 = new TextBox();
            label9 = new Label();
            txtAddressLine3 = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // lblVendors
            // 
            lblVendors.AutoSize = true;
            lblVendors.Dock = DockStyle.Top;
            lblVendors.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVendors.Location = new Point(0, 0);
            lblVendors.Name = "lblVendors";
            lblVendors.Size = new Size(112, 30);
            lblVendors.TabIndex = 8;
            lblVendors.Text = "VENDORS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 50);
            label2.Name = "label2";
            label2.Size = new Size(59, 14);
            label2.TabIndex = 9;
            label2.Text = "Number";
            // 
            // txtVendorNumber
            // 
            txtVendorNumber.Location = new Point(139, 46);
            txtVendorNumber.Name = "txtVendorNumber";
            txtVendorNumber.ReadOnly = true;
            txtVendorNumber.Size = new Size(530, 23);
            txtVendorNumber.TabIndex = 10;
            // 
            // txtVendorName
            // 
            txtVendorName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtVendorName.Location = new Point(139, 73);
            txtVendorName.Name = "txtVendorName";
            txtVendorName.ReadOnly = true;
            txtVendorName.Size = new Size(652, 23);
            txtVendorName.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 77);
            label1.Name = "label1";
            label1.Size = new Size(45, 14);
            label1.TabIndex = 11;
            label1.Text = "Name";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(139, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(652, 23);
            txtEmail.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 131);
            label3.Name = "label3";
            label3.Size = new Size(82, 14);
            label3.TabIndex = 13;
            label3.Text = "Bank Name";
            // 
            // txtBankName
            // 
            txtBankName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBankName.Location = new Point(139, 127);
            txtBankName.Name = "txtBankName";
            txtBankName.Size = new Size(530, 23);
            txtBankName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 212);
            label4.Name = "label4";
            label4.Size = new Size(104, 14);
            label4.TabIndex = 15;
            label4.Text = "Currency Code";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 104);
            label5.Name = "label5";
            label5.Size = new Size(43, 14);
            label5.TabIndex = 17;
            label5.Text = "Email";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { VendorNumber, VendorName, BankName, BankAccountNo, SWIFTCode, CurrencyCode, Email, AddressLine1, AddressLine2, AddressLine3, IsActive });
            dataGridView.Location = new Point(15, 347);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(776, 134);
            dataGridView.TabIndex = 19;
            dataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
            // 
            // VendorNumber
            // 
            VendorNumber.HeaderText = "Vendor Number";
            VendorNumber.Name = "VendorNumber";
            VendorNumber.ReadOnly = true;
            VendorNumber.Width = 150;
            // 
            // VendorName
            // 
            VendorName.HeaderText = "Vendor Name";
            VendorName.Name = "VendorName";
            VendorName.ReadOnly = true;
            VendorName.Width = 150;
            // 
            // BankName
            // 
            BankName.HeaderText = "Bank Name";
            BankName.Name = "BankName";
            BankName.ReadOnly = true;
            // 
            // BankAccountNo
            // 
            BankAccountNo.HeaderText = "Bank Account No";
            BankAccountNo.Name = "BankAccountNo";
            BankAccountNo.ReadOnly = true;
            // 
            // SWIFTCode
            // 
            SWIFTCode.HeaderText = "SWIFT Code";
            SWIFTCode.Name = "SWIFTCode";
            SWIFTCode.ReadOnly = true;
            // 
            // CurrencyCode
            // 
            CurrencyCode.HeaderText = "Currency Code";
            CurrencyCode.Name = "CurrencyCode";
            CurrencyCode.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 250;
            // 
            // AddressLine1
            // 
            AddressLine1.HeaderText = "Address Line 1";
            AddressLine1.Name = "AddressLine1";
            AddressLine1.ReadOnly = true;
            // 
            // AddressLine2
            // 
            AddressLine2.HeaderText = "Address Line 2";
            AddressLine2.Name = "AddressLine2";
            AddressLine2.ReadOnly = true;
            // 
            // AddressLine3
            // 
            AddressLine3.HeaderText = "Address Line 3";
            AddressLine3.Name = "AddressLine3";
            AddressLine3.ReadOnly = true;
            // 
            // IsActive
            // 
            IsActive.HeaderText = "Is Active";
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(713, 490);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(551, 490);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnSageVendors
            // 
            btnSageVendors.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSageVendors.BackColor = Color.FromArgb(0, 128, 97);
            btnSageVendors.Cursor = Cursors.Hand;
            btnSageVendors.Enabled = false;
            btnSageVendors.FlatStyle = FlatStyle.Flat;
            btnSageVendors.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSageVendors.ForeColor = Color.FromArgb(226, 228, 213);
            btnSageVendors.Location = new Point(678, 190);
            btnSageVendors.Name = "btnSageVendors";
            btnSageVendors.Size = new Size(113, 57);
            btnSageVendors.TabIndex = 25;
            btnSageVendors.Text = "  Sage \r\nVendors";
            btnSageVendors.UseVisualStyleBackColor = false;
            btnSageVendors.Click += btnSageVendors_Click;
            // 
            // txtBankAccountNo
            // 
            txtBankAccountNo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBankAccountNo.Location = new Point(139, 154);
            txtBankAccountNo.Name = "txtBankAccountNo";
            txtBankAccountNo.Size = new Size(530, 23);
            txtBankAccountNo.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 158);
            label6.Name = "label6";
            label6.Size = new Size(96, 14);
            label6.TabIndex = 27;
            label6.Text = "Bank Account";
            // 
            // btnRefesh
            // 
            btnRefesh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefesh.Cursor = Cursors.Hand;
            btnRefesh.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefesh.Location = new Point(632, 490);
            btnRefesh.Name = "btnRefesh";
            btnRefesh.Size = new Size(75, 23);
            btnRefesh.TabIndex = 23;
            btnRefesh.Text = "Refresh";
            btnRefesh.UseVisualStyleBackColor = true;
            btnRefesh.Click += btnRefresh_Click_1;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(15, 318);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(776, 23);
            progressBar.TabIndex = 29;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(678, 255);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 57);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "  Add To\r\n  Table";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkIsActive.Location = new Point(675, 48);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(113, 18);
            chkIsActive.TabIndex = 32;
            chkIsActive.Text = "Active Status";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtSWIFTCode
            // 
            txtSWIFTCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSWIFTCode.Location = new Point(139, 181);
            txtSWIFTCode.Name = "txtSWIFTCode";
            txtSWIFTCode.Size = new Size(530, 23);
            txtSWIFTCode.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 185);
            label7.Name = "label7";
            label7.Size = new Size(89, 14);
            label7.TabIndex = 33;
            label7.Text = "SWIFT Code";
            // 
            // cmbCurrencyCode
            // 
            cmbCurrencyCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbCurrencyCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCurrencyCode.FormattingEnabled = true;
            cmbCurrencyCode.Location = new Point(139, 208);
            cmbCurrencyCode.Name = "cmbCurrencyCode";
            cmbCurrencyCode.Size = new Size(530, 23);
            cmbCurrencyCode.TabIndex = 34;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNew.BackColor = SystemColors.Control;
            btnNew.Cursor = Cursors.Hand;
            btnNew.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.Black;
            btnNew.Location = new Point(678, 127);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(113, 57);
            btnNew.TabIndex = 35;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // txtAddressLine1
            // 
            txtAddressLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddressLine1.Location = new Point(139, 235);
            txtAddressLine1.Name = "txtAddressLine1";
            txtAddressLine1.Size = new Size(530, 23);
            txtAddressLine1.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 239);
            label8.Name = "label8";
            label8.Size = new Size(105, 14);
            label8.TabIndex = 37;
            label8.Text = "Address Line 1";
            // 
            // txtAddressLine2
            // 
            txtAddressLine2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddressLine2.Location = new Point(139, 262);
            txtAddressLine2.Name = "txtAddressLine2";
            txtAddressLine2.Size = new Size(530, 23);
            txtAddressLine2.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(19, 266);
            label9.Name = "label9";
            label9.Size = new Size(105, 14);
            label9.TabIndex = 39;
            label9.Text = "Address Line 2";
            // 
            // txtAddressLine3
            // 
            txtAddressLine3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddressLine3.Location = new Point(139, 289);
            txtAddressLine3.Name = "txtAddressLine3";
            txtAddressLine3.Size = new Size(530, 23);
            txtAddressLine3.TabIndex = 40;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(19, 293);
            label11.Name = "label11";
            label11.Size = new Size(105, 14);
            label11.TabIndex = 41;
            label11.Text = "Address Line 3";
            // 
            // frmVendors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 520);
            Controls.Add(txtBankAccountNo);
            Controls.Add(txtBankName);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtAddressLine3);
            Controls.Add(cmbCurrencyCode);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(btnAdd);
            Controls.Add(txtAddressLine2);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label11);
            Controls.Add(btnSageVendors);
            Controls.Add(txtSWIFTCode);
            Controls.Add(btnNew);
            Controls.Add(txtAddressLine1);
            Controls.Add(progressBar);
            Controls.Add(txtVendorName);
            Controls.Add(chkIsActive);
            Controls.Add(btnCancel);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btnRefesh);
            Controls.Add(btnSave);
            Controls.Add(dataGridView);
            Controls.Add(lblVendors);
            Controls.Add(txtVendorNumber);
            Name = "frmVendors";
            Text = "frmVendors";
            Load += frmVendors_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVendors;
        private Label label2;
        private TextBox txtVendorNumber;
        private TextBox txtVendorName;
        private Label label1;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtBankName;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView;
        private Button btnCancel;
        private Button btnSave;
        private Button btnEdit;
        private Button btnSageVendors;
        private TextBox txtBankAccountNo;
        private Label label6;
        private Button btnRefesh;
        private ProgressBar progressBar;
        private Button btnAdd;
        private CheckBox chkIsActive;
        private TextBox txtSWIFTCode;
        private Label label7;
        private ComboBox cmbCurrencyCode;
        private Button btnNew;
        private TextBox txtAddressLine1;
        private Label label8;
        private TextBox txtAddressLine2;
        private Label label9;
        private TextBox txtAddressLine3;
        private Label label11;
        private DataGridViewTextBoxColumn VendorNumber;
        private DataGridViewTextBoxColumn VendorName;
        private DataGridViewTextBoxColumn BankName;
        private DataGridViewTextBoxColumn BankAccountNo;
        private DataGridViewTextBoxColumn SWIFTCode;
        private DataGridViewTextBoxColumn CurrencyCode;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn AddressLine1;
        private DataGridViewTextBoxColumn AddressLine2;
        private DataGridViewTextBoxColumn AddressLine3;
        private DataGridViewTextBoxColumn IsActive;
    }
}