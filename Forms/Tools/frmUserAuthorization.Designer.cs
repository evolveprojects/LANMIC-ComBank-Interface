namespace LANMIC_ComBank_Interface.Forms.Tools.UserAuthorization
{
    partial class frmUserAuthorization
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
            lblUserAuthority = new Label();
            txtUserName = new Label();
            txtOperationalModule = new Label();
            cmbUserName = new ComboBox();
            cmbOperationalModule = new ComboBox();
            panel1 = new Panel();
            chkPrint = new CheckBox();
            chkDelete = new CheckBox();
            chkEdit = new CheckBox();
            chkNew = new CheckBox();
            chkView = new CheckBox();
            btnRemove = new Button();
            btnAdd = new Button();
            dataGridView = new DataGridView();
            UserID = new DataGridViewTextBoxColumn();
            FormID = new DataGridViewTextBoxColumn();
            PermissionID = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            ModuleName = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewCheckBoxColumn();
            Column3 = new DataGridViewCheckBoxColumn();
            Column4 = new DataGridViewCheckBoxColumn();
            Column5 = new DataGridViewCheckBoxColumn();
            Column6 = new DataGridViewCheckBoxColumn();
            btnSave = new Button();
            btnClear = new Button();
            btnPrint = new Button();
            btnClose = new Button();
            btnNew = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // lblUserAuthority
            // 
            lblUserAuthority.AutoSize = true;
            lblUserAuthority.Dock = DockStyle.Top;
            lblUserAuthority.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserAuthority.Location = new Point(0, 0);
            lblUserAuthority.Name = "lblUserAuthority";
            lblUserAuthority.Size = new Size(191, 30);
            lblUserAuthority.TabIndex = 7;
            lblUserAuthority.Text = "USER AUTHORITY";
            // 
            // txtUserName
            // 
            txtUserName.AutoSize = true;
            txtUserName.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(12, 48);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(80, 14);
            txtUserName.TabIndex = 8;
            txtUserName.Text = "User Name";
            // 
            // txtOperationalModule
            // 
            txtOperationalModule.AutoSize = true;
            txtOperationalModule.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOperationalModule.Location = new Point(12, 77);
            txtOperationalModule.Name = "txtOperationalModule";
            txtOperationalModule.Size = new Size(136, 14);
            txtOperationalModule.TabIndex = 9;
            txtOperationalModule.Text = "Operational Module";
            // 
            // cmbUserName
            // 
            cmbUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbUserName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUserName.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbUserName.FormattingEnabled = true;
            cmbUserName.Location = new Point(173, 45);
            cmbUserName.Name = "cmbUserName";
            cmbUserName.Size = new Size(615, 22);
            cmbUserName.TabIndex = 10;
            cmbUserName.SelectedIndexChanged += cmbUserName_SelectedIndexChanged;
            // 
            // cmbOperationalModule
            // 
            cmbOperationalModule.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbOperationalModule.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperationalModule.Enabled = false;
            cmbOperationalModule.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbOperationalModule.FormattingEnabled = true;
            cmbOperationalModule.Location = new Point(173, 74);
            cmbOperationalModule.Name = "cmbOperationalModule";
            cmbOperationalModule.Size = new Size(615, 22);
            cmbOperationalModule.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(chkPrint);
            panel1.Controls.Add(chkDelete);
            panel1.Controls.Add(chkEdit);
            panel1.Controls.Add(chkNew);
            panel1.Controls.Add(chkView);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(173, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 32);
            panel1.TabIndex = 12;
            // 
            // chkPrint
            // 
            chkPrint.AutoSize = true;
            chkPrint.Enabled = false;
            chkPrint.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkPrint.Location = new Point(287, 7);
            chkPrint.Name = "chkPrint";
            chkPrint.Size = new Size(58, 18);
            chkPrint.TabIndex = 4;
            chkPrint.Text = "Print";
            chkPrint.UseVisualStyleBackColor = true;
            chkPrint.CheckedChanged += CheckedChanged;
            // 
            // chkDelete
            // 
            chkDelete.AutoSize = true;
            chkDelete.Enabled = false;
            chkDelete.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkDelete.Location = new Point(212, 7);
            chkDelete.Name = "chkDelete";
            chkDelete.Size = new Size(69, 18);
            chkDelete.TabIndex = 3;
            chkDelete.Text = "Delete";
            chkDelete.UseVisualStyleBackColor = true;
            chkDelete.CheckedChanged += CheckedChanged;
            // 
            // chkEdit
            // 
            chkEdit.AutoSize = true;
            chkEdit.Enabled = false;
            chkEdit.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEdit.Location = new Point(155, 7);
            chkEdit.Name = "chkEdit";
            chkEdit.Size = new Size(51, 18);
            chkEdit.TabIndex = 2;
            chkEdit.Text = "Edit";
            chkEdit.UseVisualStyleBackColor = true;
            chkEdit.CheckedChanged += CheckedChanged;
            // 
            // chkNew
            // 
            chkNew.AutoSize = true;
            chkNew.Enabled = false;
            chkNew.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkNew.Location = new Point(93, 7);
            chkNew.Name = "chkNew";
            chkNew.Size = new Size(56, 18);
            chkNew.TabIndex = 1;
            chkNew.Text = "New";
            chkNew.UseVisualStyleBackColor = true;
            chkNew.CheckedChanged += CheckedChanged;
            // 
            // chkView
            // 
            chkView.AutoSize = true;
            chkView.Enabled = false;
            chkView.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkView.Location = new Point(28, 7);
            chkView.Name = "chkView";
            chkView.Size = new Size(59, 18);
            chkView.TabIndex = 0;
            chkView.Text = "View";
            chkView.UseVisualStyleBackColor = true;
            chkView.CheckedChanged += chkView_CheckedChanged;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemove.Enabled = false;
            btnRemove.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(525, 5);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 14;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Enabled = false;
            btnAdd.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(444, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
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
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { UserID, FormID, PermissionID, UserName, ModuleName, Column2, Column3, Column4, Column5, Column6 });
            dataGridView.Location = new Point(12, 142);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(776, 433);
            dataGridView.TabIndex = 15;
            dataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
            // 
            // UserID
            // 
            UserID.HeaderText = "User ID";
            UserID.Name = "UserID";
            UserID.ReadOnly = true;
            UserID.Visible = false;
            // 
            // FormID
            // 
            FormID.HeaderText = "Form ID";
            FormID.Name = "FormID";
            FormID.ReadOnly = true;
            FormID.Visible = false;
            // 
            // PermissionID
            // 
            PermissionID.HeaderText = "Permission ID";
            PermissionID.Name = "PermissionID";
            PermissionID.ReadOnly = true;
            PermissionID.Visible = false;
            // 
            // UserName
            // 
            UserName.HeaderText = "User Name";
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            // 
            // ModuleName
            // 
            ModuleName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ModuleName.HeaderText = "Module Name";
            ModuleName.Name = "ModuleName";
            ModuleName.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "View";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.True;
            Column2.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            Column3.HeaderText = "New";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.True;
            Column3.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            Column4.HeaderText = "Edit";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.True;
            Column4.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            Column5.HeaderText = "Delete";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Column6
            // 
            Column6.HeaderText = "Print";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Resizable = DataGridViewTriState.True;
            Column6.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Enabled = false;
            btnSave.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(470, 581);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(632, 581);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrint.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(551, 581);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 18;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(713, 581);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 19;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNew.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(389, 581);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 20;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // frmUserAuthorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 616);
            Controls.Add(btnNew);
            Controls.Add(btnClose);
            Controls.Add(btnPrint);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            Controls.Add(cmbOperationalModule);
            Controls.Add(cmbUserName);
            Controls.Add(txtOperationalModule);
            Controls.Add(txtUserName);
            Controls.Add(lblUserAuthority);
            Name = "frmUserAuthorization";
            Text = "frmUserAuthorization";
            Load += frmUserAuthorization_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUserAuthority;
        private Label txtUserName;
        private Label txtOperationalModule;
        private ComboBox cmbUserName;
        private ComboBox cmbOperationalModule;
        private Panel panel1;
        private CheckBox chkNew;
        private CheckBox chkView;
        private CheckBox chkPrint;
        private CheckBox chkDelete;
        private CheckBox chkEdit;
        private Button btnAdd;
        private Button btnRemove;
        private DataGridView dataGridView;
        private Button btnSave;
        private Button btnClear;
        private Button btnPrint;
        private Button btnClose;
        private Button btnNew;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn FormID;
        private DataGridViewTextBoxColumn PermissionID;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn ModuleName;
        private DataGridViewCheckBoxColumn Column2;
        private DataGridViewCheckBoxColumn Column3;
        private DataGridViewCheckBoxColumn Column4;
        private DataGridViewCheckBoxColumn Column5;
        private DataGridViewCheckBoxColumn Column6;
    }
}