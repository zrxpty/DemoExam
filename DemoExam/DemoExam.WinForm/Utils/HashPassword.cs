using System.Security.Cryptography;
using System.Text;

namespace DemoExam.WinForm.Features.Utils
{
    internal static class HashPassword
    {
        public static string EncodePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return string.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);

                return Convert.ToBase64String(hashBytes);
            }
        }

        public static bool ConfirmPassword(string passwordInput, string passwordDb)
        {
            if (string.IsNullOrEmpty(passwordInput) || string.IsNullOrEmpty(passwordDb))
                return false;

            string hashedInput = EncodePassword(passwordInput);
            return hashedInput == passwordDb;
        }
    }
}
