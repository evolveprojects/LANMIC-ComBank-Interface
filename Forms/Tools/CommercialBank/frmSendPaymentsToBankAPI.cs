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
using LANMIC_ComBank_Interface.HelpServices.CombankAPI;
using LANMIC_ComBank_Interface.Models.CombankModels;
using LANMIC_ComBank_Interface.Models.DatabaseModels;
using LANMIC_ComBank_Interface.Models.SessionModel;
using LANMIC_ComBank_Interface.Models.ViewModels;
using log4net;
using Newtonsoft.Json.Linq;

namespace LANMIC_ComBank_Interface.Forms.Tools.CommercialBank
{
    public partial class frmSendPaymentsToBankAPI : Form
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly AppDbContext db;
        private readonly UserAuthorityViewModel authPermission;
        //private readonly SageAPICredentials _sageAPICredentials = new SageAPICredentials();
        private List<SageVendor> vendors = new List<SageVendor>();
        private List<SageVenderPostedPayments> savedPayments = new List<SageVenderPostedPayments>();

        public frmSendPaymentsToBankAPI()
        {

            InitializeComponent();
            ControlHelpers.AddHorizontalSeparator(this);
            db = new AppDbContext(AppConfigService.ConnectionString());
            authPermission = UserSession.UserPermissions.FirstOrDefault(x => x.FormName == this.Name);

            dtpToDate.MaxDate = DateTime.Today;
            dtpToDate.MinDate = DateTime.Today.AddDays(-1);
            dtpFromDate.MaxDate = DateTime.Today.AddDays(-1);
        }

        private void frmSendPaymentsToBankAPI_Load(object sender, EventArgs e)
        {
            LoadVendor();
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

        private void LoadDocumentsTypes()
        {
            var vendorNumber = cmbVendors.SelectedValue.ToString();
            var DocumentTypeList = new List<object>
                               {
                                   new {
                                       DocumentType = "All"
                                   }
                               };

            if (vendorNumber == "0")
            {
                var documentTypes = (from p in db.SageVenderPostedPayments
                                     where p.IsActive == true
                                     select p.DocumentType).Distinct().ToList();

                DocumentTypeList.AddRange(documentTypes.Select(dt => new
                {
                    DocumentType = dt
                }));
            }
            else
            {
                var documentTypes = (from p in db.SageVenderPostedPayments
                                     where p.IsActive == true && p.VendorNumber == vendorNumber
                                     select p.DocumentType).Distinct().ToList();
                DocumentTypeList.AddRange(documentTypes.Select(dt => new
                {
                    DocumentType = dt
                }));

            }

            cmbDocumentTypes.DataBindings.Clear();
            cmbDocumentTypes.DataSource = null;
            cmbDocumentTypes.DataSource = DocumentTypeList;
            cmbDocumentTypes.DisplayMember = "DocumentType";
            cmbDocumentTypes.ValueMember = "DocumentType";
            cmbDocumentTypes.SelectedValue = "All"; // default selection
        }
        private void cmbVendors_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDocumentsTypes();
        }

