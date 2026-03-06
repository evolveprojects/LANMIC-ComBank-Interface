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
using LANMIC_ComBank_Interface.Enums;
using LANMIC_ComBank_Interface.HelpServices;
using LANMIC_ComBank_Interface.Models.DatabaseModels;
using LANMIC_ComBank_Interface.Models.SageModels;
using LANMIC_ComBank_Interface.Models.SessionModel;
using LANMIC_ComBank_Interface.Models.SystemModels;
using LANMIC_ComBank_Interface.Models.ViewModels;
using log4net;
using Newtonsoft.Json;

namespace LANMIC_ComBank_Interface.Forms.Tools.Sage
{
    public partial class frmAPPostedPayments : Form
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly AppDbContext db;
        private readonly UserAuthorityViewModel authPermission;
        //private readonly SageAPICredentials _sageAPICredentials = new SageAPICredentials();
        private List<SageVendor> vendors = new List<SageVendor>();
        private List<SageVenderPostedPayments> savedPayments = new List<SageVenderPostedPayments>();
        bool isDeleteMode = false;
        bool isNewMode = false;
        public frmAPPostedPayments()
        {
            InitializeComponent();
            ControlHelpers.AddHorizontalSeparator(this);
            db = new AppDbContext(AppConfigService.ConnectionString());
            authPermission = UserSession.UserPermissions.FirstOrDefault(x => x.FormName == this.Name);
            //_sageAPICredentials.URL = "http://192.168.11.68/Sage300WebApi/v1.0/-/SAMINC/AP/APPostedPayments";
            //_sageAPICredentials.Company = "SAMINC";
            //_sageAPICredentials.Username = "WEBUSER";
            //_sageAPICredentials.Password = "Webuser@123";
            dtpToDate.MaxDate = DateTime.Today;
            dtpFromDate.MaxDate = DateTime.Today;
        }

        private void btnLoadSageAPPostedPayments_Click(object sender, EventArgs e)
        {
            GetAPPostedPaymentsAsync();
        }

