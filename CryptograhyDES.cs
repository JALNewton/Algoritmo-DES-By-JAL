
using System;
using System.Security.Cryptography;

namespace src
{
    public static class DESEncryption
    {
        private static DESCryptoServiceProvider DESProvider = new DESCryptoServiceProvider()
        {
            Mode = CipherMode.CBC,
            Padding = PaddingMode.None
        };

        public static byte[] EncryptData(byte[] data, byte[] iv, byte[] key)
        {
            ICryptoTransform encryptor = DESProvider.CreateEncryptor(key, iv);
            return encryptor.TransformFinalBlock(data, 0, data.Length);
        }

        public static byte[] DecryptData(byte[] data, byte[] iv, byte[] key)
        {
            ICryptoTransform decryptor = DESProvider.CreateDecryptor(key, iv);
            return decryptor.TransformFinalBlock(data, 0, data.Length);
        }
    }
}
