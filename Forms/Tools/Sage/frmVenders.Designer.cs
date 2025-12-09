namespace LANMIC_ComBank_Interface.Forms.Tools.Sage
{
    partial class frmVenders
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
            lblVenders = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            dataGridView = new DataGridView();
            VenderNumber = new DataGridViewTextBoxColumn();
            VenderName = new DataGridViewTextBoxColumn();
            BankName = new DataGridViewTextBoxColumn();
            SWIFTCode = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            btnCancel = new Button();
            btnSave = new Button();
            btnSageVenders = new Button();
            btnSearch = new Button();
            textBox6 = new TextBox();
            label6 = new Label();
            btnRefesh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // lblVenders
            // 
            lblVenders.AutoSize = true;
            lblVenders.Dock = DockStyle.Top;
            lblVenders.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVenders.Location = new Point(0, 0);
            lblVenders.Name = "lblVenders";
            lblVenders.Size = new Size(107, 30);
            lblVenders.TabIndex = 8;
            lblVenders.Text = "VENDERS";
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
            // textBox1
            // 
            textBox1.Location = new Point(106, 43);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(250, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(106, 72);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(560, 23);
            textBox2.TabIndex = 12;
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
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(106, 101);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(682, 23);
            textBox3.TabIndex = 14;
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
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(106, 130);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(682, 23);
            textBox4.TabIndex = 16;
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
            // textBox5
            // 
            textBox5.Location = new Point(106, 158);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 23);
            textBox5.TabIndex = 18;
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
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { VenderNumber, VenderName, BankName, SWIFTCode, Email });
            dataGridView.Location = new Point(12, 188);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(776, 216);
            dataGridView.TabIndex = 19;
            // 
            // VenderNumber
            // 
            VenderNumber.HeaderText = "Vender Number";
            VenderNumber.Name = "VenderNumber";
            VenderNumber.ReadOnly = true;
            VenderNumber.Width = 150;
            // 
            // VenderName
            // 
            VenderName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VenderName.HeaderText = "Vender Name";
            VenderName.Name = "VenderName";
            VenderName.ReadOnly = true;
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
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(713, 415);
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
            btnSave.Location = new Point(551, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnSageVenders
            // 
            btnSageVenders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSageVenders.BackColor = Color.FromArgb(0, 128, 97);
            btnSageVenders.Cursor = Cursors.Hand;
            btnSageVenders.FlatStyle = FlatStyle.Flat;
            btnSageVenders.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSageVenders.ForeColor = Color.FromArgb(226, 228, 213);
            btnSageVenders.Location = new Point(672, 48);
            btnSageVenders.Name = "btnSageVenders";
            btnSageVenders.Size = new Size(116, 47);
            btnSageVenders.TabIndex = 25;
            btnSageVenders.Text = "  Sage \r\nVenders";
            btnSageVenders.UseVisualStyleBackColor = false;
            btnSageVenders.Click += btnSageVenders_Click;
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
            btnRefesh.Location = new Point(632, 415);
            btnRefesh.Name = "btnRefesh";
            btnRefesh.Size = new Size(75, 23);
            btnRefesh.TabIndex = 23;
            btnRefesh.Text = "Refresh";
            btnRefesh.UseVisualStyleBackColor = true;
            // 
            // frmVenders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(btnSearch);
            Controls.Add(btnSageVenders);
            Controls.Add(btnCancel);
            Controls.Add(btnRefesh);
            Controls.Add(btnSave);
            Controls.Add(dataGridView);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(lblVenders);
            Name = "frmVenders";
            Text = "frmVenders";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVenders;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private DataGridView dataGridView;
        private Button btnCancel;
        private Button btnSave;
        private Button btnEdit;
        private Button btnSageVenders;
        private Button btnSearch;
        private TextBox textBox6;
        private Label label6;
        private DataGridViewTextBoxColumn VenderNumber;
        private DataGridViewTextBoxColumn VenderName;
        private DataGridViewTextBoxColumn BankName;
        private DataGridViewTextBoxColumn SWIFTCode;
        private DataGridViewTextBoxColumn Email;
        private Button btnRefesh;
    }
}