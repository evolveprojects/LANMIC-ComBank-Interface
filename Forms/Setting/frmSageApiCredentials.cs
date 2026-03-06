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
using LANMIC_ComBank_Interface.Config;
using LANMIC_ComBank_Interface.Data;
using LANMIC_ComBank_Interface.HelpServices;
using LANMIC_ComBank_Interface.Models.DatabaseModels;
using LANMIC_ComBank_Interface.Models.SessionModel;
using LANMIC_ComBank_Interface.Models.ViewModels;
using log4net;
using Newtonsoft.Json;

namespace LANMIC_ComBank_Interface.Forms.Setting.Sage
{
    public partial class frmSageApiCredentials : Form
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly AppDbContext db;
        private readonly UserAuthorityViewModel authPermission;
        private bool isEditMode = false;

        public frmSageApiCredentials()
        {
            InitializeComponent();
            ControlHelpers.AddHorizontalSeparator(this);
            db = new AppDbContext(AppConfigService.ConnectionString());
            authPermission = UserSession.UserPermissions.FirstOrDefault(x => x.FormName == this.Name);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var domain = txtDomain.Text.Trim();
            var apiVersion = txtApiVersion.Text.Trim();
            var tenant = txtTenant.Text.Trim();
            var company = txtCompany.Text.Trim();
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(company) ||
                string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(domain) ||
                string.IsNullOrEmpty(apiVersion) ||
                string.IsNullOrEmpty(tenant)
               )
            {
                MessageBox.Show("Please fill in all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    // Save the credentials logic here
                    SageAPICredentials aPICredentials = new SageAPICredentials
                    {
                        Company = company,
                        Domain = domain,
                        Username = username,
                        Password = password,
                        ApiVersion = apiVersion,
                        Tenant = tenant
                    };

                    if (isEditMode)
                    {
                        var existingCredentials = db.SageAPICredentials.FirstOrDefault();
                        if (existingCredentials != null)
                        {
                            existingCredentials.Company = aPICredentials.Company;
                            existingCredentials.Domain = aPICredentials.Domain;
                            existingCredentials.Username = aPICredentials.Username;
                            existingCredentials.Password = aPICredentials.Password;
                            existingCredentials.ApiVersion = aPICredentials.ApiVersion;
                            existingCredentials.Tenant = aPICredentials.Tenant;
                            db.SaveChanges();
                            tran.Commit();
                            MessageBox.Show("Sage API Credentials updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        db.SageAPICredentials.Add(aPICredentials);
                        db.SaveChanges();
                        tran.Commit();
                        MessageBox.Show("Sage API Credentials saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadData();
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message, ex.InnerException);
                    tran.Rollback();
                }
            }
            //var settings = new
            //{
            //    Username = DpapiHelper.Encrypt(username),
            //    Password = DpapiHelper.Encrypt(password),
            //    Domain = DpapiHelper.Encrypt(domain),
            //    ApiVersion = DpapiHelper.Encrypt(apiVersion),
            //    Tenant = DpapiHelper.Encrypt(tenant),
            //    Company = DpapiHelper.Encrypt(company)
            //};

            //string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            //if (File.Exists("apisettings.json"))
            //{
            //    File.Delete("apisettings.json");
            //}

            //File.WriteAllText("apisettings.json", json);
            //MessageBox.Show("Settings saved (encrypted)!");

            //MessageBox.Show("Sage API Credentials saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void LoadData()
        {
            ClearFields();
            SageAPICredentials crd = db.SageAPICredentials.FirstOrDefault();
            if (crd != null)
            {
                txtCompany.Text = crd.Company;
                txtDomain.Text = crd.Domain;
                txtUsername.Text = crd.Username;
                txtPassword.Text = crd.Password;
                txtApiVersion.Text = crd.ApiVersion;
                txtTenant.Text = crd.Tenant;
                isEditMode = false;
            }
        }

        private void ClearFields()
        {
            txtCompany.Clear();
            txtDomain.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtApiVersion.Clear();
            txtTenant.Clear();
            isEditMode = false;

            txtCompany.Enabled = false;
            txtDomain.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            txtApiVersion.Enabled = false;
            txtTenant.Enabled = false;

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
                txtCompany.Enabled = true;
                txtDomain.Enabled = true;
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
                txtApiVersion.Enabled = true;
                txtTenant.Enabled = true;
              
            }
            //else if (dialogResult == DialogResult.No)
            //{
            //    //do something else
            //}
        }

        private void frmSageApiCredentials_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
