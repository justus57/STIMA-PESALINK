using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPSs.Models.AccountVerification

{
    public class AccountVerificationRequest
    {
        public string BackCode { get; set; }
        public string AccountNo { get; set; }
    }
    public class VerificationResponse
    {
        public string Backcode { get; set; }
        public string AccountNumber{ get; set; }
        public string AccountName { get; set; }
        public string message { get; internal set; }
        public bool status { get; set; }
    }
}
