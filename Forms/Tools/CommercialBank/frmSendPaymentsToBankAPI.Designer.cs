namespace LANMIC_ComBank_Interface.Forms.Tools.CommercialBank
{
    partial class frmSendPaymentsToBankAPI
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
            lbl = new Label();
            cmbVendors = new ComboBox();
            label4 = new Label();
            cmbDocumentTypes = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            dtpToDate = new DateTimePicker();
            label2 = new Label();
            dtpFromDate = new DateTimePicker();
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
            btnClose = new Button();
            btnView = new Button();
            btnSentToBank = new Button();
            cmbCurrentStatus = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Dock = DockStyle.Top;
            lbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(0, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(323, 30);
            lbl.TabIndex = 10;
            lbl.Text = "SEND PAYMENTS TO BANK API";
            // 
            // cmbVendors
            // 
            cmbVendors.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVendors.FormattingEnabled = true;
            cmbVendors.Location = new Point(443, 45);
            cmbVendors.Name = "cmbVendors";
            cmbVendors.Size = new Size(158, 23);
            cmbVendors.TabIndex = 46;
            cmbVendors.SelectedIndexChanged += cmbVendors_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(377, 49);
            label4.Name = "label4";
            label4.Size = new Size(61, 14);
            label4.TabIndex = 44;
            label4.Text = "Vendors";
            // 
            // cmbDocumentTypes
            // 
            cmbDocumentTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDocumentTypes.FormattingEnabled = true;
            cmbDocumentTypes.Location = new Point(102, 74);
            cmbDocumentTypes.Name = "cmbDocumentTypes";
            cmbDocumentTypes.Size = new Size(178, 23);
            cmbDocumentTypes.TabIndex = 47;
            cmbDocumentTypes.SelectedIndexChanged += cmbDocumentTypes_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 77);
            label5.Name = "label5";
            label5.Size = new Size(75, 14);
            label5.TabIndex = 45;
            label5.Text = "Doc Types";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 49);
            label1.Name = "label1";
            label1.Size = new Size(58, 14);
            label1.TabIndex = 43;
            label1.Text = "To Date";
            // 
            // dtpToDate
            // 
            dtpToDate.Format = DateTimePickerFormat.Short;
            dtpToDate.Location = new Point(278, 45);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(93, 23);
            dtpToDate.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(76, 14);
            label2.TabIndex = 41;
            label2.Text = "From Date";
            // 
            // dtpFromDate
            // 
            dtpFromDate.Format = DateTimePickerFormat.Short;
            dtpFromDate.Location = new Point(102, 45);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(93, 23);
            dtpFromDate.TabIndex = 40;
            dtpFromDate.ValueChanged += dtpFromDate_ValueChanged;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(12, 103);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(833, 23);
            progressBar.TabIndex = 39;
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
            dataGridView.Location = new Point(12, 132);
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
            dataGridView.Size = new Size(833, 366);
            dataGridView.TabIndex = 50;
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
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(770, 504);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 49;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            btnView.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnView.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnView.Location = new Point(607, 45);
            btnView.Name = "btnView";
            btnView.Size = new Size(116, 47);
            btnView.TabIndex = 53;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnSentToBank
            // 
            btnSentToBank.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSentToBank.BackColor = Color.FromArgb(10, 88, 165);
            btnSentToBank.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSentToBank.ForeColor = Color.White;
            btnSentToBank.Location = new Point(729, 45);
            btnSentToBank.Name = "btnSentToBank";
            btnSentToBank.Size = new Size(116, 47);
            btnSentToBank.TabIndex = 54;
            btnSentToBank.Text = "Send To Bank";
            btnSentToBank.UseVisualStyleBackColor = false;
            btnSentToBank.Click += btnSentToBank_Click;
            // 
            // cmbCurrentStatus
            // 
            cmbCurrentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCurrentStatus.FormattingEnabled = true;
            cmbCurrentStatus.Location = new Point(395, 74);
            cmbCurrentStatus.Name = "cmbCurrentStatus";
            cmbCurrentStatus.Size = new Size(206, 23);
            cmbCurrentStatus.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(286, 78);
            label3.Name = "label3";
            label3.Size = new Size(103, 14);
            label3.TabIndex = 55;
            label3.Text = "Current Status";
            // 
            // frmSendPaymentsToBankAPI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 532);
            Controls.Add(cmbCurrentStatus);
            Controls.Add(label3);
            Controls.Add(btnSentToBank);
            Controls.Add(btnView);
            Controls.Add(dataGridView);
            Controls.Add(btnClose);
            Controls.Add(cmbVendors);
            Controls.Add(label4);
            Controls.Add(cmbDocumentTypes);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(dtpToDate);
            Controls.Add(label2);
            Controls.Add(dtpFromDate);
            Controls.Add(progressBar);
            Controls.Add(lbl);
            Name = "frmSendPaymentsToBankAPI";
            Text = "frmSendPaymentsToBankAPI";
            Load += frmSendPaymentsToBankAPI_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private ComboBox cmbVendors;
        private Label label4;
        private ComboBox cmbDocumentTypes;
        private Label label5;
        private Label label1;
        private DateTimePicker dtpToDate;
        private Label label2;
        private DateTimePicker dtpFromDate;
        private ProgressBar progressBar;
        private Button btnRefresh;
        private DataGridView dataGridView;
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
        private Button btnClose;
        private Button btnView;
        private Button btnSentToBank;
        private ComboBox cmbCurrentStatus;
        private Label label3;
    }
}