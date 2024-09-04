using NUnit.Framework;
using Otp_Generation;
using System;

namespace OtpGenerationSdk.Tests
{
    [TestFixture]
    public class OtpGeneratorTests
    {
        private const string SecretKey = "TestSecretKey";

        [Test]
        public void GenerateOtp_ShouldThrowArgumentOutOfRangeException_WhenLengthIsZero()
        {
            // Arrange
            int length = 0;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => OtpGenerator.GenerateOtp(length, SecretKey));
        }

        [Test]
        public void GenerateOtp_ShouldThrowArgumentNullException_WhenSecretKeyIsNull()
        {
            // Arrange
            string secretKey = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => OtpGenerator.GenerateOtp(6, secretKey));
        }

        [Test]
        public void GenerateOtp_ShouldReturnOtpOfSpecifiedLength()
        {
            // Arrange
            int length = 6;

            // Act
            var otp = OtpGenerator.GenerateOtp(length, SecretKey);

            // Assert
            Assert.AreEqual(length, otp.Length);
        }
        [Test]
        public void GenerateOtp_ShouldReturnOtpOfSpecifiedLength1()
        {
            // Arrange
            int length = 4;

            // Act
            var otp = OtpGenerator.GenerateOtp(length, SecretKey);

            // Assert
            Assert.AreEqual(length, otp.Length);
        }

        [Test]
        public void GenerateOtp_ShouldReturnOtpOfSpecifiedLength2()
        {
            // Arrange
            int length = 8;

            // Act
            var otp = OtpGenerator.GenerateOtp(length, SecretKey);

            // Assert
            Assert.AreEqual(length, otp.Length);
        }

        [Test]
        public void GenerateOtp_ShouldReturnOtpOfSpecifiedLength3()
        {
            // Arrange
            int length = 10;

            // Act
            var otp = OtpGenerator.GenerateOtp(length, SecretKey);

            // Assert
            Assert.AreEqual(length, otp.Length);
        }

        [Test]
        public void GenerateOtp_ShouldReturnOtpOfSpecifiedLength4()
        {
            // Arrange
            int length = 20;

            // Act
            var otp = OtpGenerator.GenerateOtp(length, SecretKey);

            // Assert
            Assert.AreEqual(length, otp.Length);
        }
        [Test]
        public void GenerateOtp_ShouldReturnOtpWithValidCharacters()
        {
            // Arrange
            int length = 6;

            // Act
            var otp = OtpGenerator.GenerateOtp(length, SecretKey);

            // Assert
            foreach (char c in otp)
            {
                Assert.IsTrue(char.IsDigit(c));
            }
        }
    }
}
