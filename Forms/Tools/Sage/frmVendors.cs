using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private readonly SageAPICredentials _sageAPICredentials = new SageAPICredentials();
        private readonly AppDbContext db;
        private readonly UserAuthorityViewModel authPermission;
        private bool isEditMode = false;

        public frmVendors()
        {
            InitializeComponent();
            ControlHelpers.AddHorizontalSeparator(this);
            db = new AppDbContext(AppConfigService.ConnectionString());
            authPermission = UserSession.UserPermissions.FirstOrDefault(x => x.FormName == this.Name);


            _sageAPICredentials.URL = "192.168.11.68";
            _sageAPICredentials.Company = "SAMINC";
            _sageAPICredentials.Username = "WEBUSER";
            _sageAPICredentials.Password = "Webuser@123";
        }

        private void btnSageVendors_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                MessageBox.Show("Finish editing the current entry before editing another.", "Edit In Progress", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            GetVendorsAsync();
        }

        public async void GetVendorsAsync()
        {
            try
            {
                dataGridView.Rows.Clear();
                progressBar.Value = 0;
                var result = await SageApiClient.GetListAsync(_sageAPICredentials);
                if (!string.IsNullOrEmpty(result))
                {
                    List<SageVendorAPIModel> vendor = JsonConvert.DeserializeObject<List<SageVendorAPIModel>>(result);
                    if (vendor.Count > 0)
                    {
                        dataGridView.Rows.Clear();
                        progressBar.Minimum = 0;
                        progressBar.Maximum = vendor.Count;

                        foreach (var v in vendor)
                        {
                            //dataGridView.Rows.Add(v.VendorNumber, v.VendorName, "", v.BankCode, v.Email);
                            dataGridView.Rows.Add(v.VendorNumber, v.VendorName, "", "", "", v.Status);
                            progressBar.Value += 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                var errorMessage = "An error occurred while retrieving vendors: " + ex.Message;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                MessageBox.Show("Finish editing the current entry before editing another.", "Edit In Progress", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        var vendor = new Vender
                        {
                            VendorNumber = row.Cells["VendorNumber"].Value.ToString(),
                            VendorName = row.Cells["VendorName"].Value.ToString(),
                            BankName = row.Cells["BankName"].Value.ToString(),
                            SWIFT_Code = row.Cells["SWIFTCode"].Value.ToString(),
                            Email = row.Cells["Email"].Value.ToString(),
                            Status = row.Cells["Status"].Value.ToString() == "Active" ? true : false
                        };

                        var existingVendor = db.Venders
                            .FirstOrDefault(v => v.VendorNumber == vendor.VendorNumber);
                        if (existingVendor != null)
                        {
                            existingVendor.VendorName = vendor.VendorName;
                            existingVendor.BankName = vendor.BankName;
                            existingVendor.SWIFT_Code = vendor.SWIFT_Code;
                            existingVendor.Email = vendor.Email;
                            existingVendor.Status = vendor.Status;
                        }
                        else
                        {
                            db.Venders.Add(vendor);
                        }
                        db.SaveChanges();                       
                    }

                    tran.Commit();
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message, ex.InnerException);
                    tran.Rollback();
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
                    var swiftCode = row.Cells["SWIFTCode"].Value.ToString();
                    var email = row.Cells["Email"].Value.ToString();
                    var status = row.Cells["Status"].Value.ToString();

                    txtVendorNumber.Text = vendorNumber;
                    txtVendorName.Text = vendorName;
                    txtBankName.Text = bankName;
                    txtSWIFTCode.Text = swiftCode;
                    txtEmail.Text = email;
                    //txtStatus.Text = status.ToString();
                    if (status == "Active")
                    {
                        chkIsActive.Checked = true;
                    }
                    else
                    {
                        chkIsActive.Checked = true;
                    }

                    dataGridView.Rows.RemoveAt(rowId);
                    isEditMode = true;
                }
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           string vendorNumber= txtVendorNumber.Text ;
           string vendorName= txtVendorName.Text     ;
           string bankName= txtBankName.Text         ;
           string swiftCode= txtSWIFTCode.Text       ;
           string email = txtEmail.Text;
           string status = chkIsActive.Checked ? "Active" : "Inactive";


            int index = dataGridView.Rows.Add(vendorNumber, vendorName, bankName, swiftCode, email, status);
            dataGridView.ClearSelection();
            dataGridView.Rows[index].Selected = true;
            dataGridView.FirstDisplayedScrollingRowIndex = index;


            txtVendorNumber.Clear();
            txtVendorName.Clear();
            txtBankName.Clear();
            txtSWIFTCode.Clear();
            txtEmail.Clear();

            isEditMode = false;
        }
    }
}
