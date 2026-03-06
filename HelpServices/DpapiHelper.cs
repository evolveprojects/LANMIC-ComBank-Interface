using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LANMIC_ComBank_Interface.HelpServices
{
    public static class DpapiHelper
    {
        public static byte[] Encrypt(string plainText)
        {
            return ProtectedData.Protect(
                Encoding.UTF8.GetBytes(plainText),
                null,
                DataProtectionScope.LocalMachine
            );
        }

        public static string Decrypt(byte[] cipherText)
        {
            var bytes = ProtectedData.Unprotect(
                cipherText,
                null,
                DataProtectionScope.LocalMachine
            );
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
