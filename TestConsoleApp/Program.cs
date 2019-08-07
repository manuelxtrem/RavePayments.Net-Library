using RavePayments;
using RavePayments.Model;
using System;

namespace TestConsoleApp
{
    class Program
    {
        private static RaveOptions raveOptions = new RaveOptions
        {
            TestMode = true,
            PublicKey = "",
            SecretKey = ""
        };
        private static RaveCore Rave = new RaveCore(raveOptions);

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rave Payments!");
            Console.WriteLine("Created by manuexltrem!\n");
            Console.WriteLine("Type 1 for Card Payments");
            Console.WriteLine("Type 2 for Mobile Money Payments");
            Console.WriteLine("Type x to quit\n");

            var key = Console.ReadKey(true);

            do
            {
                //Console.WriteLine("You pressed a wrong key");
                key = Console.ReadKey(true);
            } while (key.KeyChar.ToString() != "1" && key.KeyChar.ToString() != "2" && key.KeyChar.ToString() != "x");

            switch(key.KeyChar.ToString())
            {
                case "1":
                    Console.WriteLine("\nYou pressed 1");

                    testCard();
                    break;

                case "2":
                    Console.WriteLine("\nYou pressed 2");

                    testMomo();
                    break;

                default:
                    return;
            }

            Console.WriteLine("\n\nPress any key to restart");
            Console.ReadKey(true);

            Console.Clear();
            Main(args);
        }

        static void testCard()
        {
            // test card payment
            RequestPayloadPayCard request = new RequestPayloadPayCard
            {
                PBFPubKey = raveOptions.PublicKey,
                cardno = "5399838383838381",
                cvv = "470",
                expirymonth = "10",
                expiryyear = "22",
                suggested_auth = "PIN",
                pin = "3310",
                currency = "GHS",
                country = "GH",
                amount = 10,
                email = "test@email.com",
                phonenumber = "0xxxxxxxxx",
                firstname = "Testeer",
                lastname = "Joe",
                IP = "127.0.0.1",
                txRef = "MC-" + DateTime.Now.ToString(), // your unique merchant reference
                // meta = [{ metaname: "flightID", metavalue: "123949494DC"}],
                device_fingerprint = "69e6b7f0b72037aa8428b70fbe03986c"
            };

            var task = Rave.PayViaCard(request);
            task.Wait();

            var task2 = Rave.ValidatePay(task.Result.data, "3310");
            task2.Wait();
        }

        static void testMomo()
        {
            // test card payment
            RequestPayloadPayMomoGH request = new RequestPayloadPayMomoGH
            {
                PBFPubKey = raveOptions.PublicKey,
                is_mobile_money_gh = 1,
                network = "MTN",
                currency = "GHS",
                country = "GH",
                amount = 10,
                email = "test@email.com",
                phonenumber = "0xxxxxxxxx",
                firstname = "Testeer",
                lastname = "Joe",
                IP = "127.0.0.1",
                txRef = "MC-" + DateTime.Now.ToString(), // your unique merchant reference
                // meta = [{ metaname: "flightID", metavalue: "123949494DC"}],
                device_fingerprint = "69e6b7f0b72037aa8428b70fbe03986c"
            };

            var task = Rave.PayViaMomoGH(request);
            task.Wait();

            //Console.WriteLine("yes");
            //var task2 = Rave.ValidatePay(task.Result.data, "3310");
            //task2.Wait();
        }

    }
}
