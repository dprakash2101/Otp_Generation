using System;
using System.Security.Cryptography;
using System.Text;

namespace Otp_Generation
{
    public class OtpGenerator
    {
        public static string GenerateOtp(int length, string secretKey)
        {
            if (length <= 0)
            {
                throw new ArgumentOutOfRangeException("OTP length must be greater than 0.");
            }

            if (string.IsNullOrEmpty(secretKey))
            {
                throw new ArgumentNullException("Secret key cannot be null or empty.");
            }

            using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(secretKey)))
            {
                var counter = BitConverter.GetBytes(DateTime.UtcNow.Ticks);
                var hash = hmac.ComputeHash(counter);

                var otp = new StringBuilder();
                for (int i = 0; i < length; i++)
                {
                    otp.Append((hash[i % hash.Length] % 10).ToString()); 
                }

                return otp.ToString();
            }
        }
    }
}