using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using LANMIC_ComBank_Interface.Config;
using LANMIC_ComBank_Interface.Data;
using LANMIC_ComBank_Interface.HelpServices;
using LANMIC_ComBank_Interface.Models.DatabaseModels;
using LANMIC_ComBank_Interface.Models.SessionModel;
using LANMIC_ComBank_Interface.Models.ViewModels;
using log4net;

namespace LANMIC_ComBank_Interface.Forms.Setting.CommercialBank
{
    public partial class frmComBankAPICredentials : Form
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly AppDbContext db;
        private readonly UserAuthorityViewModel authPermission;
        private bool isEditMode = false;

        public frmComBankAPICredentials()
        {
            InitializeComponent();
            ControlHelpers.AddHorizontalSeparator(this);
            db = new AppDbContext(AppConfigService.ConnectionString());
            authPermission = UserSession.UserPermissions.FirstOrDefault(x => x.FormName == this.Name);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var inputChanel = txtInputChanel.Text.Trim();
            var inputUser = txtInputUser.Text.Trim();
            var password = txtPassword.Text.Trim();
            var username = txtUsername.Text.Trim();
            var bankAccountNumber = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(inputChanel) || string.IsNullOrEmpty(inputUser) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(bankAccountNumber))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (isEditMode)
                {
                    var existingCredentials = db.ComBankAPICredentials.FirstOrDefault();
                    if (existingCredentials != null)
                    {
                        existingCredentials.InputChanel = DpapiHelper.Encrypt(inputChanel);
                        existingCredentials.InputUser = DpapiHelper.Encrypt(inputUser);
                        existingCredentials.Password = DpapiHelper.Encrypt(password);
                        existingCredentials.Username = DpapiHelper.Encrypt(username);
                        existingCredentials.OrgAccount = DpapiHelper.Encrypt(bankAccountNumber);
                        existingCredentials.UpdatedAt = DateTime.Now;
                        db.SaveChanges();
                        MessageBox.Show("Credentials updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCredentials();
                    }
                }
                else
                {
                    var newCredentials = new CombankAPICredentials
                    {
                        InputChanel = DpapiHelper.Encrypt(inputChanel),
                        InputUser = DpapiHelper.Encrypt(inputUser),
                        Password = DpapiHelper.Encrypt(password),
                        Username = DpapiHelper.Encrypt(username),
                        OrgAccount = DpapiHelper.Encrypt(bankAccountNumber),
                        UpdatedAt = DateTime.Now
                    };
                    db.ComBankAPICredentials.Add(newCredentials);
                    db.SaveChanges();
                    MessageBox.Show("Credentials saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCredentials();
                }
            }
            catch (Exception ex)
            {
                log.Error("Error saving ComBank API credentials", ex);
                MessageBox.Show("An error occurred while saving credentials. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCredentials()
        {
            ClearFields();
            try
            {
                var existingCredentials = db.ComBankAPICredentials.FirstOrDefault();
                if (existingCredentials != null)
                {
                    txtInputChanel.Text = DpapiHelper.Decrypt(existingCredentials.InputChanel);
                    txtInputUser.Text = DpapiHelper.Decrypt(existingCredentials.InputUser);
                    txtPassword.Text = DpapiHelper.Decrypt(existingCredentials.Password);
                    txtUsername.Text = DpapiHelper.Decrypt(existingCredentials.Username);
                    txtOrgAccount.Text = DpapiHelper.Decrypt(existingCredentials.OrgAccount);
                    isEditMode = false;
                }
                else
                {
                    txtInputChanel.Enabled = true;
                    txtInputUser.Enabled = true;
                    txtPassword.Enabled = true;
                    txtOrgAccount.Enabled = true;
                    txtUsername.Enabled = true;

                    isEditMode = false;
                }
            }
            catch (Exception ex)
            {
                log.Error("Error loading ComBank API credentials", ex);
                MessageBox.Show("An error occurred while loading credentials. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtInputChanel.Clear();
            txtInputUser.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
            txtOrgAccount.Clear();
            isEditMode = false;

            txtInputChanel.Enabled = false;
            txtInputUser.Enabled = false;
            txtPassword.Enabled = false;
            txtUsername.Enabled = false;
            txtOrgAccount.Enabled = false;
        }
        private void frmComBankAPICredentials_Load(object sender, EventArgs e)
        {
            LoadCredentials();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                MessageBox.Show("You are already in edit mode.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Do you want to edit these fields?", "Information", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                isEditMode = true;
                txtInputChanel.Enabled = true;
                txtInputUser.Enabled = true;
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
                txtOrgAccount.Enabled = true;
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadCredentials();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
