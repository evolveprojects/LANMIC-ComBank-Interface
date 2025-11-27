namespace LANMIC_ComBank_Interface
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            combankToolStripMenuItem = new ToolStripMenuItem();
            userCreationToolStripMenuItem = new ToolStripMenuItem();
            userAuthorizationToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            panelBody = new Panel();
            lbTime = new Label();
            lbDate = new Label();
            pictureBox = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            settingToolStripMenuItem = new ToolStripMenuItem();
            databaseBackupToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.FromArgb(200, 154, 66);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, reportToolStripMenuItem, toolsToolStripMenuItem, settingToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1105, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { homeToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Image = (Image)resources.GetObject("homeToolStripMenuItem.Image");
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(180, 22);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(54, 20);
            reportToolStripMenuItem.Text = "&Report";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customizeToolStripMenuItem, combankToolStripMenuItem, userCreationToolStripMenuItem, userAuthorizationToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(47, 20);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.Image = (Image)resources.GetObject("customizeToolStripMenuItem.Image");
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size(172, 22);
            customizeToolStripMenuItem.Text = "Sage";
            // 
            // combankToolStripMenuItem
            // 
            combankToolStripMenuItem.Image = (Image)resources.GetObject("combankToolStripMenuItem.Image");
            combankToolStripMenuItem.Name = "combankToolStripMenuItem";
            combankToolStripMenuItem.Size = new Size(172, 22);
            combankToolStripMenuItem.Text = "Commercial Bank";
            // 
            // userCreationToolStripMenuItem
            // 
            userCreationToolStripMenuItem.Image = (Image)resources.GetObject("userCreationToolStripMenuItem.Image");
            userCreationToolStripMenuItem.Name = "userCreationToolStripMenuItem";
            userCreationToolStripMenuItem.Size = new Size(172, 22);
            userCreationToolStripMenuItem.Text = "User Creation";
            userCreationToolStripMenuItem.Click += userCreationToolStripMenuItem_Click;
            // 
            // userAuthorizationToolStripMenuItem
            // 
            userAuthorizationToolStripMenuItem.Image = (Image)resources.GetObject("userAuthorizationToolStripMenuItem.Image");
            userAuthorizationToolStripMenuItem.Name = "userAuthorizationToolStripMenuItem";
            userAuthorizationToolStripMenuItem.Size = new Size(172, 22);
            userAuthorizationToolStripMenuItem.Text = "User Authorization";
            userAuthorizationToolStripMenuItem.Click += userAuthorizationToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(116, 22);
            aboutToolStripMenuItem.Text = "&About...";
            // 
            // panelBody
            // 
            panelBody.Controls.Add(lbTime);
            panelBody.Controls.Add(lbDate);
            panelBody.Controls.Add(pictureBox);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 24);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1105, 592);
            panelBody.TabIndex = 1;
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.BackColor = Color.FromArgb(44, 168, 136);
            lbTime.Font = new Font("Bahnschrift", 20.25F, FontStyle.Bold);
            lbTime.Location = new Point(12, 555);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(72, 33);
            lbTime.TabIndex = 2;
            lbTime.Text = "Time";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.BackColor = Color.FromArgb(44, 168, 136);
            lbDate.Font = new Font("Bahnschrift", 20.25F, FontStyle.Bold);
            lbDate.Location = new Point(12, 522);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(70, 33);
            lbDate.TabIndex = 1;
            lbDate.Text = "Date";
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.FromArgb(44, 168, 136);
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1105, 592);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { databaseBackupToolStripMenuItem });
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(56, 20);
            settingToolStripMenuItem.Text = "&Setting";
            // 
            // databaseBackupToolStripMenuItem
            // 
            databaseBackupToolStripMenuItem.Image = (Image)resources.GetObject("databaseBackupToolStripMenuItem.Image");
            databaseBackupToolStripMenuItem.Name = "databaseBackupToolStripMenuItem";
            databaseBackupToolStripMenuItem.Size = new Size(180, 22);
            databaseBackupToolStripMenuItem.Text = "Database Backup";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 616);
            Controls.Add(panelBody);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(800, 500);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LANMIC ComBank Interface 1.0v";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Panel panelBody;
        private PictureBox pictureBox;
        private System.Windows.Forms.Timer timer;
        private Label lbTime;
        private Label lbDate;
        private ToolStripMenuItem combankToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem userCreationToolStripMenuItem;
        private ToolStripMenuItem userAuthorizationToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem databaseBackupToolStripMenuItem;
    }
}
