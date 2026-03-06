using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LANMIC_ComBank_Interface.HelpServices
{
    public class CryptoHelper
    {
        private static readonly string Key = "YOUR_32_CHAR_SECRET_KEY"; // store in ENV
        private static readonly string IV = "YOUR_16_CHAR_IV";

        public static byte[] Encrypt(string plainText)
        {
            using var aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(Key);
            aes.IV = Encoding.UTF8.GetBytes(IV);

            using var encryptor = aes.CreateEncryptor();
            var bytes = Encoding.UTF8.GetBytes(plainText);
            return encryptor.TransformFinalBlock(bytes, 0, bytes.Length);
        }

        public static string Decrypt(byte[] cipherText)
        {
            using var aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(Key);
            aes.IV = Encoding.UTF8.GetBytes(IV);

            using var decryptor = aes.CreateDecryptor();
            var decrypted = decryptor.TransformFinalBlock(cipherText, 0, cipherText.Length);
            return Encoding.UTF8.GetString(decrypted);
        }
    }
}
