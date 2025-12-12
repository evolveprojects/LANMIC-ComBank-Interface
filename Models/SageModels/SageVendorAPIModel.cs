using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LANMIC_ComBank_Interface.Models.SageModels
{
    public class SageVendorAPIModel
    {
        public string VendorNumber { get; set; }
        public string ShortName { get; set; }
        public string GroupCode { get; set; }
        public string Status { get; set; }
        public object InactiveDate { get; set; }
        public string DateLastMaintained { get; set; }
        public string OnHold { get; set; }
        public string StartDate { get; set; }
        public string ParticipantID { get; set; }
        public string VendorName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string ZipPostalCode { get; set; }
        public string Country { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string PrimaryRemitToLocation { get; set; }
        public string AccountSet { get; set; }
        public string CurrencyCode { get; set; }
        public string RateType { get; set; }
        public string BankCode { get; set; }
        public string PrintSeparateChecks { get; set; }
        public string DistributionSet { get; set; }
        public string DistributionCode { get; set; }
        public string GLAccount { get; set; }
        public string Terms { get; set; }
        public string DuplicateAmountCode { get; set; }
        public string DuplicateDateCode { get; set; }
        public string TaxGroup { get; set; }
        public int TaxClassCode1 { get; set; }
        public int TaxClassCode2 { get; set; }
        public int TaxClassCode3 { get; set; }
        public int TaxClassCode4 { get; set; }
        public int TaxClassCode5 { get; set; }
        public string TaxReportingType { get; set; }
        public string Num1099CPRSTaxNumber { get; set; }
        public string TaxType { get; set; }
        public string Num1099CPRSCode { get; set; }
        public decimal CreditLimit { get; set; }
        public decimal BalanceDueInVendorCurrency { get; set; }
        public decimal BalanceDueInFunctionalCurrency { get; set; }
        public decimal TotalPrepaidInvoiceVendorCurr { get; set; }
        public decimal TotalPrepaidInvoiceFunctionalCurr { get; set; }
        public object DateOfLastRevaluation { get; set; }
        public decimal LastRevaluationBalance { get; set; }
        public int NumberOfOpenInvoices { get; set; }
        public int NumberOfPrepaidInvoices { get; set; }
        public int NumberOfPaidInvoices { get; set; }
        public int NumberOfDaysToPay { get; set; }
        public string DateOfLargestInvoice { get; set; }
        public string DateOfHighestBalance { get; set; }
        public object DateOfLargestInvoiceLastYear { get; set; }
        public object DateOfHighestBalanceLastYear { get; set; }
        public string DateOfLastActivity { get; set; }
        public string DateOfLastInvoice { get; set; }
        public string DateOfLastCreditNote { get; set; }
        public object DateOfLastDebitNote { get; set; }
        public string DateOfLastPayment { get; set; }
        public object DateOfLastDiscount { get; set; }
        public string DateOfLastAdjustment { get; set; }
        public string NumberOfLargestInvoice { get; set; }
        public string NumberOfLargestInvoiceLastY { get; set; }
        public decimal LargestInvoiceVendorCurrency { get; set; }
        public decimal HighestBalanceVendorCurrency { get; set; }
        public decimal LargestInvoiceLastYearVendorCurrency { get; set; }
        public decimal HighBalanceLastYearVendorCurrency { get; set; }
        public decimal LastInvoiceAmtVendorCurrency { get; set; }
        public decimal LastCreditNoteAmountVendorCurrency { get; set; }
        public decimal LastDebitNoteAmountVendorCurrency { get; set; }
        public decimal LastPaymentVendorCurrency { get; set; }
        public decimal LastDiscountAmountVendorCurrency { get; set; }
        public decimal LastAdjustmentAmountVendorCurrency { get; set; }
        public decimal LargestInvoiceFunctionalCurrency { get; set; }
        public decimal HighestBalanceFunctionalCurrency { get; set; }
        public decimal LargestInvoiceLastYearFunctionalCurrency { get; set; }
        public decimal HighBalanceLastYearFunctionalCurrency { get; set; }
        public decimal LastInvoiceAmountFunctionalCurrency { get; set; }
        public decimal LastCreditNoteAmountFunctionalCurrency { get; set; }
        public decimal LastDebitNoteAmountFunctionalCurrency { get; set; }
        public decimal LastPaymentFunctionalCurrency { get; set; }
        public decimal LastDiscountAmountFunctionalCurrency { get; set; }
        public decimal LastAdjustmentAmountFunctionalCurrency { get; set; }
        public string PaymentCode { get; set; }
        public string TaxRegistrationCode1 { get; set; }
        public string TaxRegistrationCode2 { get; set; }
        public string TaxRegistrationCode3 { get; set; }
        public string TaxRegistrationCode4 { get; set; }
        public string TaxRegistrationCode5 { get; set; }
        public string DistributionType { get; set; }
        public string CheckLanguage { get; set; }
        public decimal AverageDaysToPay { get; set; }
        public decimal TotalInvoicesPaidFunctionalCurr { get; set; }
        public decimal TotalInvoicesPaidVendorCurr { get; set; }
        public decimal TotalNumberOfPayments { get; set; }
        public string TaxIncluded1 { get; set; }
        public string TaxIncluded2 { get; set; }
        public string TaxIncluded3 { get; set; }
        public string TaxIncluded4 { get; set; }
        public string TaxIncluded5 { get; set; }
        public string ContactsEmail { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string ContactsPhone { get; set; }
        public string ContactsFax { get; set; }
        public string DeliveryMethod { get; set; }
        public int PercentRetained { get; set; }
        public int DaysRetained { get; set; }
        public string RetainageTermsCode { get; set; }
        public decimal AmountRetainedVendorCurrency { get; set; }
        public decimal AmountRetainedFunctionalCurrency { get; set; }
        public int NumberOfOptionalFields { get; set; }
        public string ProcessCommandCode { get; set; }
        public int NextClientUniqueID { get; set; }
        public string LegalName { get; set; }
        public string Zero1099AmountWarning { get; set; }
        public bool SuppressIntegration { get; set; }
        public string APVersion { get; set; }
        public string Database { get; set; }
        public string Mode { get; set; }
        public string BusinessRegistrationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool FATCA { get; set; }
        public bool Num2ndTINNotice { get; set; }
        public string TaxWithholdingState { get; set; }
        public VendorOptionalFieldValues[] VendorOptionalFieldValues { get; set; }
        public object[] VendorContactSelection { get; set; }
        public string UpdateOperation { get; set; }
    }

    public class VendorOptionalFieldValues
    {
        public string VendorNumber { get; set; }
        public string OptionalField { get; set; }
        public string Value { get; set; }
        public string VendorOptionalFieldValueType { get; set; }
        public int Length { get; set; }
        public int Decimals { get; set; }
        public bool AllowBlank { get; set; }
        public bool Validate { get; set; }
        public string ValueSet { get; set; }
        public int TypedValueFieldIndex { get; set; }
        public string TextValue { get; set; }
        public decimal AmountValue { get; set; }
        public int NumberValue { get; set; }
        public int IntegerValue { get; set; }
        public bool YesNoValue { get; set; }
        public object DateValue { get; set; }
        public string TimeValue { get; set; }
        public string OptionalFieldDescription { get; set; }
        public string ValueDescription { get; set; }
        public string UpdateOperation { get; set; }
    }



}
