## Getting Started

The `Google.Cloud.AspNetCore.DataProtection.SecretManager` package allows storing ASP.NET keys in [Google Cloud Secret Manager](https://cloud.google.com/secret-manager).
The keys can be shared across several instances of a webapp. Apps can share authentication cookies
or CSRF protection across multiple servers

Follow the examples below to see how the library can be integrated into your application.

## Sample code
```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddDataProtection()
        .PersistKeysToGoogleCloudSecretManager("ProjectId", "SecretName", new SecretManagerServiceClient());

}
```
