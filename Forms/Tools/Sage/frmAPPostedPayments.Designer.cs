namespace LANMIC_ComBank_Interface.Forms.Tools.Sage
{
    partial class frmAPPostedPayments
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblVendors = new Label();
            btnNew = new Button();
            btnClose = new Button();
            btnSave = new Button();
            btnLoadSageAPPostedPayments = new Button();
            progressBar = new ProgressBar();
            dataGridView = new DataGridView();
            Select = new DataGridViewCheckBoxColumn();
            DocumentNumber = new DataGridViewTextBoxColumn();
            DocumentType = new DataGridViewTextBoxColumn();
            VendorNumber = new DataGridViewTextBoxColumn();
            VendorName = new DataGridViewTextBoxColumn();
            PaymentAmount = new DataGridViewTextBoxColumn();
            BankName = new DataGridViewTextBoxColumn();
            BankAccountNo = new DataGridViewTextBoxColumn();
            SWIFTCode = new DataGridViewTextBoxColumn();
            CurrencyCode = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            PostingDate = new DataGridViewTextBoxColumn();
            CurrentStatus = new DataGridViewTextBoxColumn();
            dtpFromDate = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            dtpToDate = new DateTimePicker();
            cmbDocumentTypes = new ComboBox();
            label4 = new Label();
            cmbVendors = new ComboBox();
            label5 = new Label();
            btnRefresh = new Button();
            btnDelete = new Button();
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
            lblVendors.Size = new Size(248, 30);
            lblVendors.TabIndex = 9;
            lblVendors.Text = "AP POSTED PAYMENTS ";
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNew.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(547, 39);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(116, 47);
            btnNew.TabIndex = 25;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(709, 497);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 24;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(466, 497);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoadSageAPPostedPayments
            // 
            btnLoadSageAPPostedPayments.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLoadSageAPPostedPayments.BackColor = Color.FromArgb(0, 128, 97);
            btnLoadSageAPPostedPayments.Cursor = Cursors.Hand;
            btnLoadSageAPPostedPayments.Enabled = false;
            btnLoadSageAPPostedPayments.FlatStyle = FlatStyle.Flat;
            btnLoadSageAPPostedPayments.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadSageAPPostedPayments.ForeColor = Color.FromArgb(226, 228, 213);
            btnLoadSageAPPostedPayments.Location = new Point(668, 38);
            btnLoadSageAPPostedPayments.Name = "btnLoadSageAPPostedPayments";
            btnLoadSageAPPostedPayments.Size = new Size(116, 47);
            btnLoadSageAPPostedPayments.TabIndex = 27;
            btnLoadSageAPPostedPayments.Text = "Load Posted Payments";
            btnLoadSageAPPostedPayments.UseVisualStyleBackColor = false;
            btnLoadSageAPPostedPayments.Click += btnLoadSageAPPostedPayments_Click;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(7, 96);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(776, 23);
            progressBar.TabIndex = 30;
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Select, DocumentNumber, DocumentType, VendorNumber, VendorName, PaymentAmount, BankName, BankAccountNo, SWIFTCode, CurrencyCode, Email, PostingDate, CurrentStatus });
            dataGridView.Location = new Point(8, 125);
            dataGridView.Name = "dataGridView";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(776, 366);
            dataGridView.TabIndex = 31;
            // 
            // Select
            // 
            Select.HeaderText = "";
            Select.Name = "Select";
            Select.Width = 50;
            // 
            // DocumentNumber
            // 
            DocumentNumber.HeaderText = "Document Number";
            DocumentNumber.Name = "DocumentNumber";
            DocumentNumber.ReadOnly = true;
            DocumentNumber.Width = 200;
            // 
            // DocumentType
            // 
            DocumentType.HeaderText = "Document Type";
            DocumentType.Name = "DocumentType";
            DocumentType.ReadOnly = true;
            DocumentType.Width = 150;
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
            // PaymentAmount
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            PaymentAmount.DefaultCellStyle = dataGridViewCellStyle2;
            PaymentAmount.HeaderText = "Payment Amount";
            PaymentAmount.Name = "PaymentAmount";
            PaymentAmount.ReadOnly = true;
            PaymentAmount.Width = 150;
            // 
            // BankName
            // 
            BankName.HeaderText = "Bank Name";
            BankName.Name = "BankName";
            // 
            // BankAccountNo
            // 
            BankAccountNo.HeaderText = "Bank Account No";
            BankAccountNo.Name = "BankAccountNo";
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
            // 
            // PostingDate
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            PostingDate.DefaultCellStyle = dataGridViewCellStyle3;
            PostingDate.HeaderText = "Posting Date";
            PostingDate.Name = "PostingDate";
            PostingDate.ReadOnly = true;
            // 
            // CurrentStatus
            // 
            CurrentStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CurrentStatus.HeaderText = "Current Status";
            CurrentStatus.Name = "CurrentStatus";
            CurrentStatus.ReadOnly = true;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Format = DateTimePickerFormat.Short;
            dtpFromDate.Location = new Point(332, 34);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(93, 23);
            dtpFromDate.TabIndex = 32;
            dtpFromDate.ValueChanged += dtpFromDate_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(242, 38);
            label2.Name = "label2";
            label2.Size = new Size(76, 14);
            label2.TabIndex = 34;
            label2.Text = "From Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(268, 71);
            label1.Name = "label1";
            label1.Size = new Size(58, 14);
            label1.TabIndex = 36;
            label1.Text = "To Date";
            // 
            // dtpToDate
            // 
            dtpToDate.Format = DateTimePickerFormat.Short;
            dtpToDate.Location = new Point(332, 67);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(93, 23);
            dtpToDate.TabIndex = 35;
            dtpToDate.ValueChanged += dtpToDate_ValueChanged;
            // 
            // cmbDocumentTypes
            // 
            cmbDocumentTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDocumentTypes.FormattingEnabled = true;
            cmbDocumentTypes.Location = new Point(78, 67);
            cmbDocumentTypes.Name = "cmbDocumentTypes";
            cmbDocumentTypes.Size = new Size(158, 23);
            cmbDocumentTypes.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 39);
            label4.Name = "label4";
            label4.Size = new Size(61, 14);
            label4.TabIndex = 37;
            label4.Text = "Vendors";
            // 
            // cmbVendors
            // 
            cmbVendors.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVendors.FormattingEnabled = true;
            cmbVendors.Location = new Point(78, 34);
            cmbVendors.Name = "cmbVendors";
            cmbVendors.Size = new Size(158, 23);
            cmbVendors.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 71);
            label5.Name = "label5";
            label5.Size = new Size(68, 14);
            label5.TabIndex = 37;
            label5.Text = "Doc Type";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(628, 497);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 39;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(547, 497);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 40;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmAPPostedPayments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 532);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(cmbVendors);
            Controls.Add(label4);
            Controls.Add(cmbDocumentTypes);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(dtpToDate);
            Controls.Add(label2);
            Controls.Add(dtpFromDate);
            Controls.Add(dataGridView);
            Controls.Add(progressBar);
            Controls.Add(btnLoadSageAPPostedPayments);
            Controls.Add(btnNew);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(lblVendors);
            Name = "frmAPPostedPayments";
            Text = "frmAPPostedPayments";
            Load += frmAPPostedPayments_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVendors;
        private Button btnNew;
        private Button btnClose;
        private Button btnPrint;
        private Button btnSave;
        private Button btnLoadSageAPPostedPayments;
        private ProgressBar progressBar;
        private DataGridView dataGridView;
        private DateTimePicker dtpFromDate;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpToDate;
        private Label label3;
        private ComboBox cmbDocumentTypes;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox cmbVendors;
        private Label label5;
        private DataGridViewTextBoxColumn VenderName;
        private Button btnRefresh;
        private Button btnDelete;
        private DataGridViewCheckBoxColumn Select;
        private DataGridViewTextBoxColumn DocumentNumber;
        private DataGridViewTextBoxColumn DocumentType;
        private DataGridViewTextBoxColumn VendorNumber;
        private DataGridViewTextBoxColumn VendorName;
        private DataGridViewTextBoxColumn PaymentAmount;
        private DataGridViewTextBoxColumn BankName;
        private DataGridViewTextBoxColumn BankAccountNo;
        private DataGridViewTextBoxColumn SWIFTCode;
        private DataGridViewTextBoxColumn CurrencyCode;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn PostingDate;
        private DataGridViewTextBoxColumn CurrentStatus;
    }
}