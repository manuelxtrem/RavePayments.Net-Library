# RavePayments.Net-Library
A Library for Flutterwave Rave Payments (Focuses on Card Payments and Mobile Money (GH))

# Demo
Edit the file `RavePayments\TestConsoleApp\Program.cs` and set your PublicKey and SecretKey values (Get these from Rave)

```C#
private static RaveOptions raveOptions = new RaveOptions
{
    TestMode = true,
    PublicKey = "",
    SecretKey = ""
};
```

For testing purposes, you will have to add real data to the RequestPayload model supplied to the `testCard()` and `testMomo()` methods in the same file
```C#
    email = "test@email.com",
    phonenumber = "0xxxxxxxxx",
    firstname = "Testeer",
    lastname = "Joe",
```

# Obtaining your API Keys
Your API keys are available in the Dashboard by navigating to `Settings - > API`.

# API References or Documentation
Check out Rave's API references for more info
https://developer.flutterwave.com/reference#introduction
