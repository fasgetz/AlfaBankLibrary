using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlfaBankLibrary.Models.Responses
{
    public class Attribute
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class BankInfo
    {
        public string bankCountryCode { get; set; }
        public string bankCountryName { get; set; }
    }

    public class PaymentAmountInfo
    {
        public string paymentState { get; set; }
        public int approvedAmount { get; set; }
        public int depositedAmount { get; set; }
        public int refundedAmount { get; set; }
    }

    public class GetOrderResponse
    {
        public string errorCode { get; set; }
        public string errorMessage { get; set; }
        public string orderNumber { get; set; }
        public int orderStatus { get; set; }
        public int actionCode { get; set; }
        public string actionCodeDescription { get; set; }
        public int amount { get; set; }
        public string currency { get; set; }
        public long date { get; set; }
        public string orderDescription { get; set; }
        public List<object> merchantOrderParams { get; set; }
        public List<object> transactionAttributes { get; set; }
        public List<Attribute> attributes { get; set; }
        public string terminalId { get; set; }
        public PaymentAmountInfo paymentAmountInfo { get; set; }
        public BankInfo bankInfo { get; set; }
        public bool chargeback { get; set; }
    }
}
