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
            txtSWIFTCode = new TextBox();
            label5 = new Label();
            dataGridView = new DataGridView();
            VendorNumber = new DataGridViewTextBoxColumn();
            VendorName = new DataGridViewTextBoxColumn();
            BankName = new DataGridViewTextBoxColumn();
            SWIFTCode = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnCancel = new Button();
            btnSave = new Button();
            btnSageVendors = new Button();
            btnSearch = new Button();
            textBox6 = new TextBox();
            label6 = new Label();
            btnRefesh = new Button();
            progressBar = new ProgressBar();
            btnAdd = new Button();
            btnPrint = new Button();
            chkIsActive = new CheckBox();
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
            lblVendors.Size = new Size(107, 30);
            lblVendors.TabIndex = 8;
            lblVendors.Text = "VENDERS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(59, 14);
            label2.TabIndex = 9;
            label2.Text = "Number";
            // 
            // txtVendorNumber
            // 
            txtVendorNumber.Location = new Point(106, 43);
            txtVendorNumber.Name = "txtVendorNumber";
            txtVendorNumber.ReadOnly = true;
            txtVendorNumber.Size = new Size(250, 23);
            txtVendorNumber.TabIndex = 10;
            // 
            // txtVendorName
            // 
            txtVendorName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtVendorName.Location = new Point(106, 72);
            txtVendorName.Name = "txtVendorName";
            txtVendorName.ReadOnly = true;
            txtVendorName.Size = new Size(560, 23);
            txtVendorName.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 76);
            label1.Name = "label1";
            label1.Size = new Size(45, 14);
            label1.TabIndex = 11;
            label1.Text = "Name";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(106, 101);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(560, 23);
            txtEmail.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(82, 14);
            label3.TabIndex = 13;
            label3.Text = "Bank Name";
            // 
            // txtBankName
            // 
            txtBankName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBankName.Location = new Point(106, 130);
            txtBankName.Name = "txtBankName";
            txtBankName.Size = new Size(560, 23);
            txtBankName.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 162);
            label4.Name = "label4";
            label4.Size = new Size(89, 14);
            label4.TabIndex = 15;
            label4.Text = "SWIFT Code";
            // 
            // txtSWIFTCode
            // 
            txtSWIFTCode.Location = new Point(106, 158);
            txtSWIFTCode.Name = "txtSWIFTCode";
            txtSWIFTCode.Size = new Size(250, 23);
            txtSWIFTCode.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 105);
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { VendorNumber, VendorName, BankName, SWIFTCode, Email, Status });
            dataGridView.Location = new Point(12, 216);
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
            dataGridView.Size = new Size(776, 263);
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
            VendorName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VendorName.HeaderText = "Vendor Name";
            VendorName.Name = "VendorName";
            VendorName.ReadOnly = true;
            // 
            // BankName
            // 
            BankName.HeaderText = "Bank Name";
            BankName.Name = "BankName";
            BankName.ReadOnly = true;
            // 
            // SWIFTCode
            // 
            SWIFTCode.HeaderText = "SWIFT Code";
            SWIFTCode.Name = "SWIFTCode";
            SWIFTCode.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 250;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 50;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(713, 485);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(470, 485);
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
            btnSageVendors.FlatStyle = FlatStyle.Flat;
            btnSageVendors.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSageVendors.ForeColor = Color.FromArgb(226, 228, 213);
            btnSageVendors.Location = new Point(672, 53);
            btnSageVendors.Name = "btnSageVendors";
            btnSageVendors.Size = new Size(116, 47);
            btnSageVendors.TabIndex = 25;
            btnSageVendors.Text = "  Sage \r\nVendors";
            btnSageVendors.UseVisualStyleBackColor = false;
            btnSageVendors.Click += btnSageVendors_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(713, 159);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 26;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox6.Location = new Point(489, 159);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(218, 23);
            textBox6.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(379, 163);
            label6.Name = "label6";
            label6.Size = new Size(104, 14);
            label6.TabIndex = 27;
            label6.Text = "Search Vendor";
            // 
            // btnRefesh
            // 
            btnRefesh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefesh.Cursor = Cursors.Hand;
            btnRefesh.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefesh.Location = new Point(632, 485);
            btnRefesh.Name = "btnRefesh";
            btnRefesh.Size = new Size(75, 23);
            btnRefesh.TabIndex = 23;
            btnRefesh.Text = "Refresh";
            btnRefesh.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(12, 187);
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
            btnAdd.Location = new Point(672, 106);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 47);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "  Add To\r\n  Table";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrint.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(551, 485);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 31;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkIsActive.Location = new Point(362, 45);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(113, 18);
            chkIsActive.TabIndex = 32;
            chkIsActive.Text = "Active Status";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // frmVendors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 520);
            Controls.Add(chkIsActive);
            Controls.Add(btnPrint);
            Controls.Add(btnAdd);
            Controls.Add(progressBar);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(btnSearch);
            Controls.Add(btnSageVendors);
            Controls.Add(btnCancel);
            Controls.Add(btnRefesh);
            Controls.Add(btnSave);
            Controls.Add(dataGridView);
            Controls.Add(txtSWIFTCode);
            Controls.Add(label5);
            Controls.Add(txtBankName);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtVendorName);
            Controls.Add(label1);
            Controls.Add(txtVendorNumber);
            Controls.Add(label2);
            Controls.Add(lblVendors);
            Name = "frmVendors";
            Text = "frmVendors";
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
        private TextBox txtSWIFTCode;
        private Label label5;
        private DataGridView dataGridView;
        private Button btnCancel;
        private Button btnSave;
        private Button btnEdit;
        private Button btnSageVendors;
        private Button btnSearch;
        private TextBox textBox6;
        private Label label6;
        private Button btnRefesh;
        private ProgressBar progressBar;
        private Button btnAdd;
        private Button btnPrint;
        private DataGridViewTextBoxColumn VendorNumber;
        private DataGridViewTextBoxColumn VendorName;
        private DataGridViewTextBoxColumn BankName;
        private DataGridViewTextBoxColumn SWIFTCode;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Status;
        private CheckBox chkIsActive;
    }
}