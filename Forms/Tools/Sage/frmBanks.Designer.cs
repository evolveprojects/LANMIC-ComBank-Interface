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
            lblBanks = new Label();
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
            // frmBanks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBanks);
            Name = "frmBanks";
            Text = "frmBanks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBanks;
    }
}