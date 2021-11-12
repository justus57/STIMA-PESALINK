using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPSs.Models.ISO20022class
{
    public class CreditTransferRequest
    {

        public string MessageID { get; set; }
        public string Purpose { get; set; }
        public string SourceAccountNo { get; set; }
        public string SourceAccountName { get; set; }
        public string SourcePhoneNo { get; set; }
        public string SourceAmount { get; set; }
        public string DestinationAccountNo { get; set; }
        public string DestinationBankCode { get; set; }

    }
    public class Accountverification
    {
        public string Status { get; set; }
        public string AccountName { get; set; }
    }
    public class Depositentry
    {
        public string Status { get; set; }
        public string AccountName { get; set; }
    }
    public class PaymentstatusrequestRequest
    {


        public string MessageID { get; set; }
        public string SourceAccountNo { get; set; }
        public string SourceAccountName { get; set; }
        public string SourcePhoneNo { get; set; }
        public string SourceAmount { get; set; }
        public string FeeAmount { get; set; }
        public string DestinationAccountNo { get; set; }
        public string DestinationBankCode { get; set; }
        public string DestinationMSISDN { get; set; }
    }  
    public class DepositPaymentStatusRequest
    {
        public string Status { get; set; }
        public string EntryNo { get; set; }
        public string SourceReferenceNo { get; set; }
        public string SourceBankCode { get; set; }
        public string SourceAccountNo { get; set; }
        public string SourceAccountName { get; set; }
        public string SourcePhoneNo { get; set; }
        public string AmountToTransfer { get; set; }
        public string DestinationAccountNo { get; set; }
    }
    public class SystemsNotification
    {
        public string EventParameters { get; set; }
        public string EventID { get; set; }
    }

}
