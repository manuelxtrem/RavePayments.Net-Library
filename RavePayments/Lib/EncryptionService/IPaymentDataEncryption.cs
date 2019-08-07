using System;

namespace EncryptionService
{
    public interface IPaymentDataEncryption
    {
        string GetEncryptionKey(string secretKey);
        string EncryptData(string encryptionKey, string data);
        string DecryptData(string encryptedData,string encryptionKey);
    }
}
