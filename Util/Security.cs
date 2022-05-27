using System;
using System.Security.Cryptography;
using System.Text;

namespace TE11Manager.Util
{
    internal static class Security
    {
        public static string Hash(string input)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                var hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                return hash;
            }
        }
        public static string Hash(string input, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                var saltedInput = string.Format("{0}{1}", salt, input);
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedInput));
                var hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                return hash;
            }
        }
        public static string Encrypt(string input, string key)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.GenerateIV();
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                var iv = aes.IV;
                var encrypted = aes.CreateEncryptor().TransformFinalBlock(Encoding.UTF8.GetBytes(input), 0, input.Length);
                var ivString = Convert.ToBase64String(iv);
                var encryptedString = Convert.ToBase64String(encrypted);
                return string.Format("{0}:{1}", ivString, encryptedString);
            }
        }
        public static string Decrypt(string input, string key)
        {
            var split = input.Split(':');
            var iv = Convert.FromBase64String(split[0]);
            var encrypted = Convert.FromBase64String(split[1]);
            using (var aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                var decrypted = aes.CreateDecryptor().TransformFinalBlock(encrypted, 0, encrypted.Length);
                return Encoding.UTF8.GetString(decrypted);
            }
        }
    }
}
