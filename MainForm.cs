using LANMIC_ComBank_Interface.Forms.Tools;
using LANMIC_ComBank_Interface.Forms.Tools.Sage;
using LANMIC_ComBank_Interface.Forms.Tools.UserAuthorization;

namespace LANMIC_ComBank_Interface
{
    public partial class MainForm : Form
    {
        private Form activeForm = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToLongDateString();
            timer.Start();
            
           // vendersToolStripMenuItem.Visible = false;  // hide Venders menu item
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void userCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUserCreation());
        }

        private void userAuthorizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUserAuthorization());
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
        }

        private void vendersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmVenders());
        }

        private void banksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmBanks());
        }
    }
}
