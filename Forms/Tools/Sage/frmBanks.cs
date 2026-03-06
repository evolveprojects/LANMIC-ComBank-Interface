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
using LANMIC_ComBank_Interface.Models.SageModels;
using LANMIC_ComBank_Interface.Models.SessionModel;
using LANMIC_ComBank_Interface.Models.ViewModels;
using log4net;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace LANMIC_ComBank_Interface.Forms.Tools.Sage
{
    public partial class frmBanks : Form
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        //private readonly SageAPICredentials _sageAPICredentials = new SageAPICredentials();
        private readonly AppDbContext db;
        private readonly UserAuthorityViewModel authPermission;
        List<SageBanksAPIModel> banks = new List<SageBanksAPIModel>();
        public frmBanks()
        {
            InitializeComponent();
            ControlHelpers.AddHorizontalSeparator(this);
            db = new AppDbContext(AppConfigService.ConnectionString());
            authPermission = UserSession.UserPermissions.FirstOrDefault(x => x.FormName == this.Name);
        }

        private void btnGetSageBanks_Click(object sender, EventArgs e)
        {
            LoadBanks();
        }
        public async void LoadBanks()
        {
            btnGetSageBanks.Enabled = false;
            btnRefesh.Enabled = false;

            try
            {
                //dataGridView.Rows.Clear();
                progressBar.Value = 0;
                var apiEndPoint = "BKBanks";
                var result = await SageApiClient.GetListAsync(apiEndPoint);
                if (!string.IsNullOrEmpty(result))
                {
                    banks = JsonConvert.DeserializeObject<List<SageBanksAPIModel>>(result);
                    if (banks.Count > 0)
                    {
                        //var banksList =(from b in banks select new KeyValuePair<string, string>( b.BankCode, b.Description )).ToList();
                        var banksList = (from b in banks
                                         select new
                                         {
                                             b.BankCode,
                                             b.Description
                                         }).ToList();

                        //dataGridView.Rows.Clear();
                        progressBar.Minimum = 0;
                        progressBar.Maximum = banks.Count;
                        //cmbSageBanks.Items.Clear();
                        cmbSageBanks.DataBindings.Clear();
                        cmbSageBanks.DataSource = null;
                        cmbSageBanks.DisplayMember = "Description";
                        cmbSageBanks.ValueMember = "BankCode";
                        cmbSageBanks.DataSource = banksList;
                        progressBar.Value = banks.Count;
                        //foreach (var bank in banksList)
                        //{
                        //    cmbSageBanks.Items.Add($"{bank.BankCode} - {bank.Description}");

                        //    //progressBar.Value += 1;
                        //}
                        //cmbSageBanks.SelectedIndex = 0;


                        //foreach (var v in vendor)
                        //{
                        //    //dataGridView.Rows.Add(v.VendorNumber, v.VendorName, "", v.BankCode, v.Email);
                        //    dataGridView.Rows.Add(v.VendorNumber, v.VendorName, "", "", "", v.Status);
                        //    progressBar.Value += 1;
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex.InnerException);
                MessageBox.Show("Error fetching banks from Sage API.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGetSageBanks.Enabled = true;
                btnRefesh.Enabled = true;
            }
        }

        private void cmbSageBanks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
            string bnkCode = cmbSageBanks.SelectedValue != null ? cmbSageBanks.SelectedValue.ToString() : "";
            if (!string.IsNullOrEmpty(bnkCode))
            {
                var selectedBank = banks.FirstOrDefault(x => x.BankCode == bnkCode);
                if (selectedBank != null)
                {
                    txtBankCode.Text = selectedBank.BankCode;
                    txtBankAccountNo.Text = selectedBank.BankAccountNumber;
                    txtCurrency.Text = selectedBank.StatementCurrency;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var bankCode = txtBankCode.Text.Trim();
            var bankAccountNo = txtBankAccountNo.Text.Trim();
            var currency = txtCurrency.Text.Trim();
            var bankName = cmbSageBanks.Text.Trim();

            if (string.IsNullOrEmpty(bankCode) || string.IsNullOrEmpty(bankAccountNo) || string.IsNullOrEmpty(currency))
            {
                MessageBox.Show("Please fill in all required fields (Bank Code, Bank Account No, Currency).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newBank = new SageBanksAPIModel
            {
                BankCode = bankCode,
                BankAccountNumber = bankAccountNo,
                StatementCurrency = currency,
                Description = bankName
            };

            // Check for duplicate Bank Code
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells[0].Value != null && dataGridView.Rows[i].Cells[0].Value.ToString() == newBank.BankCode)
                {
                    MessageBox.Show("Bank Code already exists in the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            // Add row and get its index
            int rowIndex = dataGridView.Rows.Add(newBank.BankCode, newBank.Description, newBank.BankAccountNumber, newBank.StatementCurrency);
            // Highlight the newly added row
            DataGridViewRow addedRow = dataGridView.Rows[rowIndex];
            addedRow.DefaultCellStyle.BackColor = Color.LightGreen;
            addedRow.DefaultCellStyle.ForeColor = Color.Black;

            // Optional: auto-select the new row
            dataGridView.ClearSelection();
            addedRow.Selected = true;
        }

        private void Clear()
        {
            txtBankAccountNo.Text = "";
            txtBankCode.Text = "";
            txtCurrency.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0)
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        // delete all records in bank table.
                        var allBanks = db.SageBanks.ToList();
                        db.SageBanks.RemoveRange(allBanks);

                        // Insert new records from datagridview to bank table.
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            if (row.Cells[0].Value != null)
                            {
                                var bankCode = row.Cells[0].Value.ToString();
                                var bankName = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : "";
                                var bankAccountNo = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : "";
                                var currency = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : "";
                                var bank = new SageBanks
                                {
                                    BankCode = bankCode,
                                    BankName = bankName,
                                    BankAccountNo = bankAccountNo,
                                    CurrencyCode = currency
                                };
                                db.SageBanks.Add(bank);
                            }
                        }
                        db.SaveChanges();
                        tran.Commit();
                        MessageBox.Show("Banks saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        log.Error(ex.Message, ex.InnerException);
                        tran.Rollback();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    dataGridView.Rows.Remove(row);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBanks();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
