using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LANMIC_ComBank_Interface.Config;
using LANMIC_ComBank_Interface.Data;
using LANMIC_ComBank_Interface.HelpServices;
using LANMIC_ComBank_Interface.Models.DatabaseModels;
using LANMIC_ComBank_Interface.Models.SageModels;
using LANMIC_ComBank_Interface.Models.SessionModel;
using LANMIC_ComBank_Interface.Models.SystemModels;
using LANMIC_ComBank_Interface.Models.ViewModels;
using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LANMIC_ComBank_Interface.Forms.Tools.Sage
{
    public partial class frmVendors : Form
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        //private readonly SageAPICredentials _sageAPICredentials = new SageAPICredentials();
        private readonly AppDbContext db;
        private readonly UserAuthorityViewModel authPermission;
        private bool isEditMode = false;
        //private bool isNew= false;

        public frmVendors()
        {
            InitializeComponent();
            ControlHelpers.AddHorizontalSeparator(this);
            db = new AppDbContext(AppConfigService.ConnectionString());
            authPermission = UserSession.UserPermissions.FirstOrDefault(x => x.FormName == this.Name);

        }

        private async void btnSageVendors_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                MessageBox.Show("Finish editing the current entry before editing another.", "Edit In Progress", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GetVendorsAsync();
            setCurrencyCode();
        }

        public async void GetVendorsAsync()
        {
            btnSageVendors.Enabled = false;
            btnRefesh.Enabled = false;
            try
            {

                loadVendors();
                progressBar.Value = 0;
                var apiEndPoint = "APVendors";
                var result = await SageApiClient.GetListAsync(apiEndPoint);
                if (!string.IsNullOrEmpty(result))
                {
                    List<SageVendorAPIModel> vendor = JsonConvert.DeserializeObject<List<SageVendorAPIModel>>(result);
                    if (vendor.Count > 0)
                    {
                        //dataGridView.Rows.Clear();
                        progressBar.Minimum = 0;
                        progressBar.Maximum = vendor.Count;

                        List<SageVendor> vendorList = new List<SageVendor>();

                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            vendorList.Add(new SageVendor
                            {
                                VendorNumber = row.Cells["VendorNumber"].Value?.ToString(),
                                VendorName = row.Cells["VendorName"].Value?.ToString(),
                                BankName = "", //row.Cells["BankName"].Value?.ToString(),
                                BankAccountNo = "",
                                SWIFT_Code = "", // row.Cells["SWIFTCode"]?.Value.ToString(),
                                CurrencyCode = "",
                                Email = "", //row.Cells["Email"].Value?.ToString(),
                                AddressLine1 = "",
                                AddressLine2 = "",
                                AddressLine3 = "",
                                IsActive = row.Cells["IsActive"].Value?.ToString() == "Yes" ? true : false
                            });
                        }

                        foreach (var v in vendor)
                        {
                            bool isExist = vendorList.Any(x => x.VendorNumber == v.VendorNumber);
                            string isActive = v.Status == "Active" ? "Yes" : "No";
                            if (!isExist)
                            {
                                var rowIndex = dataGridView.Rows.Add(v.VendorNumber, v.VendorName, "", "", "", "", "","", "", "", isActive);
                                DataGridViewRow addedRow = dataGridView.Rows[rowIndex];
                                addedRow.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                                addedRow.DefaultCellStyle.ForeColor = Color.Black;
                            }
                            progressBar.Value += 1;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                var errorMessage = "An error occurred while retrieving vendors: " + ex.Message;
            }
            btnSageVendors.Enabled = true;
            btnRefesh.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                MessageBox.Show("Finish editing the current entry before editing another.", "Edit In Progress", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (isEditMode)
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        int savedCount = 0;
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            // Skip empty/new rows
                            if (row.IsNewRow) continue;

                            var vendor = new SageVendor
                            {
                                VendorNumber = row.Cells["VendorNumber"].Value?.ToString(),
                                VendorName = row.Cells["VendorName"].Value?.ToString(),
                                BankName = row.Cells["BankName"].Value?.ToString(),
                                BankAccountNo = row.Cells["BankAccountNo"].Value?.ToString(),
                                SWIFT_Code = row.Cells["SWIFTCode"]?.Value.ToString(),
                                CurrencyCode = row.Cells["CurrencyCode"]?.Value.ToString(),
                                Email = row.Cells["Email"].Value?.ToString(),
                                IsActive = row.Cells["IsActive"].Value?.ToString() == "Yes" ? true : false
                            };

                            if (!string.IsNullOrWhiteSpace(vendor.BankName) &&
                                !string.IsNullOrWhiteSpace(vendor.SWIFT_Code) &&
                                !string.IsNullOrWhiteSpace(vendor.Email) &&
                                !string.IsNullOrWhiteSpace(vendor.CurrencyCode))
                            {
                                var existingVendor = db.SageVendors.FirstOrDefault(v => v.VendorNumber == vendor.VendorNumber);

                                if (existingVendor != null)
                                {
                                    existingVendor.VendorName = vendor.VendorName;
                                    existingVendor.VendorNumber = vendor.VendorNumber;
                                    existingVendor.BankName = vendor.BankName;
                                    existingVendor.BankAccountNo = vendor.BankAccountNo;
                                    existingVendor.SWIFT_Code = vendor.SWIFT_Code;
                                    existingVendor.CurrencyCode = vendor.CurrencyCode;
                                    existingVendor.Email = vendor.Email;
                                    existingVendor.IsActive = vendor.IsActive;
                                }
                                else
                                {
                                    db.SageVendors.Add(vendor);
                                }
                                db.SaveChanges();
                                savedCount++;
                            }
                        }

                        if (savedCount > 0)
                        {
                            tran.Commit();
                            MessageBox.Show("Vendors saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadVendors();
                        }
                        else
                        {
                            tran.Dispose();
                        }

                    }
                    catch (Exception ex)
                    {
                        log.Error(ex.Message, ex.InnerException);
                        tran.Rollback();
                    }
                }
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (isEditMode)
            {
                MessageBox.Show("Finish editing the current entry before editing another.", "Edit In Progress", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Do you want to edit this entry?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int rowId = e.RowIndex;
                if (rowId > -1)
                {
                    var row = dataGridView.Rows[rowId];

                    var vendorNumber = row.Cells["VendorNumber"].Value.ToString();
                    var vendorName = row.Cells["VendorName"].Value.ToString();
                    var bankName = row.Cells["BankName"].Value.ToString();
                    var bankAccountNo = row.Cells["BankAccountNo"].Value.ToString();
                    var swiftCode = row.Cells["SWIFTCode"].Value.ToString();
                    var currencyCode = row.Cells["CurrencyCode"].Value.ToString();
                    var email = row.Cells["Email"].Value.ToString();
                    var isActive = row.Cells["IsActive"].Value.ToString();
                    var addressLine1 = row.Cells["AddressLine1"].Value?.ToString() ?? "";
                    var addressLine2 = row.Cells["AddressLine2"].Value?.ToString() ?? "";
                    var addressLine3 = row.Cells["AddressLine3"].Value?.ToString() ?? "";

                    txtVendorNumber.Text = vendorNumber;
                    txtVendorName.Text = vendorName;
                    txtBankName.Text = bankName;
                    txtBankAccountNo.Text = bankAccountNo;
                    txtSWIFTCode.Text = swiftCode;
                    txtEmail.Text = email;
                    txtAddressLine1.Text = addressLine1;
                    txtAddressLine2.Text = addressLine2;
                    txtAddressLine3.Text = addressLine3;

                    if (!string.IsNullOrEmpty(currencyCode))
                    {
                        cmbCurrencyCode.SelectedValue = currencyCode;
                    }
                    else
                    {
                        cmbCurrencyCode.SelectedIndex = -1;
                    }


                    if (isActive == "Yes")
                    {
                        chkIsActive.Checked = true;
                    }
                    else
                    {
                        chkIsActive.Checked = true;
                    }

                    dataGridView.Rows.RemoveAt(rowId);
                    isEditMode = true;
                    txtEmail.Focus();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string vendorNumber = txtVendorNumber.Text;
            string vendorName = txtVendorName.Text;
            string bankName = txtBankName.Text;
            string bankAccountNo = txtBankAccountNo.Text;
            string swiftCode = txtSWIFTCode.Text;
            string currencyCode = cmbCurrencyCode.SelectedValue?.ToString() ?? "";
            string email = txtEmail.Text;
            string status = chkIsActive.Checked ? "Yes" : "No";
            string addressLine1 = txtAddressLine1.Text;
            string addressLine2 = txtAddressLine2.Text;
            string addressLine3 = txtAddressLine3.Text;


            if (string.IsNullOrWhiteSpace(vendorNumber)     ||
                string.IsNullOrWhiteSpace(vendorName)       ||
                string.IsNullOrWhiteSpace(bankName)         ||
                string.IsNullOrWhiteSpace(bankAccountNo)    ||
                string.IsNullOrWhiteSpace(swiftCode)        ||
                string.IsNullOrWhiteSpace(currencyCode)     ||
                string.IsNullOrWhiteSpace(email)            ||                
                string.IsNullOrWhiteSpace(addressLine1)     || 
                string.IsNullOrWhiteSpace(addressLine2)     || 
                string.IsNullOrWhiteSpace(addressLine3))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells[0].Value != null && 
                    dataGridView.Rows[i].Cells[0].Value.ToString() == vendorNumber)
                {
                    MessageBox.Show("Vendor Number already exists in the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Add row and get its index
            dataGridView.Rows.Insert(0, vendorNumber, 
                                        vendorName, 
                                        bankName, 
                                        bankAccountNo, 
                                        swiftCode,
                                        currencyCode,
                                        email, 
                                        addressLine1, 
                                        addressLine2, 
                                        addressLine3, 
                                        status);

            // Highlight the newly added row
            DataGridViewRow addedRow = dataGridView.Rows[0];
            addedRow.DefaultCellStyle.BackColor = Color.LightGreen;
            addedRow.DefaultCellStyle.ForeColor = Color.Black;

            // Optional: auto-select the new row
            dataGridView.ClearSelection();
            addedRow.Selected = true;

            ClearFields();
        }
        private void ClearFields()
        {
            txtVendorNumber.Clear();
            txtVendorName.Clear();
            txtBankName.Clear();
            txtSWIFTCode.Clear();
            cmbCurrencyCode.SelectedIndex = -1;
            txtEmail.Clear();
            txtBankAccountNo.Clear();
            isEditMode = false;
            chkIsActive.Checked = false;
        }
        private void frmVendors_Load(object sender, EventArgs e)
        {
            loadVendors();
        }

        private void loadVendors()
        {
            btnSageVendors.Enabled = false;
            dataGridView.Rows.Clear();
            setCurrencyCode();
            ClearFields();
            var ven = db.SageVendors.ToList();
            if (ven.Count > 0)
            {
                foreach (var v in ven)
                {
                    dataGridView.Rows.Add(v.VendorNumber, 
                                          v.VendorName, 
                                          v.BankName, 
                                          v.BankAccountNo, 
                                          v.SWIFT_Code,
                                          v.CurrencyCode, 
                                          v.Email,
                                          v.AddressLine1,
                                          v.AddressLine2,
                                          v.AddressLine3,
                                          v.IsActive ? "Yes" : "No"
                                          );
                }
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            loadVendors();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setCurrencyCode()
        {
            var priorityCurrencies = new List<string> { "LKR", "USD" };

            var currencies = CultureInfo
                .GetCultures(CultureTypes.SpecificCultures)
                .Where(c => !c.IsNeutralCulture)
                .Select(c =>
                {
                    try
                    {
                        return new RegionInfo(c.Name);
                    }
                    catch
                    {
                        return null;
                    }
                })
                .Where(r => r != null)
                .GroupBy(r => r.ISOCurrencySymbol)
                .Select(g => g.First())
                .Where(r =>
                    !string.IsNullOrWhiteSpace(r.ISOCurrencySymbol) &&
                    r.ISOCurrencySymbol != "XXX" &&       // remove unknown currency
                    r.ISOCurrencySymbol != "¤¤")          // remove invalid placeholder
                .Select(r => new
                {
                    Code = r.ISOCurrencySymbol,
                    Display = $"{r.ISOCurrencySymbol} - {r.CurrencyEnglishName}"
                })
                .OrderBy(x => priorityCurrencies.Contains(x.Code)
                                ? priorityCurrencies.IndexOf(x.Code)
                                : int.MaxValue)
                .ThenBy(x => x.Code)
                .ToList();

            cmbCurrencyCode.DataSource = currencies;
            cmbCurrencyCode.DisplayMember = "Display";
            cmbCurrencyCode.ValueMember = "Code";
            cmbCurrencyCode.SelectedIndex = -1;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //isNew = true;
            btnSageVendors.Enabled = true;
        }
    }
}