        private void cmbDocumentTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCurrentStatus();
        }

        private void LoadCurrentStatus()
        {
            if (cmbDocumentTypes.SelectedValue != null)
            {
                var vendorNumber = cmbVendors.SelectedValue.ToString();
                var documentType = cmbDocumentTypes.SelectedValue == null ? "All" : cmbDocumentTypes.SelectedValue.ToString();
                var currentStatusList = new List<object>
                               {
                                   new {
                                       CurrentStatus = "All",
                                       CurrentStatusValue = 0
                                   }
                               };

                if (vendorNumber == "0" && documentType == "All")
                {
                    var currentStatuses = (from p in db.SageVenderPostedPayments
                                           where p.IsActive == true
                                           select p.CurrentStatus).Distinct().ToList();
                    currentStatusList.AddRange(currentStatuses.Select(cs => new
                    {
                        CurrentStatus = cs.ToString(),
                        CurrentStatusValue = (int)cs
                    }));
                }
                else if (vendorNumber == "0" && documentType != "All")
                {
                    var currentStatuses = (from p in db.SageVenderPostedPayments
                                           where p.IsActive == true && p.DocumentType == documentType
                                           select p.CurrentStatus).Distinct().ToList();
                    currentStatusList.AddRange(currentStatuses.Select(cs => new
                    {
                        CurrentStatus = cs.ToString(),
                        CurrentStatusValue = (int)cs
                    }));
                }
                else if (vendorNumber != "0" && documentType == "All")
                {
                    var currentStatuses = (from p in db.SageVenderPostedPayments
                                           where p.IsActive == true && p.VendorNumber == vendorNumber
                                           select p.CurrentStatus).Distinct().ToList();
                    currentStatusList.AddRange(currentStatuses.Select(cs => new
                    {
                        CurrentStatus = cs.ToString(),
                        CurrentStatusValue = (int)cs
                    }));
                }
                else
                {
                    var currentStatuses = (from p in db.SageVenderPostedPayments
                                           where p.IsActive == true && p.VendorNumber == vendorNumber && p.DocumentType == documentType
                                           select p.CurrentStatus).Distinct().ToList();
                    currentStatusList.AddRange(currentStatuses.Select(cs => new
                    {
                        CurrentStatus = cs.ToString(),
                        CurrentStatusValue = (int)cs
                    }));

                }

                cmbCurrentStatus.DataBindings.Clear();
                cmbCurrentStatus.DataSource = null;
                cmbCurrentStatus.DataSource = currentStatusList;
                cmbCurrentStatus.DisplayMember = "CurrentStatus";
                cmbCurrentStatus.ValueMember = "CurrentStatusValue";
                cmbCurrentStatus.SelectedValue = 0; // default selection
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var vendorNumber = cmbVendors.SelectedValue.ToString();
            var documentType = cmbDocumentTypes.SelectedValue == null ? "All" : cmbDocumentTypes.SelectedValue.ToString();
            var currentStatus = (cmbCurrentStatus.SelectedValue == null || (int)cmbCurrentStatus.SelectedValue == 0) ? 0
                              : (int)cmbCurrentStatus.SelectedValue;
            var fromDate = dtpFromDate.Value.Date;
            var toDate = dtpToDate.Value.Date;

            var query = db.SageVenderPostedPayments.Where(p => p.IsActive == true);

            if (vendorNumber != "0")
            {
                query = query.Where(p => p.VendorNumber == vendorNumber);
            }
            if (documentType != "All")
            {
                query = query.Where(p => p.DocumentType == documentType);
            }
            if (currentStatus != 0)
            {
                var currentStatusValue = (PaymentStatus)currentStatus;
                query = query.Where(p => p.CurrentStatus == currentStatusValue);
            }
            savedPayments = query.ToList();
            dataGridView.Rows.Clear();
            foreach (var i in savedPayments)
            {
                dataGridView.Rows.Add(false,
                                    i.DocumentNumber,
                                    i.DocumentType,
                                    i.VendorNumber,
                                    i.VendorName,
                                    i.PaymentAmount,
                                    i.BankName,
                                    i.BankAccountNo,
                                    i.SWIFT_Code,
                                    i.CurrencyCode,
                                    i.Email,
                                    i.PostingDate,
                                    i.CurrentStatus.ToString()
                                    );
            }
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            dtpToDate.MinDate = dtpFromDate.Value.Date;
        }

        private async void btnSentToBank_Click(object sender, EventArgs e)
        {
            //var token = await GetAccessToken.GetAccessTokenAsync();
            //var token = await TokenManager.GetValidAccessTokenAsync();
            //var date = DateTime.Now.ToString("yyyyMMdd");
            //PaymentRequest payment = new PaymentRequest
            //{
            //    inStatus = "",
            //    cbcReference = "10004785942026012603",
            //    inputChanel = "1000478594",
            //    inChanelIP32 = "192.168.1.1",
            //    inOutFlag = "I",
            //    priorityFlag = "N",
            //    processChanel = "E2GEN",
            //    msgType = "CUSTTFR",
            //    accountFlag = "S",
            //    stpFlag = "N",
            //    sancFlag = "N",
            //    inputUser = "N100038783",
            //    inDate = "",
            //    recDate = "",
            //    holdate = "",
            //    reference = "DR2026012601",
            //    fxReference = "",
            //    valDate = date,//20260126
            //    currCode = "LKR",
            //    amount = "1000",
            //    department = "FOREIGN_BRCH",
            //    instCur = "",
            //    instAmt = "",
            //    exchangeRate = "",
            //    messIndex = "",
            //    messTotal = "",
            //    instrCode = "INTRABANK",
            //    trnRefNbr = "CR2026012601",
            //    trnCode = "",
            //    retCode = "",
            //    benBnkCode = "",
            //    benBrnCode = "",
            //    trnType = "",
            //    benInstBIC = "",
            //    benefBIC2 = "",
            //    beneAcTyp = "",
            //    benefAcct = "8750033501",
            //    beneName = "EVL_Test",
            //    beneAdd1 = "EVL_Test",
            //    beneAdd2 = "EVL_Test",
            //    beneAdd3 = "EVL_Test",
            //    purpcode = "123",
            //    particular = "IPARTIC50123456789012345678901234567890123456789",
            //    orgBkCode = "",
            //    orgBrCode = "",
            //    orgBIC = "",
            //    orgAcTyp = "",
            //    orgAccount = "1460389301",
            //    orgName = "",
            //    orgAdd1 = "",
            //    orgAdd2 = "",
            //    orgAdd3 = "",
            //    furInstr = "",
            //    secCheck = "",
            //    filler = "",
            //    orgDate = "",
            //    ordInsBIC = "",
            //    senCorBIC = "",
            //    recCorBIC = "",
            //    thrRemBIC = "",
            //    interBIC = "",
            //    chgDetail = "",
            //    detPaymnt = "",
            //    senToRec = "CBEX12022E025517",
            //    bitMap = "",
            //    priActNo = "",
            //    beneCard = "",
            //    desAccNo = "",
            //    cardPAN = "",
            //    cardAcct = "",
            //    cdDesActNm = "",
            //    cdOrgActNm = "",
            //    proCode = "",
            //    trnMisDate = "",
            //    sysTrcNbr = "",
            //    locTrnTime = "",
            //    locTrnDate = "",
            //    setleDate = "",
            //    capDate = "",
            //    marchType = "",
            //    acqInsCode = "",
            //    retRefNo = "",
            //    cardAccpTm = "",
            //    cardAccpId = "",
            //    cardAccNm = "",
            //    cardCurCod = "",
            //    addTermDtl = "",
            //    msgAuthCd = "",
            //    efttlvData = "",
            //    debtorNm = "",
            //    dbTitle = "",
            //    dbFrstNm = "",
            //    dbSecNm = "",
            //    dbLstNm = "",
            //    dbDOB = "",
            //    dbProvDOB = "",
            //    dbCityDOB = "",
            //    dbCntDOB = "",
            //    dbCntRes = "",
            //    dbWkPhone = "",
            //    dbHmPhone = "",
            //    dbMobPhone = "",
            //    dbFax = "",
            //    dbEmail = "",
            //    dbBIC = "",
            //    dbLEI = "",
            //    dbOthIdent = "",
            //    dbSchCode = "",
            //    dbSchName = "",
            //    dbCntCode = "",
            //    dbDept = "",
            //    dbSubDept = "",
            //    dbStrtNam = "",
            //    dbBuildNo = "",
            //    dbBuildNam = "",
            //    dbFloor = "",
            //    dbPosBox = "",
            //    dbRoom = "",
            //    dbPostCod = "",
            //    dbTownNm = "",
            //    dbLocNam = "",
            //    dbDistNm = "",
            //    dbCntSubDv = "",
            //    dbAddLn = "",
            //    dbIBAN = "",
            //    dbOthActID = "",
            //    creidNm = "",
            //    crTitle = "",
            //    crFrstNm = "",
            //    crSecNm = "",
            //    crLstNm = "",
            //    crDOB = "",
            //    crProvDOB = "",
            //    crCityDOB = "",
            //    crCntDOB = "",
            //    crCntRes = "",
            //    crWkPhone = "",
            //    crHomPhone = "009477370",
            //    crMobPhone = "",
            //    crFax = "",
            //    crEmail = "",
            //    crBIC = "",
            //    crLEI = "",
            //    crOthIdent = "",
            //    crSchCode = "",
            //    crSchName = "",
            //    crCntCode = "",
            //    crDept = "",
            //    crSubDept = "",
            //    crStrtNam = "",
            //    crBuildNo = "",
            //    crBuildNam = "",
            //    crFloor = "",
            //    crPosBox = "",
            //    crRoom = "",
            //    crPostCod = "",
            //    crTownNm = "",
            //    crLocNam = "",
            //    crDistNm = "",
            //    crCntSubDv = "",
            //    crAddLn = "",
            //    crIBAN = "",
            //    crOthActID = "",
            //    posentCode = "",
            //    posconCode = ""
            //};

            //var sdsd = SendPaymentRequest.SendPaymentAsync(payment);

            var sdsd = CheckStatusOfPaymentRequest.CheckStatusAsync("1000478594", "10004785942026012602");

        }
    }
}