        public async void GetAPPostedPaymentsAsync()
        {
            try
            {              
                btnLoadSageAPPostedPayments.Enabled = false;
                dataGridView.Rows.Clear();
                progressBar.Value = 0;

                var apiEndPoint = "APPostedPayments";
                var result = await SageApiClient.GetListAsync(apiEndPoint);
                if (!string.IsNullOrEmpty(result))
                {
                    List<SageAPPostedPaymentsAPIModel> vendor = JsonConvert.DeserializeObject<List<SageAPPostedPaymentsAPIModel>>(result);

                    if (vendor.Count > 0)
                    {
                        var vendorLookup = vendors.ToDictionary(x => x.VendorNumber, x => x);

                        foreach (var v in vendor)
                        {
                            if (vendorLookup.TryGetValue(v.VendorNumber, out var vendorInfo))
                            {
                                v.VendorName = vendorInfo.VendorName;
                                v.BankName = vendorInfo.BankName;
                                v.Email = vendorInfo.Email;
                                v.SWIFT_Code = vendorInfo.SWIFT_Code;
                                v.BankAccountNo = vendorInfo.BankAccountNo;
                                v.BankName = vendorInfo.BankName;
                                v.Email = vendorInfo.Email;

                                // 🔎 Validation
                                if (!string.IsNullOrWhiteSpace(v.BankAccountNo) &&
                                    !string.IsNullOrWhiteSpace(v.BankName) &&
                                    v.PaymentAmount > 0)
                                {
                                    v.Status = PaymentStatus.Validated;
                                    v.CurrencyCode = vendorInfo.CurrencyCode;
                                }
                                else
                                {
                                    v.Status = PaymentStatus.ValidationFailed;
                                    v.ErrorMessage = "Missing bank details or invalid amount.";
                                    v.CurrencyCode = "";
                                }
                            }
                            else
                            {
                                v.Status = PaymentStatus.ValidationFailed;
                                v.ErrorMessage = "Vendor not found.";
                                v.CurrencyCode = "";
                            }
                        }

                        dataGridView.Rows.Clear();
                        progressBar.Minimum = 0;
                        progressBar.Maximum = vendor.Count;

                        foreach (var p in vendor.OrderByDescending(x => x.Status))
                        {
                            if (!savedPayments.Any(x => x.DocumentNumber == p.DocumentNumber))
                            {
                                var rowIndex = dataGridView.Rows.Add(false,
                                                        p.DocumentNumber,
                                                        p.DocumentType,
                                                        p.VendorNumber,
                                                        p.VendorName,
                                                        p.PaymentAmount,
                                                        p.BankName,
                                                        p.BankAccountNo,
                                                        p.SWIFT_Code,
                                                        p.CurrencyCode,
                                                        p.Email,
                                                        p.PostingDate,
                                                        p.Status.ToString()
                                                        );
                                DataGridViewRow addedRow = dataGridView.Rows[rowIndex];

                                if (p.Status == PaymentStatus.ValidationFailed)
                                {
                                    addedRow.DefaultCellStyle.BackColor = Color.LightCoral;
                                    addedRow.DefaultCellStyle.ForeColor = Color.Black;
                                    addedRow.Cells[0].ReadOnly = true;
                                }
                                else
                                {
                                    addedRow.DefaultCellStyle.BackColor = Color.LightGreen;
                                    addedRow.DefaultCellStyle.ForeColor = Color.Black;
                                    addedRow.Cells[0].ReadOnly = false;
                                }

                            }
                            progressBar.Value += 1;
                        }
                        //dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    }
                }
                btnLoadSageAPPostedPayments.Enabled = true;
            }
            catch (Exception ex)
            {
                log.Error("Error in GetAPPostedPaymentsAsync: " + ex.Message, ex.InnerException);
                //var errorMessage = "An error occurred while retrieving vendors: " + ex.Message;
            }
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            dtpToDate.MinDate = dtpFromDate.Value;
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            dtpFromDate.MaxDate = dtpToDate.Value;
        }

        private void LoadVendor()
        {
            vendors = (from v in db.SageVendors
                       where v.IsActive == true
                       select v
                           ).ToList();

            // Add manual "All" option
            var vendorList = new List<object>
                               {
                                   new {
                                       VendorNumber = "0",
                                       VendorName = "All"
                                   }
                               };
            vendorList.AddRange(vendors.Select(v => new
            {
                v.VendorNumber,
                v.VendorName
            }));

            // Bind to ComboBox
            cmbVendors.DataBindings.Clear();
            cmbVendors.DataSource = vendorList;
            cmbVendors.DisplayMember = "VendorName";
            cmbVendors.ValueMember = "VendorNumber";
            cmbVendors.SelectedValue = "0"; // default selection
        }

        private void frmAPPostedPayments_Load(object sender, EventArgs e)
        {
            LoadVendor();
            LoadSavedAPPostedPayments();
        }

        private void LoadSavedAPPostedPayments()
        {
            btnLoadSageAPPostedPayments.Enabled = false;
            isDeleteMode = false;
            isNewMode = false;
            savedPayments = db.SageVenderPostedPayments.Where(x=> x.IsActive).ToList();
            dataGridView.Rows.Clear();
            dataGridView.Columns[0].ReadOnly = true;
            //dataGridView.Columns. IsReadOnly = true;
            progressBar.Minimum = 0;
            progressBar.Maximum = savedPayments.Count;
            progressBar.Value = 0;
            foreach (var p in savedPayments)
            {
                var rowIndex = dataGridView.Rows.Add(true,
                                        p.DocumentNumber,
                                        p.DocumentType,
                                        p.VendorNumber,
                                        p.VendorName,
                                        p.PaymentAmount,
                                        p.BankName,
                                        p.BankAccountNo,
                                        p.SWIFT_Code,
                                        p.CurrencyCode,
                                        p.Email,
                                        p.PostingDate,
                                        p.CurrentStatus.ToString()
                                        );
                DataGridViewRow addedRow = dataGridView.Rows[rowIndex];
                if (p.CurrentStatus == PaymentStatus.Rejected)
                {
                    addedRow.DefaultCellStyle.BackColor = Color.LightCoral;
                    addedRow.DefaultCellStyle.ForeColor = Color.Black;
                    //addedRow.Cells[0].ReadOnly = true;
                }
               
                //else
                //{
                //    addedRow.DefaultCellStyle.BackColor = Color.LightGreen;
                //    addedRow.DefaultCellStyle.ForeColor = Color.Black;
                //}
                progressBar.Value += 1;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (isDeleteMode)
            {
                var paymentsToDelete = new List<SageVenderPostedPayments>();
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == false) // Unchecked rows for deletion
                    {
                        string documentNumber = row.Cells[1].Value?.ToString();
                        string documentType = row.Cells[2].Value?.ToString();
                        string vendorNumber = row.Cells[3].Value?.ToString();
                        DateTime postingDate = row.Cells[11].Value is DateTime dt ? dt : Convert.ToDateTime(row.Cells[10].Value);
                        var payment = db.SageVenderPostedPayments.FirstOrDefault(p =>
                            p.DocumentNumber == documentNumber &&
                            p.DocumentType == documentType &&
                            p.VendorNumber == vendorNumber &&
                            p.PostingDate == postingDate);
                        if (payment != null)
                        {
                            paymentsToDelete.Add(payment);
                        }
                    }
                }

                if (paymentsToDelete.Count > 0)
                {
                    foreach (var payment in paymentsToDelete)
                    {
                        payment.IsActive = false; // Soft delete
                    }
                    db.SaveChanges();
                    MessageBox.Show($"{paymentsToDelete.Count} payments deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSavedAPPostedPayments(); // Refresh the grid
                }
                else
                {
                    MessageBox.Show("No payments selected for deletion.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
              
                return;
            }
            else
            {
                bool anyChecked = dataGridView.Rows.Cast<DataGridViewRow>()
                                     .Any(row => Convert.ToBoolean(row.Cells[0].Value) == true && row.Cells[12].Value?.ToString() == "Validated");

                if (!anyChecked)
                {
                    MessageBox.Show("No data to save.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    progressBar.Value = 0;
                    progressBar.Minimum = 0;
                    progressBar.Maximum = dataGridView.Rows.Count + 1;

                    var selectedPayments = new List<SageVenderPostedPayments>();
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value) == true && row.Cells[12].Value?.ToString() == "Validated") // Assuming the checkbox is in the first column
                        {
                            var payment = new SageVenderPostedPayments
                            {
                                //DocumentNumber = row.Cells[1].Value?.ToString(),
                                //DocumentType = row.Cells[2].Value?.ToString(),
                                //PaymentAmount = Convert.ToDecimal(row.Cells[3].Value),
                                //BankCode = row.Cells[4].Value?.ToString(),
                                //VendorNumber = row.Cells[5].Value?.ToString(),
                                //VendorName = row.Cells[6].Value?.ToString(),
                                //PostingDate = Convert.ToDateTime(row.Cells[7].Value),


                                DocumentNumber = row.Cells[1].Value?.ToString(),
                                DocumentType = row.Cells[2].Value?.ToString(),
                                VendorNumber = row.Cells[3].Value?.ToString(),
                                VendorName = row.Cells[4].Value?.ToString(),
                                PaymentAmount = Convert.ToDecimal(row.Cells[5].Value),
                                BankName = row.Cells[6].Value?.ToString(),
                                BankAccountNo = row.Cells[7].Value?.ToString(),
                                SWIFT_Code = row.Cells[8].Value?.ToString(),
                                CurrencyCode = row.Cells[9].Value?.ToString(),
                                Email = row.Cells[10].Value?.ToString(),
                                PostingDate = row.Cells[11].Value is DateTime dt ? dt : Convert.ToDateTime(row.Cells[10].Value),
                                CurrentStatus = PaymentStatus.ReadyToSend,

                            };
                            selectedPayments.Add(payment);
                        }
                        progressBar.Value += 1;
                    }

                    if (selectedPayments.Count > 0)
                    {
                        db.SageVenderPostedPayments.AddRange(selectedPayments);
                        db.SaveChanges();
                        progressBar.Value += 1;
                        MessageBox.Show($"{selectedPayments.Count} payments saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSavedAPPostedPayments(); // Refresh the grid
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnLoadSageAPPostedPayments.Enabled = true;
            isNewMode = true;
            isDeleteMode = false;
            dataGridView.Rows.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSavedAPPostedPayments();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0 && isNewMode == false)
            {
                if (isDeleteMode)
                {
                    MessageBox.Show("Already in delete mode. Uncheck the payments you want to delete and click Save.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                isDeleteMode = true;
                dataGridView.Columns[0].ReadOnly = false;
                btnLoadSageAPPostedPayments.Enabled = false;

                MessageBox.Show(
                    "You can uncheck the checkbox in each row to delete it. Once saved, it will no longer appear again.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
