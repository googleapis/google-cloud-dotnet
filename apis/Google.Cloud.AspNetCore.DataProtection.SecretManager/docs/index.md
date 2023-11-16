## Getting Started

The `Google.Cloud.AspNetCore.DataProtection.SecretManager` package allows storing ASP.NET Core keys in [Google Cloud Secret Manager](https://cloud.google.com/secret-manager).
The keys can be shared across several instances of a webapp. Apps can share authentication cookies
or CSRF protection across multiple servers

Follow the examples below to see how the library can be integrated into your application.

## Sample code

{{sample:DataProtectionExtensionMethods.RegisterSecretManagerClient}}

{{sample:DataProtectionExtensionMethods.RegisterGoogleCredentials}}

{{sample:DataProtectionExtensionMethods.UseDefaultSecretManagerClientWithADC}}
