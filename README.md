# Otp Generation Sdk

OtpGenerationSdk is a .NET SDK for generating One-Time Passwords (OTPs). This SDK provides a simple and secure way to generate OTPs of various lengths using a secret key.

## Features

- Generate OTPs of specified length.
- Secure OTP generation using HMAC-SHA256 algorithm.
- Simple API for easy integration into .NET applications.

## Getting Started

### Prerequisites

- .NET 8.0 or later
- A .NET development environment (Visual Studio, Visual Studio Code, etc.)

### Installation

You can install the OtpGenerationSdk package via NuGet. Add the following package reference to your .NET project:

## Usage
Here is a basic example of how to use the OtpGenerator class to generate an OTP:
```sh
using OtpGenerationSdk;

class Program
{
    static void Main()
    {
        string secretKey = "your-secret-key";
        int otpLength = 6;

        string otp = OtpGenerator.GenerateOtp(otpLength, secretKey);

        Console.WriteLine($"Generated OTP: {otp}");
    }
}
```
## Contributing
1. Contributions are welcome! Please follow these steps to contribute:
2. Fork the repository.
3. Create a new branch (git checkout -b feature/your-feature).
4. Commit your changes (git commit -am 'Add new feature').
5. Push to the branch (git push origin feature/your-feature).
6. Create a new Pull Request.

License
This project is licensed under the MIT License. See the LICENSE file for details.

**Author: [Devi Prakash] ([https://github.com/dprakash2101](https://github.com/dprakash2101))**
