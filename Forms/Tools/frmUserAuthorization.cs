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

namespace LANMIC_ComBank_Interface.Forms.Tools.UserAuthorization
{
    public partial class frmUserAuthorization : Form
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly AppDbContext db;
        private readonly UserAuthorityViewModel authPermission;

        public frmUserAuthorization()
        {
            InitializeComponent();
            ControlHelpers.AddHorizontalSeparator(this);
            db = new AppDbContext(AppConfigService.ConnectionString());
            authPermission = UserSession.UserPermissions.FirstOrDefault(x => x.FormName == this.Name);       
        }

        private void chkNew_CheckedChanged(object sender, EventArgs e)
        {
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    UserAuthority userAuthority = new UserAuthority
                    {
                        UserID = (int)cmbUserName.SelectedValue,
                        FormID = cmbOperationalModule.SelectedValue.ToString(),
                        PermissionID = PermissionUtilities.Encode(
                                   chkView.Checked,
                                   chkNew.Checked,
                                   chkEdit.Checked,
                                   chkDelete.Checked,
                                   chkPrint.Checked
                               ),
                        CreatedAt = DateTime.Now
                    };

                    db.UserAuthorities.Add(userAuthority);
                    db.SaveChanges();

                    tran.Commit();
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message, ex.InnerException);
                    tran.Rollback();
                }

                // Logic handled in CheckBoxGroupHandler
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var view = chkView.Checked;
            var create = chkNew.Checked;
            var edit = chkEdit.Checked;
            var delete = chkDelete.Checked;
            var print = chkPrint.Checked;

            if (view)
            {
                var userId = (int)cmbUserName.SelectedValue;
                var form = (KeyValuePair<string, string>)cmbOperationalModule.SelectedItem;
                var formId = form.Key;
                var userName = cmbUserName.Text;
                var formName = form.Value;
                int encodedPermissions = PermissionUtilities.Encode(view, create, edit, delete, print);
                bool itemExists = false;
                //MessageBox.Show($"Encoded Permissions: {encodedPermissions}");
                //var sds = PermissionUtilities.Decode(encodedPermissions);

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if ((int)row.Cells["UserID"].Value == userId && row.Cells["FormID"].Value.ToString() == formId)
                    {
                        MessageBox.Show("This user already has permissions set for the selected module.");
                        itemExists = true;
                        return;
                    }
                }

                if (!itemExists)
                {
                    dataGridView.Rows.Add(userId, formId, encodedPermissions, userName, formName, view, create, edit, delete, print);
                }

                LoadOperationalModules();
                chkView.Checked = false;
                chkNew.Checked = false;
                chkEdit.Checked = false;
                chkDelete.Checked = false;
                chkPrint.Checked = false;
                //chkView.Enabled = false;
                //chkNew.Enabled = false;
                //chkEdit.Enabled = false;
                //chkDelete.Enabled = false;
                //chkPrint.Enabled = false;
                //btnAdd.Enabled = false;
                btnRemove.Enabled = false;
                btnSave.Enabled = true;

            }
            else
            {
                MessageBox.Show("At least 'View' permission must be granted to add the module.");
            }
        }

        private void frmUserAuthorization_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadOperationalModules();
        }

        private void LoadUsers()
        {
            var userDetails = (from ud in db.UserDetails
                               where ud.IsActive == true
                               select new KeyValuePair<int, string>(
                                ud.ID,
                                ud.Username
                               )).ToList();

            if (userDetails.Count > 0)
            {
                cmbUserName.DataSource = userDetails;
                cmbUserName.DisplayMember = "Value";
                cmbUserName.ValueMember = "Key";
            }
        }

        private void LoadOperationalModules()
        {
            var operationalModules = (from om in db.FormDetails
                                      select new KeyValuePair<string, string>(
                                          om.FormID,
                                          om.FormDescription
                                      )).ToList();
            //if (operationalModules.Count > 0)
            //{
            //    cmbOperationalModule.DataSource = operationalModules;
            //    cmbOperationalModule.DisplayMember = "Value";
            //    cmbOperationalModule.ValueMember = "Key";
            //}

            // 1. Load all modules from database
            //var operationalModules = db.FormDetails
            //    .Select(f => new FormDetails
            //    {
            //        FormID = f.FormID,
            //        FormDescription = f.FormDescription
            //    })
            //    .ToList();

            // 2. Get existing FormIDs from DataGridView
            var existingIds = new List<string>();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    string formID = row.Cells["FormID"].Value.ToString();
                    existingIds.Add(formID);
                }
            }

            // 3. Filter out used items
            operationalModules = operationalModules
                .Where(m => !existingIds.Contains(m.Key))
                .ToList();

            // 4. Bind ComboBox
            cmbOperationalModule.DataSource = null;
            cmbOperationalModule.DataSource = operationalModules;
            cmbOperationalModule.DisplayMember = "Value";
            cmbOperationalModule.ValueMember = "Key";
        }

        bool _isInternalChange = false;
        private void CheckedChanged(object sender, EventArgs e)
        {
            if (_isInternalChange) return;
            if (chkNew.Checked || chkEdit.Checked || chkDelete.Checked || chkPrint.Checked)
            {
                _isInternalChange = true;
                chkView.Checked = true;
                _isInternalChange = false;
            }
        }

        private void chkView_CheckedChanged(object sender, EventArgs e)
        {
            if (_isInternalChange) return;
            if (!chkView.Checked)
            {
                _isInternalChange = true;
                chkNew.Checked = false;
                chkEdit.Checked = false;
                chkDelete.Checked = false;
                chkPrint.Checked = false;
                _isInternalChange = false;
            }
        }

        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var user = (KeyValuePair<int, string>)cmbUserName.SelectedItem;
            List<UserAuthority> authorities = db.UserAuthorities.Where(ua => ua.UserID == user.Key).ToList();
            if (authorities.Count > 0)
            {
                dataGridView.Rows.Clear();
                foreach (var authority in authorities)
                {
                    var formDetails = db.FormDetails.FirstOrDefault(fd => fd.FormID == authority.FormID);
                    var formName = formDetails != null ? formDetails.FormDescription : "Unknown";
                    var permissions = PermissionUtilities.Decode(authority.PermissionID);
                    dataGridView.Rows.Add(
                        authority.UserID,
                        authority.FormID,
                        authority.PermissionID,
                        cmbUserName.Text,
                        formName,
                        permissions.View,
                        permissions.New,
                        permissions.Edit,
                        permissions.Delete,
                        permissions.Print
                    );

                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (authPermission.Edit == false)
            {
                MessageBox.Show("You do not have permission to grant user authorizations.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView.Rows.Count > 0)
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        var userId = (int)cmbUserName.SelectedValue;
                        // Remove existing authorities for the user
                        var existingAuthorities = db.UserAuthorities.Where(ua => ua.UserID == userId).ToList();
                        db.UserAuthorities.RemoveRange(existingAuthorities);
                        db.SaveChanges();

                        // Add new authorities from the DataGridView
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            UserAuthority userAuthority = new UserAuthority
                            {
                                UserID = (int)row.Cells["UserID"].Value,
                                FormID = row.Cells["FormID"].Value.ToString(),
                                PermissionID = (int)row.Cells["PermissionID"].Value,
                                CreatedAt = DateTime.Now
                            };
                            db.UserAuthorities.Add(userAuthority);
                        }
                        db.SaveChanges();
                        tran.Commit();
                        MessageBox.Show("User authorizations saved successfully.","Information");
                        ClearForm();
                    }
                    catch (Exception ex)
                    {
                        log.Error(ex.Message, ex.InnerException);
                        tran.Rollback();
                        MessageBox.Show("An error occurred while saving user authorizations.","Error");
                    }
                }
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (authPermission.Edit == false)
            {
                MessageBox.Show("You do not have permission to edit user authorizations.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Do you want to edit this entry?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int rowId = e.RowIndex;
                if (rowId > -1)
                {
                    var row = dataGridView.Rows[rowId];
                    var userId = (int)row.Cells["UserID"].Value;
                    var formId = row.Cells["FormID"].Value.ToString();
                    var userName = row.Cells["UserName"].Value.ToString();
                    var formDescription = row.Cells["ModuleName"].Value.ToString();
                    var encodedPermissions = (int)row.Cells["PermissionID"].Value;
                    var permissions = PermissionUtilities.Decode(encodedPermissions);
                    bool view = permissions.View;
                    bool create = permissions.New;
                    bool edit = permissions.Edit;
                    bool delete = permissions.Delete;
                    bool print = permissions.Print;


                    chkView.Checked = view;
                    chkNew.Checked = create;
                    chkEdit.Checked = edit;
                    chkDelete.Checked = delete;
                    chkPrint.Checked = print;
                    //cmbUserName.SelectedValue = userId;
                    //cmbOperationalModule.SelectedValue = formId;
                    cmbOperationalModule.DataSource = null;
                    cmbOperationalModule.Items.Clear();
                    cmbOperationalModule.Items.Add(new KeyValuePair<string, string>(formId, formDescription));
                    cmbOperationalModule.DisplayMember = "Value";
                    cmbOperationalModule.ValueMember = "Key";
                    cmbOperationalModule.SelectedIndex = 0;
                    cmbOperationalModule.Enabled = false;
                    // LoadOperationalModules();
                    dataGridView.Rows.RemoveAt(rowId);

                    chkView.Enabled = true;
                    chkNew.Enabled = true;
                    chkEdit.Enabled = true;
                    chkDelete.Enabled = true;
                    chkPrint.Enabled = true;
                    btnAdd.Enabled = true;
                    btnRemove.Enabled = true;
                    btnSave.Enabled = false;
                    btnNew.Enabled = false;
                }
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (authPermission.New == false)
            {
                MessageBox.Show("You do not have permission to create new user authorizations.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadOperationalModules();
            cmbOperationalModule.Enabled = true;
            chkView.Checked = false;
            chkNew.Checked = false;
            chkEdit.Checked = false;
            chkDelete.Checked = false;
            chkPrint.Checked = false;

            chkView.Enabled = true;
            chkNew.Enabled = true;
            chkEdit.Enabled = true;
            chkDelete.Enabled = true;
            chkPrint.Enabled = true;

            btnAdd.Enabled = true;
        }

        private void ClearForm()
        {
            //dataGridView.Rows.Clear();
            LoadOperationalModules();
            cmbOperationalModule.Enabled = false;
            chkView.Checked = false;
            chkNew.Checked = false;
            chkEdit.Checked = false;
            chkDelete.Checked = false;
            chkPrint.Checked = false;

            chkView.Enabled = false;
            chkNew.Enabled = false;
            chkEdit.Enabled = false;
            chkDelete.Enabled = false;
            chkPrint.Enabled = false;
            btnAdd.Enabled = false;
            btnRemove.Enabled = false;
            btnSave.Enabled = false;
            //btnPrint.Enabled = false;
            btnNew.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbUserName_SelectedIndexChanged(sender, e);
            ClearForm();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(authPermission.Delete == false)
            {
                MessageBox.Show("You do not have permission to delete user authorizations.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClearForm();
            btnSave.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }
}
