using Newtonsoft.Json;
using RavePayments.Model;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RavePayments
{
    public class RaveCore
    {
        private static bool TESTMODE = false;
        private static string ENDPOINT = "https://api.ravepay.co";
        private static string ENDPOINT_SANDBOX = "https://ravesandboxapi.flutterwave.com";
        private static string PUBLIC_KEY = "";
        private static string SECRET_KEY = "";

        private static readonly HttpClient client = new HttpClient();

        public RaveCore(RaveOptions options) {
            TESTMODE = options.TestMode;
            PUBLIC_KEY = options.PublicKey;
            SECRET_KEY = options.SecretKey;
        }

        private string getUrl(string path)
        {
            return (TESTMODE ? ENDPOINT_SANDBOX : ENDPOINT) + '/' + path;
        }

        public async Task<ResponsePayload<ResponsePayloadPayCard>> PayViaCard(RequestPayloadPayCard request)
        {
            Console.WriteLine("PayViaCard => called");
            string requestContent = JsonConvert.SerializeObject(request);
            EncryptionService.RavePaymentDataEncryption en = new EncryptionService.RavePaymentDataEncryption();
            string encKey = en.GetEncryptionKey(SECRET_KEY);
            string cipher = en.EncryptData(encKey, requestContent);
            string requestBody = JsonConvert.SerializeObject(new RequestPayload {
                PBFPubKey = PUBLIC_KEY,
                client = cipher
            });

            var response = await client.PostAsync(getUrl("flwv3-pug/getpaidx/api/charge"), new StringContent(requestBody, Encoding.UTF8, "application/json"));

            var responseString = await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseString);

            return JsonConvert.DeserializeObject<ResponsePayload<ResponsePayloadPayCard>>(responseString);
        }

        public async Task<ResponsePayload<RequestPayloadPayMomoGH>> PayViaMomoGH(RequestPayloadPayMomoGH request)
        {
            Console.WriteLine("PayViaMomoGH => called");
            string requestContent = JsonConvert.SerializeObject(request);
            EncryptionService.RavePaymentDataEncryption en = new EncryptionService.RavePaymentDataEncryption();
            string encKey = en.GetEncryptionKey(SECRET_KEY);
            string cipher = en.EncryptData(encKey, requestContent);
            string requestBody = JsonConvert.SerializeObject(new RequestPayload
            {
                PBFPubKey = PUBLIC_KEY,
                client = cipher
            });

            var response = await client.PostAsync(getUrl("flwv3-pug/getpaidx/api/charge"), new StringContent(requestBody, Encoding.UTF8, "application/json"));

            var responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ResponsePayload<RequestPayloadPayMomoGH>>(responseString);
        }

        public async Task<ResponsePayload<ResponsePayloadValidate>> ValidatePay(ResponsePayloadPayCard payload, string OTP)
        {
            Console.WriteLine("ValidatePay => called");
            string requestBody = JsonConvert.SerializeObject(new RequestPayloadValidate
            {
                PBFPubKey = PUBLIC_KEY,
                transaction_reference = payload.flwRef,
                otp = OTP
            });

            var response = await client.PostAsync(getUrl("flwv3-pug/getpaidx/api/validatecharge"), new StringContent(requestBody, Encoding.UTF8, "application/json"));

            var responseString = await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseString);

            return JsonConvert.DeserializeObject<ResponsePayload<ResponsePayloadValidate>>(responseString);
        }
    }
}
