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
            label1 = new Label();
            label2 = new Label();
            Cmb = new ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)dgvUserDetails).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(58, 14);
            label1.TabIndex = 0;
            label1.Text = "User ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 42);
            label2.Name = "label2";
            label2.Size = new Size(80, 14);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // Cmb
            // 
            Cmb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Cmb.FormattingEnabled = true;
            Cmb.Location = new Point(155, 9);
            Cmb.Name = "Cmb";
            Cmb.Size = new Size(319, 23);
            Cmb.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(155, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(319, 21);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 66);
            label3.Name = "label3";
            label3.Size = new Size(72, 14);
            label3.TabIndex = 4;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(155, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 21);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 96);
            label4.Name = "label4";
            label4.Size = new Size(128, 14);
            label4.TabIndex = 6;
            label4.Text = "Confirm Password";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(155, 92);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 21);
            textBox3.TabIndex = 7;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNew.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(12, 306);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 8;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(93, 306);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(174, 306);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(255, 306);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkActive.Location = new Point(411, 65);
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
            btnCancel.Location = new Point(399, 306);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // dgvUserDetails
            // 
            dgvUserDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUserDetails.BackgroundColor = SystemColors.AppWorkspace;
            dgvUserDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserDetails.GridColor = SystemColors.ControlDark;
            dgvUserDetails.Location = new Point(12, 119);
            dgvUserDetails.Name = "dgvUserDetails";
            dgvUserDetails.Size = new Size(462, 167);
            dgvUserDetails.TabIndex = 15;
            // 
            // frmUserCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 341);
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
            Controls.Add(Cmb);
            Controls.Add(label2);
            Controls.Add(label1);
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

        private Label label1;
        private Label label2;
        private ComboBox Cmb;
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
    }
}