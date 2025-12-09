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
            lblUserAuthority = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewCheckBoxColumn();
            Column3 = new DataGridViewCheckBoxColumn();
            Column4 = new DataGridViewCheckBoxColumn();
            Column5 = new DataGridViewCheckBoxColumn();
            Column6 = new DataGridViewCheckBoxColumn();
            btnSave = new Button();
            btnClear = new Button();
            btnPrint = new Button();
            btnClose = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
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
            cmbUserName.FormattingEnabled = true;
            cmbUserName.Location = new Point(173, 45);
            cmbUserName.Name = "cmbUserName";
            cmbUserName.Size = new Size(615, 23);
            cmbUserName.TabIndex = 10;
            // 
            // cmbOperationalModule
            // 
            cmbOperationalModule.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbOperationalModule.FormattingEnabled = true;
            cmbOperationalModule.Location = new Point(173, 74);
            cmbOperationalModule.Name = "cmbOperationalModule";
            cmbOperationalModule.Size = new Size(615, 23);
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
            chkPrint.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkPrint.Location = new Point(287, 7);
            chkPrint.Name = "chkPrint";
            chkPrint.Size = new Size(58, 18);
            chkPrint.TabIndex = 4;
            chkPrint.Text = "Print";
            chkPrint.UseVisualStyleBackColor = true;
            // 
            // chkDelete
            // 
            chkDelete.AutoSize = true;
            chkDelete.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkDelete.Location = new Point(212, 7);
            chkDelete.Name = "chkDelete";
            chkDelete.Size = new Size(69, 18);
            chkDelete.TabIndex = 3;
            chkDelete.Text = "Delete";
            chkDelete.UseVisualStyleBackColor = true;
            // 
            // chkEdit
            // 
            chkEdit.AutoSize = true;
            chkEdit.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEdit.Location = new Point(155, 7);
            chkEdit.Name = "chkEdit";
            chkEdit.Size = new Size(51, 18);
            chkEdit.TabIndex = 2;
            chkEdit.Text = "Edit";
            chkEdit.UseVisualStyleBackColor = true;
            // 
            // chkNew
            // 
            chkNew.AutoSize = true;
            chkNew.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkNew.Location = new Point(93, 7);
            chkNew.Name = "chkNew";
            chkNew.Size = new Size(56, 18);
            chkNew.TabIndex = 1;
            chkNew.Text = "New";
            chkNew.UseVisualStyleBackColor = true;
            // 
            // chkView
            // 
            chkView.AutoSize = true;
            chkView.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkView.Location = new Point(28, 7);
            chkView.Name = "chkView";
            chkView.Size = new Size(59, 18);
            chkView.TabIndex = 0;
            chkView.Text = "View";
            chkView.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemove.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(525, 5);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 14;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(444, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(12, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(776, 433);
            dataGridView1.TabIndex = 15;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Module Name";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
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
            btnSave.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(470, 581);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(551, 581);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrint.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(632, 581);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 18;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(713, 581);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 19;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // frmUserAuthorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 616);
            Controls.Add(btnClose);
            Controls.Add(btnPrint);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(cmbOperationalModule);
            Controls.Add(cmbUserName);
            Controls.Add(txtOperationalModule);
            Controls.Add(txtUserName);
            Controls.Add(lblUserAuthority);
            Name = "frmUserAuthorization";
            Text = "frmUserAuthorization";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUserAuthority;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
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
        private DataGridView dataGridView1;
        private Button btnSave;
        private Button btnClear;
        private Button btnPrint;
        private Button btnClose;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewCheckBoxColumn Column2;
        private DataGridViewCheckBoxColumn Column3;
        private DataGridViewCheckBoxColumn Column4;
        private DataGridViewCheckBoxColumn Column5;
        private DataGridViewCheckBoxColumn Column6;
    }
}