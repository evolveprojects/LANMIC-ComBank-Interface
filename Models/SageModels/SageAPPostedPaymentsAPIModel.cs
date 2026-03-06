using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LANMIC_ComBank_Interface.Enums;

namespace LANMIC_ComBank_Interface.Models.SageModels
{
    public class SageAPPostedPaymentsAPIModel
    {
        public string BankCode { get; set; }
        public string VendorNumber { get; set; } 

        public string VendorName { get; set; }
        public string Email { get; set; }
        public string SWIFT_Code { get; set; }
        public string BankAccountNo { get; set; }
        public string BankName { get; set; }

        public string CheckNumber { get; set; }
        public int CheckSerialNumber { get; set; }
        public DateTime CheckDate { get; set; }
        public DateTime BatchDate { get; set; }
        public decimal CheckAmountVendorCurrency { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public string PaymentCode { get; set; }
        public string CurrencyCode { get; set; }
        public string BankRateType { get; set; }
        public int BankExchangeRate { get; set; }
        public string BankRateOverridden { get; set; }
        public string ReasonForReversal { get; set; }
        public decimal AmountOfRoundingError { get; set; }
        public DateTime BankRateDate { get; set; }
        public string FiscalYear { get; set; }
        public string FiscalPeriod { get; set; }
        public string RemitTo { get; set; }
        public int BatchNumber { get; set; }
        public int EntryNumber { get; set; }
        public string CheckCleared { get; set; }
        public decimal CheckAmountFunctionalCurrency { get; set; }
        public decimal AmountAdjusted { get; set; }
        public object DateCleared { get; set; }
        public object DateReversed { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public int RateOperator { get; set; }
        public string PaymentType { get; set; }
        public int ClientUniqueID { get; set; }
        public string DrillDownApplicationSource { get; set; }
        public int DrillDownType { get; set; }
        public int DrillDownLinkNumber { get; set; }
        public string GLAccount { get; set; }
        public int MiscellaneousPaymentFlag { get; set; }
        public string JobRelated { get; set; }
        public string InvoiceNumber { get; set; }
        public string CalculateTaxAmountControl { get; set; }
        public string CalculateTaxBaseControl { get; set; }
        public string TaxGroup { get; set; }
        public string TaxAuthority1 { get; set; }
        public string TaxAuthority2 { get; set; }
        public string TaxAuthority3 { get; set; }
        public string TaxAuthority4 { get; set; }
        public string TaxAuthority5 { get; set; }
        public decimal TaxClass1 { get; set; }
        public decimal TaxClass2 { get; set; }
        public decimal TaxClass3 { get; set; }
        public decimal TaxClass4 { get; set; }
        public decimal TaxClass5 { get; set; }
        public decimal TaxBase1 { get; set; }
        public decimal TaxBase2 { get; set; }
        public decimal TaxBase3 { get; set; }
        public decimal TaxBase4 { get; set; }
        public decimal TaxBase5 { get; set; }
        public decimal TaxAmount1 { get; set; }
        public decimal TaxAmount2 { get; set; }
        public decimal TaxAmount3 { get; set; }
        public decimal TaxAmount4 { get; set; }
        public decimal TaxAmount5 { get; set; }
        public decimal TaxTotal { get; set; }
        public decimal DistributionAmountNetOfTaxes { get; set; }
        public decimal TaxAllocatedTotal { get; set; }
        public decimal TaxExpensedTotal { get; set; }
        public decimal TaxRecoverableTotal { get; set; }
        public string TaxReportingCurrencyCode { get; set; }
        public string TaxReportingCalculateMethod { get; set; }
        public int TaxReportingExchangeRate { get; set; }
        public string TaxReportingRateType { get; set; }
        public object TaxReportingRateDate { get; set; }
        public int TaxReportingRateOperator { get; set; }
        public decimal TaxReportingAmount1 { get; set; }
        public decimal TaxReportingAmount2 { get; set; }
        public decimal TaxReportingAmount3 { get; set; }
        public decimal TaxReportingAmount4 { get; set; }
        public decimal TaxReportingAmount5 { get; set; }
        public decimal TaxReportingTotal { get; set; }
        public decimal TaxReportingAllocatedTotal { get; set; }
        public decimal TaxReportingExpensedTotal { get; set; }
        public decimal TaxReportingRecoverableTotal { get; set; }
        public decimal FunctionalTaxBase1 { get; set; }
        public decimal FunctionalTaxBase2 { get; set; }
        public decimal FunctionalTaxBase3 { get; set; }
        public decimal FunctionalTaxBase4 { get; set; }
        public decimal FunctionalTaxBase5 { get; set; }
        public decimal FunctionalTaxAmount1 { get; set; }
        public decimal FunctionalTaxAmount2 { get; set; }
        public decimal FunctionalTaxAmount3 { get; set; }
        public decimal FunctionalTaxAmount4 { get; set; }
        public decimal FunctionalTaxAmount5 { get; set; }
        public decimal FunctionalTaxTotal { get; set; }
        public decimal FunctionalDistributionAmountNetOfTaxes { get; set; }
        public decimal FunctionalTaxAllocatedTotal { get; set; }
        public decimal FunctionalTaxExpensedTotal { get; set; }
        public decimal FunctionalTaxRecoverableTotal { get; set; }
        public int NumberOfAdvanceCreditClaims { get; set; }
        public decimal TotalAdvanceCreditClaim { get; set; }
        public decimal FunctionalTotalAdvanceCreditClaim { get; set; }
        public DateTime PostingDate { get; set; }
        public decimal TaxWithheld1 { get; set; }
        public decimal TaxWithheld2 { get; set; }
        public decimal TaxWithheld3 { get; set; }
        public decimal TaxWithheld4 { get; set; }
        public decimal TaxWithheld5 { get; set; }
        public decimal ReverseChargesBase1 { get; set; }
        public decimal ReverseChargesBase2 { get; set; }
        public decimal ReverseChargesBase3 { get; set; }
        public decimal ReverseChargesBase4 { get; set; }
        public decimal ReverseChargesBase5 { get; set; }
        public decimal ReverseChargesAmount1 { get; set; }
        public decimal ReverseChargesAmount2 { get; set; }
        public decimal ReverseChargesAmount3 { get; set; }
        public decimal ReverseChargesAmount4 { get; set; }
        public decimal ReverseChargesAmount5 { get; set; }
        public string UpdateOperation { get; set; }
        public PaymentStatus Status { get; internal set; }
        public string ErrorMessage { get; internal set; }
    }


}
