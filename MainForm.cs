using System.Windows.Forms;
using LANMIC_ComBank_Interface.Forms.Tools;
using LANMIC_ComBank_Interface.Forms.Tools.Sage;
using LANMIC_ComBank_Interface.Forms.Tools.UserAuthorization;
using LANMIC_ComBank_Interface.Models.SessionModel;
using LANMIC_ComBank_Interface.Models.ViewModels;

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

            // vendorsToolStripMenuItem.Visible = false;  // hide Vendors menu item
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

            //UserAuthorityViewModel userAuthorities = UserSession.UserPermissions.FirstOrDefault(x => x.FormName == childForm.Name);
            //bool canView = userAuthorities != null ? userAuthorities.View : false;
            //if (canView)
            //{
            var fn = childForm.Name;

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //}
            //else
            //{
            //    MessageBox.Show("You do not have permission to view this", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
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

        private void vendorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmVendors());
        }

        private void banksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmBanks());
        }

        private void APPostedPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
