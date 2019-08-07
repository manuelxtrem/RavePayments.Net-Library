using System;
using System.Collections.Generic;
using System.Text;

namespace RavePayments.Model
{
    public class ResponsePayloadPayCard
    {
        public string message { get; set; }

        public string data { get; set; }

        public string txRef { get; set; }

        public string orderRef { get; set; }

        public string flwRef { get; set; }

        public string redirectUrl { get; set; }

        public string device_fingerprint { get; set; }

        public string settlement_token { get; set; }

        public string cycle { get; set; }

        public double amount { get; set; }

        public double charged_amount { get; set; }

        public double appfee { get; set; }

        public double merchantfee { get; set; }

        public int merchantbearsfee { get; set; }

        public string chargeResponseCode { get; set; }

        public string raveRef { get; set; }

        public string chargeResponseMessage { get; set; }

        public string authModelUsed { get; set; }

        public string currency { get; set; }

        public string IP { get; set; }

        public string narration { get; set; }

        public string status { get; set; }

        public string modalauditid { get; set; }

        public string vbvrespmessage { get; set; }

        public string authurl { get; set; }

        public string vbvrespcode { get; set; }

        public string acctvalrespmsg { get; set; }

        public string acctvalrespcode { get; set; }

        public string paymentType { get; set; }

        public string paymentPlan { get; set; }

        public string paymentPage { get; set; }

        public string paymentId { get; set; }

        public string fraud_status { get; set; }

        public string charge_type { get; set; }

        public int is_live { get; set; }

        public string retry_attempt { get; set; }

        public string getpaidBatchId { get; set; }

        public string createdAt { get; set; }

        public string updatedAt { get; set; }

        public string deletedAt { get; set; }

        public int customerId { get; set; }

        public int AccountId { get; set; }

        public object customer { get; set; }

        public bool customercandosubsequentnoauth { get; set; }

    }

}
