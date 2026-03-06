namespace LANMIC_ComBank_Interface.Forms.Tools.Sage
{
    partial class frmBanks
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblBanks = new Label();
            btnAdd = new Button();
            progressBar = new ProgressBar();
            btnCancel = new Button();
            btnRefesh = new Button();
            btnSave = new Button();
            dataGridView = new DataGridView();
            BankCode = new DataGridViewTextBoxColumn();
            BankName = new DataGridViewTextBoxColumn();
            AccountNo = new DataGridViewTextBoxColumn();
            Currency = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtBankCode = new TextBox();
            label2 = new Label();
            txtCurrency = new TextBox();
            label4 = new Label();
            txtBankAccountNo = new TextBox();
            label5 = new Label();
            cmbSageBanks = new ComboBox();
            btnGetSageBanks = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // lblBanks
            // 
            lblBanks.AutoSize = true;
            lblBanks.Dock = DockStyle.Top;
            lblBanks.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBanks.Location = new Point(0, 0);
            lblBanks.Name = "lblBanks";
            lblBanks.Size = new Size(84, 30);
            lblBanks.TabIndex = 8;
            lblBanks.Text = "BANKS";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(714, 109);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 47);
            btnAdd.TabIndex = 52;
            btnAdd.Text = "  Add To\r\n  Table";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(12, 162);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(818, 23);
            progressBar.TabIndex = 51;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(755, 488);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 46;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRefesh
            // 
            btnRefesh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefesh.Cursor = Cursors.Hand;
            btnRefesh.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefesh.Location = new Point(674, 488);
            btnRefesh.Name = "btnRefesh";
            btnRefesh.Size = new Size(75, 23);
            btnRefesh.TabIndex = 45;
            btnRefesh.Text = "Refresh";
            btnRefesh.UseVisualStyleBackColor = true;
            btnRefesh.Click += btnRefresh_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(512, 488);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 44;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { BankCode, BankName, AccountNo, Currency });
            dataGridView.Location = new Point(12, 191);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(818, 291);
            dataGridView.TabIndex = 43;
            // 
            // BankCode
            // 
            BankCode.HeaderText = "Bank Code";
            BankCode.Name = "BankCode";
            BankCode.ReadOnly = true;
            // 
            // BankName
            // 
            BankName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BankName.HeaderText = "Bank Name";
            BankName.Name = "BankName";
            BankName.ReadOnly = true;
            // 
            // AccountNo
            // 
            AccountNo.HeaderText = "Account No";
            AccountNo.Name = "AccountNo";
            AccountNo.ReadOnly = true;
            // 
            // Currency
            // 
            Currency.HeaderText = "Currency";
            Currency.Name = "Currency";
            Currency.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(82, 14);
            label1.TabIndex = 35;
            label1.Text = "Bank Name";
            // 
            // txtBankCode
            // 
            txtBankCode.Location = new Point(100, 45);
            txtBankCode.Name = "txtBankCode";
            txtBankCode.ReadOnly = true;
            txtBankCode.Size = new Size(256, 23);
            txtBankCode.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(77, 14);
            label2.TabIndex = 33;
            label2.Text = "Bank Code";
            // 
            // txtCurrency
            // 
            txtCurrency.Location = new Point(100, 133);
            txtCurrency.Name = "txtCurrency";
            txtCurrency.ReadOnly = true;
            txtCurrency.Size = new Size(608, 23);
            txtCurrency.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 136);
            label4.Name = "label4";
            label4.Size = new Size(67, 14);
            label4.TabIndex = 65;
            label4.Text = "Currency";
            // 
            // txtBankAccountNo
            // 
            txtBankAccountNo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBankAccountNo.Location = new Point(100, 103);
            txtBankAccountNo.Name = "txtBankAccountNo";
            txtBankAccountNo.ReadOnly = true;
            txtBankAccountNo.Size = new Size(608, 23);
            txtBankAccountNo.TabIndex = 68;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 107);
            label5.Name = "label5";
            label5.Size = new Size(81, 14);
            label5.TabIndex = 67;
            label5.Text = "Account No";
            // 
            // cmbSageBanks
            // 
            cmbSageBanks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbSageBanks.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSageBanks.FormattingEnabled = true;
            cmbSageBanks.Location = new Point(100, 74);
            cmbSageBanks.Name = "cmbSageBanks";
            cmbSageBanks.Size = new Size(608, 23);
            cmbSageBanks.TabIndex = 70;
            cmbSageBanks.SelectedIndexChanged += cmbSageBanks_SelectedIndexChanged;
            // 
            // btnGetSageBanks
            // 
            btnGetSageBanks.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetSageBanks.BackColor = Color.FromArgb(0, 128, 97);
            btnGetSageBanks.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetSageBanks.ForeColor = Color.White;
            btnGetSageBanks.Location = new Point(714, 56);
            btnGetSageBanks.Name = "btnGetSageBanks";
            btnGetSageBanks.Size = new Size(116, 47);
            btnGetSageBanks.TabIndex = 71;
            btnGetSageBanks.Text = "Load Sage Banks";
            btnGetSageBanks.UseVisualStyleBackColor = false;
            btnGetSageBanks.Click += btnGetSageBanks_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.BackColor = SystemColors.Control;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(593, 488);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 72;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmBanks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 523);
            Controls.Add(btnDelete);
            Controls.Add(btnGetSageBanks);
            Controls.Add(cmbSageBanks);
            Controls.Add(txtBankAccountNo);
            Controls.Add(label5);
            Controls.Add(txtCurrency);
            Controls.Add(label4);
            Controls.Add(btnAdd);
            Controls.Add(progressBar);
            Controls.Add(btnCancel);
            Controls.Add(btnRefesh);
            Controls.Add(btnSave);
            Controls.Add(dataGridView);
            Controls.Add(label1);
            Controls.Add(txtBankCode);
            Controls.Add(label2);
            Controls.Add(lblBanks);
            Name = "frmBanks";
            Text = "frmBanks";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBanks;
        private Button btnAdd;
        private ProgressBar progressBar;
        private Button btnCancel;
        private Button btnRefesh;
        private Button btnSave;
        private DataGridView dataGridView;
        private Label label1;
        private TextBox txtBankCode;
        private Label label2;
        private TextBox txtCurrency;
        private Label label4;
        private TextBox txtBankAccountNo;
        private Label label5;
        private ComboBox cmbSageBanks;
        private DataGridViewTextBoxColumn BankCode;
        private DataGridViewTextBoxColumn BankName;
        private DataGridViewTextBoxColumn AccountNo;
        private DataGridViewTextBoxColumn Currency;
        private Button btnGetSageBanks;
        private Button btnDelete;
    }
}